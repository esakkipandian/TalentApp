(function (angular) {
    var PersonalInformationController = function ($scope, $controller, DTColumnBuilder, commonAPIservice) {
        var _this = this;
        _this.service = commonAPIservice;

        $scope.save = function () {
            if ($scope.personalInformation.$error.required){
                $scope.Submitted = true;
                return;
            }
            if ($scope.personalInformation.$error.email){return}
            _this.service.add('http://localhost:8080/api/Candidates/AddPersonalInformation/', $scope.PersonalInformation);
        };

        var loadPersonalInformation = function () {
            var url = 'http://localhost:8080/api/candidates/' + perfDatatable.recordId;
            _this.service.loadRecords(url)
                         .then(function (response) {
                             $scope.PersonalInformation = response.data;
                         });
        };
        loadPersonalInformation();
    };
    PersonalInformationController.$inject = ['$scope', '$controller', 'DTColumnBuilder', 'commonAPIservice'];
    mainApp.controller('personalInformationController', PersonalInformationController);
})(angular);

//mainApp.controller('personalInformationController', ['$scope', '$http', function ($scope, $http) {
//    $scope.Submitted = false;

//    $scope.submitPersonalInformation = function () {
//        if ($scope.PI.$error.required) {
//            $scope.submitted = true;

//            return;
//        }

//        var inputData = $scope.PersonalInformation;
//        $http({
//            method: 'POST',
//            url: 'http://localhost:8080/api/Candidates/AddPersonalInformation/',
//            data: $scope.PersonalInformation, //forms user object
//            headers: { 'Content-Type': 'application/json' }
//        }).success(function (data) {
//            if (!data.errors) {
//                // Showing errors.
//                $scope.message = "success";

//            }
//        });
//    }
//}]);

