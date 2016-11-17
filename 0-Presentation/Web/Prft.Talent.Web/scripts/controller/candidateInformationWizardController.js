(function (angular) {
    
    var CandidateInformationWizardController = function ($scope, $controller, $window) {
        $scope.tabs = [
          { title: 'Personal Information', content: 'Dynamic content 1', url: 'html/personalInformation.html' },
          { title: 'Educational Qualifications', url: 'html/educationDetails.html' },
          { title: 'Skills', url: 'html/skillSet.html' },
          { title: 'Employment Details', url: 'html/employee.html' }

        ];


        $scope.selection = $scope.tabs[0];
        $scope.getCurrentTabIndex = function () {
            return _.indexOf($scope.tabs, $scope.selection);
        };

        
        $scope.goToTab = function (index) {
            if (!_.isUndefined($scope.tabs[index])) {
                $scope.selection = $scope.tabs[index];
                $scope.active = index;
            }
        };


        $scope.hasNextTab = function () {
            var tabIndex = $scope.getCurrentTabIndex();
            var nextTab = tabIndex + 1;          
            return !_.isUndefined($scope.tabs[nextTab]);
        };

        $scope.hasPreviousTab = function () {
            var tabIndex = $scope.getCurrentTabIndex();
            var previousTab = tabIndex - 1;           
            return !_.isUndefined($scope.tabs[previousTab]);
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