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

        $scope.add = function () {
            console.log("Add Called");
        }

        var vm = {
            'title': 'Candidates',
            'formId': '',
            'scope': $scope,
            'addUrl': perfUrl['addCandidateInformation'],
            'updateUrl': perfUrl['updateCandidateInformation'],
            'deleteUrl': perfUrl['deleteCandidateInformation'],
            'loadListUrl': perfUrl['loadCandidateInformation'],
            'navigateToUrl': true,
            'addNavigateUrl': 'candidateinformationwizard',
            'editNavigateUrl': 'candidateinformationwizard'
        };
        angular.extend(this, $controller('AbstractController', { _this: _this, vm: vm }));
    };
    CandidateInformationController.$inject = ['$scope', '$controller', 'DTColumnBuilder'];
    mainApp.controller('candidateController', CandidateInformationController);
})(angular);