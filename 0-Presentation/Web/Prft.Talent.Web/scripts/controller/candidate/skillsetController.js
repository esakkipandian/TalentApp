(function (angular) {
    var SkillSetController = function ($scope, $controller) {

        $scope.skillset = [
            {
                id: 'skill',
                dates: [{}]
            }
        ];

        $scope.addNewSkill = function () {
            var primarySkill = $scope.skillset.length + 1;
            var date = new Date();
            $scope.skillset.push({ 'id': 'skill' + primarySkill, 'dates': { date } });
            
        };

        $scope.removeSkill = function (index) {
            $scope.skillset.splice(index, 1);
        };


        $scope.open = function ($event, dt) {
            $event.preventDefault();
            $event.stopPropagation();
            dt.opened = true;
        };

        $scope.rate = 1;
        $scope.max = 5;

        $scope.ratingStates = { stateOn: 'glyphicon-star', stateOff: 'glyphicon-star-empty' };

        $scope.submit = function () {
            $scope.submitted = true;
        }

    };
    SkillSetController.$inject = ['$scope', '$controller'];
    mainApp.controller('skillSetController', SkillSetController);
})(angular);