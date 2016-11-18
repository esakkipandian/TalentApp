(function (angular) {
    var CandidateEducationController = function ($scope, $controller, DTColumnBuilder, commonAPIservice) {
        var _this = this;
        _this.service = commonAPIservice;

        $scope.save = function () {
            _this.service.add('http://localhost:8080/api/Candidates/AddPersonalInformation/', $scope.EducationalInformation);
        };
    };
    CandidateEducationController.$inject = ['$scope', '$controller', 'DTColumnBuilder', 'commonAPIservice'];
    mainApp.controller('candidateEducationController', CandidateEducationController);
})(angular);

