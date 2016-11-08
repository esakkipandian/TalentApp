(function (angular) {
    /* Designation Controller*/
    var EmployeeController = function ($scope, $controller, DTColumnBuilder) {
        var _this = this;
        $scope.dtColumns = [
            DTColumnBuilder.newColumn('EmployeeId').withTitle('Employee Id'),
            DTColumnBuilder.newColumn('Name').withTitle('Name')
        ];

        var vm = {
            'title': 'Employees',
            'formId': 'employeeForm',
            'scope': $scope,
            'addUrl': perfUrl['addDesignation'],
            'updateUrl': perfUrl['updateDesignation'],
            'deleteUrl': perfUrl['deleteDesignation'],
            'loadListUrl': 'http://192.168.244.128:8080/api/Employee'
        };
        angular.extend(this, $controller('AbstractController', { _this: _this, vm: vm }));
    };
    EmployeeController.$inject = ['$scope', '$controller', 'DTColumnBuilder'];
    mainApp.controller('employeeController', EmployeeController);
})(angular);