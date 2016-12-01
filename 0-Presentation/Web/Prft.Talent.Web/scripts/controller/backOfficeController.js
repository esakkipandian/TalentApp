(function (angular) {
    var BackOfficeInformationController = function ($scope, $controller) {

        $scope.doi = {
            opened: false
        };

        $scope.doDate = function () {
            $scope.doi.opened = true;
        };

    };
    BackOfficeInformationController.$inject = ['$scope', '$controller'];
    mainApp.controller('backofficeInformationController', BackOfficeInformationController);
})(angular);