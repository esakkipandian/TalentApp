(function () {
    'use strict';
    mainApp.controller('fileuploadController', function ($scope, fileuploadServices) {

        $scope.uploadFile = function () {
            var file = $scope.candidateCV;
            var uploadUrl = "http://localhost:8080/api/CandidateDocument", //Url of web service
                promise = fileuploadServices.uploadFileToUrl(file, uploadUrl);

            promise.then(function (response) {
                $scope.serverResponse = response;
            }, function () {
                $scope.serverResponse = 'An error has occurred while uploading file.';
            })
        };
    });

})();
