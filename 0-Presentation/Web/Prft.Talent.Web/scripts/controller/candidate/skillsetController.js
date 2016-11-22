(function (angular) {
    var SkillSetController = function ($scope, $controller, commonAPIservice, candidateCommonServices) {
        var _this = this;
        _this.title = "Skillset";
        _this.service = commonAPIservice;
        _this.CandidateCommonServices = candidateCommonServices;
        $scope.skillset = [
            {
                id: 0,
                dates: [{}]
            }
        ];

        $(document).ready(function () {
            $('[data-toggle="tooltip"]').tooltip();
        });

        var loadSkillSets = function () {
            var url = 'http://localhost:8080/api/skillset';
            _this.service.loadRecords(url)
                         .then(function (response) {
                             $scope.skillSets = response.data.skillSets;
                         });
        };

        $scope.addNewSkill = function () {
            var primarySkill = $scope.skillset.length + 1;
            var date = new Date();
            $scope.skillset.push({ 'id': primarySkill, 'dates': { date } });
        };

        $scope.removeSkill = function (index) {
            $scope.skillset.splice(index, 1);
        };

        $scope.saveSkill = function (recordIndex) {
            var candidateId = _this.CandidateCommonServices.getCandidateId();
            if (candidateId > 0) {
                var skillset = $scope.skillset[recordIndex];
                skillset.candidateId = candidateId;
                _this.service.add('http://localhost:8080/api/CandidateSkillSet/AddCandidateSkillSet/', skillset)
                    .then(function (response) {
                        perfUtils.getInstance().successMsg(_this.title + ' added Successfully!');
                    });
            }
        };

        $scope.opened = [];
        $scope.openDatePicker    = function ($event, index) {
            $event.preventDefault();
            $event.stopPropagation();
            $scope.opened[index] = true;
        };

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
                                 }
                                 else {
                                     $scope.skillset = [
                                         {
                                             id: 0,
                                             dates: [{}]
                                         }
                                     ];
                                     $scope.dates = [{}];
                                 }
                             });
            }
        };

        $scope.register = {};

        $scope.register.skillsets = [{
            value: true,
            name: "Primary"
        }, {
            value: false,
            name: "Secondary"
        }];

        $scope.ratingStates = { stateOn: 'glyphicon-star', stateOff: 'glyphicon-star-empty' };
        loadCandidateSkillSets();
        loadSkillSets();

    };
    SkillSetController.$inject = ['$scope', '$controller', 'commonAPIservice', 'candidateCommonServices'];
    mainApp.controller('skillSetController', SkillSetController);
})(angular);