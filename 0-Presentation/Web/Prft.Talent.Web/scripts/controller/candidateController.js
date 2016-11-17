(function (angular) {
    /* Designation Controller*/
    var CandidateInformationController = function ($scope, $controller, DTColumnBuilder) {
        var _this = this;
        $scope.dtColumns = [
            DTColumnBuilder.newColumn('fullName').withTitle('Candidate Name'),
            DTColumnBuilder.newColumn('mobile').withTitle('Phone number'),
            DTColumnBuilder.newColumn('email').withTitle('Email ID')
        ];

        $scope.validate = function () {
            console.log('in validate');
        };

        var vm = {
            'title': 'Candidate Information',
            'formId': 'addressTypeForm',
            'scope': $scope,
            'addUrl': perfUrl['addCandidateInformation'],
            'updateUrl': perfUrl['updateCandidateInformation'],
            'deleteUrl': 'http://localhost:8080/api/AddressType',
            'loadListUrl': perfUrl['loadCandidateInformation']
        };
        angular.extend(this, $controller('AbstractController', { _this: _this, vm: vm }));
    };
    CandidateInformationController.$inject = ['$scope', '$controller', 'DTColumnBuilder'];
    mainApp.controller('candidateController', CandidateInformationController);
})(angular);