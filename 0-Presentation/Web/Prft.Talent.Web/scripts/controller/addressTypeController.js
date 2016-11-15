(function (angular) {
    /* Designation Controller*/
    var AddressTypeController = function ($scope, $controller, DTColumnBuilder) {
        var _this = this;
        $scope.dtColumns = [
            DTColumnBuilder.newColumn('code').withTitle('Address Type Code'),
            DTColumnBuilder.newColumn('description').withTitle('Address Type')
        ];

        $scope.validate = function () {
            console.log('in validate');
        };

        var vm = {
            'title': 'Address Types',
            'formId': 'addressTypeForm',
            'scope': $scope,
            'addUrl': perfUrl['addAddressType'],
            'updateUrl': perfUrl['updateAddressType'],
            'deleteUrl': 'http://localhost:8080/api/AddressType',
            'loadListUrl': perfUrl['loadAddressType']
        };
        angular.extend(this, $controller('AbstractController', { _this: _this, vm: vm }));
    };
    AddressTypeController.$inject = ['$scope', '$controller', 'DTColumnBuilder'];
    mainApp.controller('addressTypeController', AddressTypeController);
})(angular);