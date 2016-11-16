(function (angular) {
    /* Designation Controller*/
    var CandidateInformationController = function ($scope, $controller, DTColumnBuilder) {
        var _this = this;
        $scope.dtColumns = [
            DTColumnBuilder.newColumn('Code').withTitle('Candidate Name'),
            DTColumnBuilder.newColumn('Description').withTitle('Phone number'),
              DTColumnBuilder.newColumn('Description').withTitle('Email ID')
        ];

        $scope.validate = function () {
            console.log('in validate');
        };

        var vm = {
            'title': 'Candidate Information',
            'formId': 'addressTypeForm',
            'scope': $scope,
            'addUrl': perfUrl['addCandidateName'],
            'updateUrl': perfUrl['updateCandidateName'],
            'deleteUrl': 'http://localhost:8080/api/AddressType',
            'loadListUrl': perfUrl['loadCandidateName']
        };
        angular.extend(this, $controller('AbstractController', { _this: _this, vm: vm }));
    };
    CandidateInformationController.$inject = ['$scope', '$controller', 'DTColumnBuilder'];
    mainApp.controller('candidateController', CandidateInformationController);
})(angular);