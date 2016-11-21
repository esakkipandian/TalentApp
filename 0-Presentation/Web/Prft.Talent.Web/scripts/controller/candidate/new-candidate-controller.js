﻿(function (angular) {
    var NewCandidateController = function ($scope, $controller, $window, commonAPIservice) {
        var _this = this;
        _this.service = commonAPIservice;

      
        $scope.save = function () {
            if ($scope.personalInformation.$error.required) {
                $scope.Submitted = true;
                return;
            }
            if ($scope.personalInformation.$error.email) { return }
            _this.service.add('http://localhost:8080/api/Candidates/AddPersonalInformation/', $scope.PersonalInformation);
        };

    };
    NewCandidateController.$inject = ['$scope', '$controller', '$window', 'commonAPIservice'];
    mainApp.controller('newcandidatecontroller', NewCandidateController);
})(angular);