(function (angular) {
    var CandidateEducationController = function ($scope, $controller, DTColumnBuilder, commonAPIservice) {
        var _this = this;
        _this.service = commonAPIservice;

        var loadColleges = function () {
            var url = 'http://localhost:8080/api/colleges';
            _this.service.loadRecords(url)
                         .then(function (response) {
                             $scope.Colleges = response.data.collges;
                         });
        };


        $scope.save = function () {
            _this.service.add('http://localhost:8080/api/Candidates/AddEducationInformation/', $scope.EducationalInformation);
        };


        // Load Model data if Exsist
        var loadEducationInformation = function () {
            var url = 'http://localhost:8080/api/candidates/' + perfDatatable.recordId;
            _this.service.loadRecords(url)
                         .then(function (response) {
                             $scope.EducationalInformation = response.data;
                             perfDatatable.recordId = 0;
                         });
        }

        //Load Drop Down Values 
         loadColleges();
    };
    CandidateEducationController.$inject = ['$scope', '$controller', 'DTColumnBuilder', 'commonAPIservice'];
    mainApp.controller('candidateEducationController', CandidateEducationController);
})(angular);

