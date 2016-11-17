

app.controller('educationController', ['$scope', '$http', function ($scope, $http) {




    $scope.submitEducationalInformation = function () {
        if ($scope.PI.$error.required) {
            $scope.submitted = true;

            return;
        }


        var inputDate = $scope.EducationalInformation;
        $http({
            method: 'POST',
            url: '',
            data: $scope.EducationalInformation,//form user object
            headers: { 'Content-Type': 'application/x-www-form-urlencoded' }

        }).success(function (data) {
            if (!data.errors) {
                // Showing errors.
                $scope.message = "success";

            }
        })

    }
}]);
