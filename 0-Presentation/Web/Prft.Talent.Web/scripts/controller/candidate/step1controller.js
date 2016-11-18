(function (angular) {
    var Step1Controller = function ($scope, $controller, DTColumnBuilder, commonAPIservice) {
        var _this = this;
        _this.service = commonAPIservice;
        
        $scope.save = function () {
            console.log("Step 1 Loaded");
            _this.service.add(perfUrl['addAddressType'], $scope.data);
        };
    };
    Step1Controller.$inject = ['$scope', '$controller', 'DTColumnBuilder', 'commonAPIservice'];
    mainApp.controller('step1Controller', Step1Controller);
})(angular);