(function (angular) {
    var FileuploadController = function ($scope, $controller, commonAPIservice, candidateCommonServices, fileuploadServices) {
        var _this = this;
        _this.service = commonAPIservice;
        _this.CandidateCommonServices = candidateCommonServices;

        $scope.uploadFile = function () {
            var file = $scope.candidateCV;
            var candidateId = _this.CandidateCommonServices.getCandidateId();
            var uploadUrl = "http://localhost:8080/api/candidatedocument", //Url of web service
                promise = fileuploadServices.uploadFileToUrl(file, candidateId, uploadUrl);

            promise.then(function (response) {
                $scope.serverResponse = response;
            }, function () {
                $scope.serverResponse = 'An error has occurred while uploading file.';
            })
        };

        var loadCandidateDocuments = function (candidateId) {
            var url = 'http://localhost:8080/api/candidatedocument/' + candidateId;
            _this.service.loadRecords(url)
                         .then(function (response) {
                             $scope.CandidateDocuments = response.data;
                         });
        };

        var candidateId = _this.CandidateCommonServices.getCandidateId();

        if (candidateId > 0) {
            loadCandidateDocuments(candidateId);
        };


    };
    FileuploadController.$inject = ['$scope', '$controller', 'commonAPIservice', 'candidateCommonServices', 'fileuploadServices'];
    mainApp.controller('fileuploadController', FileuploadController);
})(angular);