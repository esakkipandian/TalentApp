(function (angular) {
    var PersonalInformationController = function ($scope, $controller, DTColumnBuilder, commonAPIservice, candidateCommonServices) {
        var _this = this;
        _this.title = "Candidate Basic Details";
        _this.service = commonAPIservice;
        _this.CandidateCommonServices = candidateCommonServices;

        $scope.toggle = function ($event) {
            $event.preventDefault();
            $event.stopPropagation();
            event[field] = !event[field];
        };

        $scope.save = function () {
            if ($scope.personalInformation.$error.required){
                $scope.Submitted = true;
                return;
            }
            if ($scope.personalInformation.$error.email) { return }

            if (_this.CandidateCommonServices.getCandidateId() > 0) {
                _this.service.update('http://localhost:8080/api/Candidates/UpdatePersonalInformation/', $scope.PersonalInformation)
                             .then(function (response) {
                                 _this.CandidateCommonServices.setCandidateId(response.data);
                                 perfUtils.getInstance().successMsg(_this.title + ' updated Successfully!');
                             });
            } else {
                _this.service.add('http://localhost:8080/api/Candidates/AddPersonalInformation/', $scope.PersonalInformation)
                             .then(function (response) {
                                 _this.CandidateCommonServices.setCandidateId(response.data);
                                 perfUtils.getInstance().successMsg(_this.title + ' added Successfully!');
                             });
            }
        };

        var loadPersonalInformation = function () {
            var url = 'http://localhost:8080/api/candidates/' + perfDatatable.recordId;
            _this.service.loadRecords(url)
                         .then(function (response) {
                             $scope.PersonalInformation = response.data;
                             perfDatatable.recordId = 0;
                         });
        };
        if (_this.CandidateCommonServices.getCandidateId() > 0) {
            loadPersonalInformation();
        };
    };
    PersonalInformationController.$inject = ['$scope', '$controller', 'DTColumnBuilder', 'commonAPIservice', 'candidateCommonServices'];
    mainApp.controller('personalInformationController', PersonalInformationController);
})(angular);