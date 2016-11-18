﻿(function (angular) {

    var CandidateInformationWizardController = function ($scope, $controller, $window) {
        $scope.tabs = [
          { title: 'Personal Information', url: 'html/candidatewizard/personalInformation.html' },
          { title: 'Educational Information', url: 'html/candidatewizard/Step2.html' },
          { title: 'Employer Information', url: 'html/candidatewizard/Step3.html' }
        ];


        $scope.selection = $scope.tabs[0];
        $scope.getCurrentTabIndex = function () {
            return $scope.tabs.indexOf($scope.selection);
        };


        $scope.goToTab = function (index) {
            if (typeof $scope.tabs[index] != 'undefined') {
                $scope.selection = $scope.tabs[index];
                $scope.active = index;
            }
        };


        $scope.hasNextTab = function () {
            var tabIndex = $scope.getCurrentTabIndex();
            var nextTab = tabIndex + 1;
            if (typeof $scope.tabs[nextTab] != 'undefined')
                return true;
        };

        $scope.hasPreviousTab = function () {
            var tabIndex = $scope.getCurrentTabIndex();
            var previousTab = tabIndex - 1;
            if (typeof $scope.tabs[previousTab] != 'undefined')
                return true;
        };

        $scope.incrementTab = function () {
            if ($scope.hasNextTab()) {
                var tabIndex = $scope.getCurrentTabIndex();
                var nextTab = tabIndex + 1;
                $scope.goToTab(nextTab);
            }
        };

        $scope.decrementTab = function () {
            if ($scope.hasPreviousTab()) {
                var tabIndex = $scope.getCurrentTabIndex();
                var previousTab = tabIndex - 1;
                $scope.goToTab(previousTab);
            }
        };
    };
    CandidateInformationWizardController.$inject = ['$scope', '$controller', '$window'];
    mainApp.controller('candidateInformationWizardController', CandidateInformationWizardController);
})(angular);