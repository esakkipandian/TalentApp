(function (angular) {
    /* Designation Controller*/
    var AddressTypeController = function ($scope, $controller, DTColumnBuilder) {
        var _this = this;
        $scope.dtColumns = [
            DTColumnBuilder.newColumn('Code').withTitle('Address Type Code'),
            DTColumnBuilder.newColumn('Description').withTitle('Address Type')
        ];

        $scope.validate = function () {
            console.log('in validate');
        };

        var vm = {
            'title': 'Address Types',
            'formId': 'addressTypeForm',
            'scope': $scope,
            'addUrl': 'http://localhost:8080/api/AddressType',
            'updateUrl': 'http://localhost:8080/api/AddressType',
            'deleteUrl': 'http://localhost:8080/api/AddressType',
            'loadListUrl': 'http://localhost:8080/api/AddressType'
        };
        angular.extend(this, $controller('AbstractController', { _this: _this, vm: vm }));
    };
    AddressTypeController.$inject = ['$scope', '$controller', 'DTColumnBuilder'];
    mainApp.controller('addressTypeController', AddressTypeController);
})(angular);