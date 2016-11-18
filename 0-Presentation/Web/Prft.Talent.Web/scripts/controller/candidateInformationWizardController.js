(function (angular) {
    
    var CandidateInformationWizardController = function ($scope, $controller, $window) {
        $scope.tabs = [
          { title: 'Personal Information', content: 'Dynamic content 1', url: 'html/candidatewizard/Step1.html' },
          { title: 'Educational Information', content: 'Dynamic content 1', url: 'html/candidatewizard/Step2.html' },
        { title: 'Employer Information', content: 'Dynamic content 1', url: 'html/candidatewizard/Step3.html' }
          //{ title: 'Educational Qualifications', url: 'html/educationDetails.html' },
          //{ title: 'Skills', url: 'html/skillSet.html' },
          //{ title: 'Employment Details', url: 'html/employee.html' }

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