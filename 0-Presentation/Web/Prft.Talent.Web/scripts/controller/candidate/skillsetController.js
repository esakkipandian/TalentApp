(function (angular) {
    var SkillSetController = function ($scope, $controller, commonAPIservice) {
        var _this = this;
        _this.service = commonAPIservice;

        $scope.skillset = [
            {
                id: 'skill',
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
            $scope.skillset.push({ 'id': 'skill' + primarySkill, 'dates': { date } });

        };

        $scope.removeSkill = function (index) {
            $scope.skillset.splice(index, 1);
        };

        $scope.save = function () {
            _this.service.add('http://localhost:8080/api/Candidates/AddCandidateSkillSets/', $scope.Skills)
                            .then(function (response) {
                                _this.CandidateCommonServices.setCandidateId(response.data);
                                perfUtils.getInstance().successMsg(_this.title + ' added Successfully!');
                            });
        }
        $scope.open = function ($event, dt) {
            $event.preventDefault();
            $event.stopPropagation();
            dt.opened = true;
        };

      $scope.ratingStates = { stateOn: 'glyphicon-star', stateOff: 'glyphicon-star-empty' };
       

        loadSkillSets();

    };
    SkillSetController.$inject = ['$scope', '$controller', 'commonAPIservice'];
    mainApp.controller('skillSetController', SkillSetController);
})(angular);