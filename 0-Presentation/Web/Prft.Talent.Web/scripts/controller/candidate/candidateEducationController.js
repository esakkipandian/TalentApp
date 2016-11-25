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
              passedyear:[{}],
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

        $scope.save = function (recordIndex) {
            var candidateId = _this.CandidateCommonServices.getCandidateId();
            var education = $scope.qualification[recordIndex];
            education.candidateId = candidateId;
            
            _this.service.add('http://localhost:8080/api/EducationInformation/Post/', education)
          .then(function (response) {
              perfUtils.getInstance().successMsg(_this.title + ' Added Successfully!');
          });
        };

        $scope.addNewQualification = function () {
            var qualification = $scope.qualification.length + 1;
            $scope.qualification.push({ 'id': 'q' + qualification, 'specialization': '','passedyear':'' ,'percentage': '' });

        };
    
        $scope.removeQualification = function (index) {
            $scope.qualification.splice(index, 1);
        };

        $scope.open = function ($event, dt) {
            $event.preventDefault();
            $event.stopPropagation();
            dt.opened = true;
        };

        // Load Model data if Exsist
        var loadEducationInformation = function () {
            var candidateId = _this.CandidateCommonServices.getCandidateId();
            if (candidateId > 0) {
                var url = 'http://localhost:8080/api/EducationInformation/' + candidateId;
                _this.service.loadRecords(url)
                             .then(function (response) {
                                 $scope.EducationalInformation = response.data.educationalInformation;

                             });
            }
        }

        //Load Drop Down Values 
        loadCourses();
        loadUniversities();
        loadColleges();

        //Load Model
        loadEducationInformation();

    };
    CandidateEducationController.$inject = ['$scope', '$controller', 'DTColumnBuilder', 'commonAPIservice', 'candidateCommonServices'];
    mainApp.controller('candidateEducationController', CandidateEducationController);
})(angular);

