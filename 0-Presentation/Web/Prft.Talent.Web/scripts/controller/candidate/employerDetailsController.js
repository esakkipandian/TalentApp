(function (angular) {
    var EmployerDetailsController = function ($scope, $controller, DTColumnBuilder, commonAPIservice, candidateCommonServices) {
        var _this = this;
        _this.title = "Candidate Employer Details";
        _this.service = commonAPIservice;
        _this.CandidateCommonServices = candidateCommonServices;


        $scope.employerInformation = [
         {
             id: 'emp',
             empname: '',
             empaddr: '',
             designation: '',
             jdate: [{}],
             rdate: [{}],
             reason: '',
             hrname: '',
             hraddr:''
         }
        ];

        $scope.addEmployerDetails = function () {           
            var addEmpDetails = $scope.employerInformation.length + 1;
            $scope.employerInformation.push({
                'id': 'emp' + addEmpDetails, 'empname': '', 'empaddr': '', 'designation': '', 'jdate': [{}], 'rdate': [{}],
                'reason': '','hrname': '','hraddr': ''});

        };

        $scope.removeEmployerDetails = function (index) {
            $scope.employerInformation.splice(index, 1);
        };

        //$scope.join = {
        //    opened: false
        //};

        //$scope.joinDate = function () {
        //    $scope.join.opened = true;
        //};
        $scope.open = function ($event, dt) {
            $event.preventDefault();
            $event.stopPropagation();
            dt.opened = true;
        };

    };
    EmployerDetailsController.$inject = ['$scope', '$controller', 'DTColumnBuilder', 'commonAPIservice', 'candidateCommonServices'];
    mainApp.controller('employerDetailsController', EmployerDetailsController);
})(angular);