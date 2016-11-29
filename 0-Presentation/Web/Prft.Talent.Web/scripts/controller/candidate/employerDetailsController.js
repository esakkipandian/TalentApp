(function (angular) {
    var EmployerDetailsController = function ($scope, $controller, DTColumnBuilder, commonAPIservice, candidateCommonServices) {
        var _this = this;
        _this.title = "Candidate Employer Details";
        _this.service = commonAPIservice;
        _this.CandidateCommonServices = candidateCommonServices;

        $scope.join = {
            opened: false
        };

        $scope.joinDate = function () {
            $scope.join.opened = true;
        };

    };
    EmployerDetailsController.$inject = ['$scope', '$controller', 'DTColumnBuilder', 'commonAPIservice', 'candidateCommonServices'];
    mainApp.controller('employerDetailsController', EmployerDetailsController);
})(angular);