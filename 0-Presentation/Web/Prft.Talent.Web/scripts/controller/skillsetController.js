(function (angular) {
var SkillSetController = function ($scope, $controller) {

    $scope.primaryskills = [
        {
            id: 'primaryskill'
            
        }
    ];

    $scope.addNewPrimarySkill = function () {       
        var primarySkill = $scope.primaryskills.length + 1;
        $scope.primaryskills.push({ 'id': 'primaryskill' + primarySkill });
    };

    $scope.removePrimarySkill = function (index) {        
        $scope.primaryskills.splice(index, 1);
    };

    
};
SkillSetController.$inject = ['$scope', '$controller'];
mainApp.controller('skillSetController', SkillSetController);
})(angular);