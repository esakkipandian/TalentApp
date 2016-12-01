(function (angular) {  
    var InterviewFeedbackController = function ($scope, $controller, DTColumnBuilder) {
        $scope.dateofinterview = new Date();
        var _this = this;
        $scope.dtColumns = [
            DTColumnBuilder.newColumn('fullName').withTitle('Candidate Name'),
            DTColumnBuilder.newColumn('scheduledate').withTitle('Schedule Date'),
            DTColumnBuilder.newColumn('scheduletime').withTitle('Schedule Time')
        ];
        var vm = {
            'title': 'Scheduled Candidates',
            'formId': 'interviewForm',
            'scope': $scope,
            'addUrl': perfUrl['addDesignation'],
            'updateUrl': perfUrl['updateDesignation'],
            'deleteUrl': perfUrl['deleteDesignation'],
            'loadListUrl': perfUrl['loadCandidateInformation'],
            'actions': false
        };
        angular.extend(this, $controller('AbstractController', { _this: _this, vm: vm }));

        $scope.doi = {
            opened: false
        };

        $scope.doiDate = function () {
            $scope.doi.opened = true;
        };    
      
    };
    InterviewFeedbackController.$inject = ['$scope', '$controller', 'DTColumnBuilder'];
    mainApp.controller('interviewFeedbackController', InterviewFeedbackController);
})(angular);