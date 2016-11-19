(function (angular) {
    var SkillSetController = function ($scope, $controller) {

        $scope.primaryskills = [
            {
                id: 'primaryskill',
                dates: [
                {

                }
                ]

            }
        ];

        $scope.addNewPrimarySkill = function () {
            var primarySkill = $scope.primaryskills.length + 1;
            var date = new Date();
            $scope.primaryskills.push({ 'id': 'primaryskill' + primarySkill, 'dates': { date } });
            
        };

        $scope.removePrimarySkill = function (index) {
            $scope.primaryskills.splice(index, 1);
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