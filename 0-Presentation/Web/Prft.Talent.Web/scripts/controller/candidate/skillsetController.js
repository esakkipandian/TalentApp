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

        $scope.open = function ($event, dt) {
            $event.preventDefault();
            $event.stopPropagation();
            dt.opened = true;
        };

      $scope.ratingStates = { stateOn: 'glyphicon-star', stateOff: 'glyphicon-star-empty' };
      loadSkillSets();

    };
    SkillSetController.$inject = ['$scope', '$controller', 'commonAPIservice', 'candidateCommonServices'];
    mainApp.controller('skillSetController', SkillSetController);
})(angular);