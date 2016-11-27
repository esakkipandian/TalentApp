(function (angular) {
    var CandidateEducationController = function ($scope, $controller, DTColumnBuilder, commonAPIservice, candidateCommonServices) {
        var _this = this;
        _this.title = "Education Details";
        _this.service = commonAPIservice;
        _this.CandidateCommonServices = candidateCommonServices;

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
                             $scope.Courses = response.data.courses;
                         });
        };
        var loadQualification = function () {
            var url = 'http://localhost:8080/api/Qualification';
            _this.service.loadRecords(url)
                         .then(function (response) {
                             $scope.EducationQualification = response.data.qualification;
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

        $scope.save = function (recordIndex) {
            var candidateId = _this.CandidateCommonServices.getCandidateId();
            var education = $scope.qualification[recordIndex];
            var check = $scope.qualification[recordIndex].id;
            education.candidateId = candidateId;         
            if (check == "new") {
                $scope.qualification[recordIndex].id = 'q';
                _this.service.add('http://localhost:8080/api/EducationInformation/Post/', education)
              .then(function (response) {
                  perfUtils.getInstance().successMsg(_this.title + ' Added Successfully!');
              });
            }
            else {
                _this.service.update('http://localhost:8080/api/EducationInformation/Update/', education)
                                         .then(function (response) {
                                             perfUtils.getInstance().successMsg(_this.title + ' updated Successfully!');
                                         });
            }
        };

        $scope.addNewQualification = function () {
            var qualification = $scope.qualification.length + 1;
            $scope.qualification.push({ 'id': 'new', 'specialization': '', 'percentage': '' });

        };

        $scope.removeQualification = function (index) {
            $scope.qualification.splice(index, 1);
        };


        // Load Model data if Exsist
        var loadEducationInformation = function () {
            var candidateId = _this.CandidateCommonServices.getCandidateId();
            if (candidateId > 0) {
                var url = 'http://localhost:8080/api/EducationInformation/Get/' + candidateId;
                _this.service.loadRecords(url)
                             .then(function (response) {
                                 //$scope.qualification = response.data.educationalInformation;
                                 var cid = response.data.educationalInformation.length;
                                 if (cid > 0) {
                                     $scope.qualification = response.data.educationalInformation;
                                 }
                                 else {
                                     $scope.qualification = [
                                          {
                                              id:'new',
                                              specialization: '',
                                              percentage: ''
                                          }
                                     ];
                                 }
                             });
            }
        }

        //Load Drop Down Values 
        loadCourses();
        loadUniversities();
        loadColleges();
        loadQualification();

        //Load Model
        loadEducationInformation();

    };
    CandidateEducationController.$inject = ['$scope', '$controller', 'DTColumnBuilder', 'commonAPIservice', 'candidateCommonServices'];
    mainApp.controller('candidateEducationController', CandidateEducationController);
})(angular);

