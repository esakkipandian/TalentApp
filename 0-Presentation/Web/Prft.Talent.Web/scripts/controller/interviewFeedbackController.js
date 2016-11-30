(function (angular) {  
    var InterviewFeedbackController = function ($scope, $controller) {

        $scope.doi = {
            opened: false
        };

        $scope.doiDate = function () {
            $scope.doi.opened = true;
        };
     
    };
    InterviewFeedbackController.$inject = ['$scope', '$controller'];
    mainApp.controller('interviewFeedbackController', InterviewFeedbackController);
})(angular);