(function (angular) {
    var CandidateEducationController = function ($scope, $controller, DTColumnBuilder, commonAPIservice) {
        var _this = this;
        _this.service = commonAPIservice;
       

       // loadColleges();
        //Load Drop Down Values 
       // var loadColleges = function () {
            var url = 'http://localhost:8080/api/colleges';
            _this.service.loadRecords(url)
                         .then(function (response) {
                             $scope.Colleges = response.data.collges;
                         });
       // };

        // Load Model data if Exsist
        var loadEducationInformation = function () {
            var url = 'http://localhost:8080/api/candidates/' + perfDatatable.recordId;
            _this.service.loadRecords(url)
                         .then(function (response) {
                             $scope.EducationalInformation = response.data;
                             perfDatatable.recordId = 0;
                         });
        }

        // Save and update Records to the WebAPI
        $scope.save = function () {
            _this.service.add('http://localhost:8080/api/Candidates/AddPersonalInformation/', $scope.EducationalInformation);
        };
    };
    CandidateEducationController.$inject = ['$scope', '$controller', 'DTColumnBuilder', 'commonAPIservice'];
    mainApp.controller('candidateEducationController', CandidateEducationController);
})(angular);

