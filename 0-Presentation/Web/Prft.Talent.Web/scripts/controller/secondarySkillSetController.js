mainApp.controller('SecondarySkillSetController', function ($scope) {

    $scope.secondaryskills = [{ id: 'secondaryskill' }];

    $scope.addNewSecondarySkill = function () {
        var secondarySkill = $scope.secondaryskills.length + 1;
        $scope.secondaryskills.push({ 'id': 'secondaryskill' + secondarySkill });
    };

    $scope.removeSecondarySkill = function (index) {
        $scope.secondaryskills.splice(index, 1);
    };

});