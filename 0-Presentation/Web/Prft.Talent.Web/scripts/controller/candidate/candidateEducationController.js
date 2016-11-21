(function (angular) {
    var CandidateEducationController = function ($scope, $controller, DTColumnBuilder, commonAPIservice) {
        var _this = this;
        _this.service = commonAPIservice;

        $scope.qualification = [
          {
              id: 'q',
              specialization: '',
              percentage: '',
          }
        ];

        var loadCourses = function () {
            var url = 'http://localhost:8080/api/Courses';
            _this.service.loadRecords(url)
                         .then(function (response) {
                             $scope.Courses = response.data.courses
                         });
        };
        var loadUniversities = function () {
            var url = 'http://localhost:8080/api/University';
            _this.service.loadRecords(url)
                         .then(function (response) {
                             $scope.Universities = response.data.universities;
                         });
        };
        var loadColleges = function () {
            var url = 'http://localhost:8080/api/Colleges';
            _this.service.loadRecords(url)
                         .then(function (response) {
                             $scope.Colleges = response.data.colleges;
                         });
        };      

        $scope.save = function () {
            _this.service.add('http://localhost:8080/api/Candidates/AddEducationInformation/', $scope.EducationalInformation);
        };

        $scope.addNewQualification = function () {
            var qualification = $scope.qualification.length + 1;
            $scope.qualification.push({ 'id': 'q' + qualification, 'specialization': '','percentage':'' });

        };

        $scope.removeQualification = function (index) {
            $scope.qualification.splice(index, 1);
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
        loadCourses();
        loadUniversities();
        loadColleges();
        
    };
    CandidateEducationController.$inject = ['$scope', '$controller', 'DTColumnBuilder', 'commonAPIservice'];
    mainApp.controller('candidateEducationController', CandidateEducationController);
})(angular);

