

mainApp.controller('personalInformationController', ['$scope', '$http', function ($scope, $http) {
    $scope.Submitted = false;

    $scope.submitPersonalInformation = function () {
        if ($scope.PI.$error.required) {
            $scope.submitted = true;

            return;
        }

        var inputData = $scope.PersonalInformation;
        $http({
            method: 'POST',
            url: 'http://localhost:8080/api/Candidates/AddPersonalInformation/',
            data: $scope.PersonalInformation, //forms user object
            headers: { 'Content-Type': 'application/json' }
        }).success(function (data) {
            if (!data.errors) {
                // Showing errors.
                $scope.message = "success";

            }
        });
    }
}]);

