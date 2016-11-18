(function (angular) {
    /* Designation Controller*/
    var Step1Controller = function ($scope, $controller, DTColumnBuilder) {
        var _this = this;
        
        $scope.save = function () {
            console.log("Step 1 Loaded");
        };
        //var vm = {
        //    'title': 'Step 1',
        //    'formId': 'step1candicatewizard',
        //    'scope': $scope,
        //    'addUrl': perfUrl['addAddressType'],
        //    'updateUrl': perfUrl['updateAddressType'],
        //    'deleteUrl': perfUrl['deleteAddressType'],
        //    'loadListUrl': ''
        //};
        //angular.extend(this, $controller('AbstractController', { _this: _this, vm: vm }));
    };
    Step1Controller.$inject = ['$scope', '$controller', 'DTColumnBuilder'];
    mainApp.controller('step1Controller', Step1Controller);
})(angular);