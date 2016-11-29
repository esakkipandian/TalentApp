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

        var loadCourses = function (qId) {
            var url = 'http://localhost:8080/api/Courses/' + qId;
            _this.service.loadRecords(url)
                         .then(function (response) {
                             $scope.Courses = response.data.courses;
                         });
        };
        var loadQualification = function () {
            var url = 'http://localhost:8080/api/Qualification';
            _this.service.loadRecords(url)
                         .then(function (response) {
                             $scope.Qualification = response.data.qualification;
                         });
        };
        var loadUniversities = function (qId) {
            var url = 'http://localhost:8080/api/University/' + qId;
            _this.service.loadRecords(url)
                         .then(function (response) {
                             $scope.Universities = response.data.universities;
                         });
        };
        var loadColleges = function (qId) {
            var url = 'http://localhost:8080/api/Colleges/' + qId;
            _this.service.loadRecords(url)
                         .then(function (response) {
                             $scope.Colleges = response.data.colleges;

                         });
        };
        $scope.onQualificationChange = function (itemSelected) {
            loadCourses(itemSelected);
            loadUniversities(itemSelected);
            loadColleges(itemSelected);
        }

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
                  loadEducationInformation();

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
                                              id: 'new',
                                              specialization: '',
                                              percentage: ''
                                          }
                                     ];
                                 }
                             });
            }
        }

        //Load Drop Down Values 
        loadCourses(0);
        loadUniversities(0);
        loadColleges(0);
        loadQualification();

        //Load Model
        loadEducationInformation();

    };
    CandidateEducationController.$inject = ['$scope', '$controller', 'DTColumnBuilder', 'commonAPIservice', 'candidateCommonServices'];
    mainApp.controller('candidateEducationController', CandidateEducationController);
})(angular);

