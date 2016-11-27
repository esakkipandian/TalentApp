(function (angular) {
    var SkillSetController = function ($scope, $controller, $filter, commonAPIservice, candidateCommonServices) {

        //Initialization
        var _this = this;
        _this.title = "Skillset";
        _this.service = commonAPIservice;
        _this.CandidateCommonServices = candidateCommonServices;
        $scope.skillset = [];
        $scope.dates = []; 
        
        //Button Tooltips
        $(document).ready(function () {
            $('[data-toggle="tooltip"]').tooltip();
        });

        //Function to load Skills Autocomplete
        var loadSkillSets = function () {
            var url = 'http://localhost:8080/api/skillset';
            _this.service.loadRecords(url)
                         .then(function (response) {
                             $scope.skillSets = response.data.skillSets;
                         });
        };

        //Function to load Candidate Skill Sets 
        var loadCandidateSkillSets = function () {
            var candidateId = _this.CandidateCommonServices.getCandidateId();
            if (candidateId > 0) {
                var url = 'http://localhost:8080/api/CandidateSkillSet/GetCandidateSkillSet/' + candidateId;
                _this.service.loadRecords(url)
                             .then(function (response) {
                                 var skillSetLength = response.data.length;
                                 if (skillSetLength > 0) {
                                     $scope.skillset = response.data;
                                     $scope.dates = [{}];
                                     angular.forEach($scope.skillset, function (value, key) {                                         
                                             var sinceLastUsed = new Date($scope.skillset[key].sinceLastUsed);
                                             $scope.skillset[key].sinceLastUsed = ((sinceLastUsed.getMonth() + 1) + "/" + sinceLastUsed.getDate() + "/" + sinceLastUsed.getFullYear());
                                             
                                     });
                                 }
                                 else {
                                     $scope.skillset = [$scope.candidateSkillSetForm];
                                     $scope.dates = [{}];
                                 }
                             });
            }
        };

        //Function to save and add new Skill
        $scope.addNewSkill = function (recordIndex) {            
            var skillset = $scope.skillset[recordIndex];
            if (skillset.pk >= 0 )
                $scope.skillset.push({});
            else {
                if (!skillset.skillId || !skillset.rating || !skillset.sinceLastUsed || typeof skillset.isPrimary == 'undefined') {
                    perfUtils.getInstance().successMsg('All Fields are mandatory');
                    return;
                }
                var candidateId = _this.CandidateCommonServices.getCandidateId();
                    if (candidateId > 0) {
                        var skillset = $scope.skillset[recordIndex];
                            skillset.candidateId = candidateId;
                            _this.service.add('http://localhost:8080/api/CandidateSkillSet/AddCandidateSkillSet/', skillset)
                                .then(function (response) {                                   
                                    perfUtils.getInstance().successMsg(_this.title + ' added Successfully!');
                                });     
                    }
                    $scope.skillset.push({});
            }
        };

        //Function to Save skill
        $scope.saveSkill = function (recordIndex) {
            var skillset = $scope.skillset[recordIndex];
            if (!skillset.skillId || !skillset.rating || !skillset.sinceLastUsed || typeof skillset.isPrimary == 'undefined') {
                perfUtils.getInstance().successMsg('All Fields are mandatory');
                return;
            }
            var candidateId = _this.CandidateCommonServices.getCandidateId();
            if (candidateId > 0) {
                if (skillset.pk > 0) {
                    alert("Updated Successfully");                 
                }
                else
                {
                    skillset.candidateId = candidateId;
                    _this.service.add('http://localhost:8080/api/CandidateSkillSet/AddCandidateSkillSet/', skillset)
                        .then(function (response) {                            
                            loadCandidateSkillSets();
                            perfUtils.getInstance().successMsg(_this.title + ' added Successfully!');
                        });
                }
            }
        };

        //Function to Delete Skill
        $scope.deleteSkill = function (recordIndex) {
            var candidateId = _this.CandidateCommonServices.getCandidateId();
            var skillset = $scope.skillset[recordIndex]; 
            if (candidateId > 0 && typeof skillset.isPrimary != 'undefined') {
                _this.service.updateDel('http://localhost:8080/api/CandidateSkillSet/DeleteCandidateSkillSet/',skillset)
                    .then(function (response) {
                        $scope.skillset.splice(recordIndex, 1);
                        perfUtils.getInstance().successMsg(_this.title + ' deleted Successfully!');
                    });
            }
            else
                $scope.skillset.splice(recordIndex, 1);
        };
       
        //Function to open Datepicker
        $scope.opened = [];
        $scope.open   = function ($event, index) {
            $event.preventDefault();
            $event.stopPropagation();
            $scope.opened[index] = true;
        };

        //Load Skill Type Dropdown
        $scope.register = {};
        $scope.register.skillsets = [{
            value: true,
            name: "Primary"
        }, {
            value: false,
            name: "Secondary"
        }];
               
        //Star Rating Directive
        $scope.ratingStates = { stateOn: 'glyphicon-star', stateOff: 'glyphicon-star-empty' };

        //Functions during page load
        loadCandidateSkillSets();
        loadSkillSets();
    };
    SkillSetController.$inject = ['$scope', '$controller','$filter', 'commonAPIservice', 'candidateCommonServices'];
    mainApp.controller('skillSetController', SkillSetController);
})(angular);