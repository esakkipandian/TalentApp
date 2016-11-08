(function (angular) {
    /* Designation Controller*/
    var InterviewController = function ($scope, $controller, DTColumnBuilder) {
        var _this = this;
        $scope.dtColumns = [
            DTColumnBuilder.newColumn('designation').withTitle('Job Title'),
            DTColumnBuilder.newColumn('sbu').withTitle('SBU')
        ];

        var vm = {
            'title': 'Interview',
            'formId': 'interviewForm',
            'scope': $scope,
            'addUrl': perfUrl['addDesignation'],
            'updateUrl': perfUrl['updateDesignation'],
            'deleteUrl': perfUrl['deleteDesignation'],
            'loadListUrl': perfUrl['loadDesignations']
        };
        angular.extend(this, $controller('AbstractController', { _this: _this, vm: vm }));
    };
    InterviewController.$inject = ['$scope', '$controller', 'DTColumnBuilder'];
    mainApp.controller('interviewController', InterviewController);
})(angular);