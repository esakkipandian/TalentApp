(function (angular) {

    var CandidateInformationWizardController = function ($scope, $controller, $window, candidateCommonServices) {
        var _this = this;
        _this.CandidateCommonServices = candidateCommonServices;

        if (perfDatatable.recordId) {
            _this.CandidateCommonServices.setCandidateId(perfDatatable.recordId);
        };

        $scope.tabs = [
          { title: 'Personal Details', url: 'html/candidatewizard/personalInformation.html' },
          { title: 'Educational Details', url: 'html/candidatewizard/educationDetails.html' },
          { title: 'Skillset Details', url: 'html/candidatewizard/skillset.html' },
          { title: 'Resume', url: 'html/candidatewizard/fileupload.html' }
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
    CandidateInformationWizardController.$inject = ['$scope', '$controller', '$window', 'candidateCommonServices'];
    mainApp.controller('candidateInformationWizardController', CandidateInformationWizardController);
})(angular);