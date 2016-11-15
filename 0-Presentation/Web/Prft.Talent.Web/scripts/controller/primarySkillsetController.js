
mainApp.controller('PrimarySkillSetController', function ($scope) {

    $scope.primaryskills = [{ id: 'primaryskill' }];

    $scope.addNewPrimarySkill = function () {       
        var primarySkill = $scope.primaryskills.length + 1;
        $scope.primaryskills.push({ 'id': 'primaryskill' + primarySkill });
    };

    $scope.removePrimarySkill = function (index) {        
        $scope.primaryskills.splice(index, 1);
    };

});


