(function () {
    'use strict';
    mainApp.service('fileuploadServices', function ($http, $q, commonAPIservice) {
        _this.service = commonAPIservice;
        this.uploadFileToUrl = function (file, id, uploadUrl) {
            var fileFormData = new FormData();
            fileFormData.append('file', file);
            fileFormData.append('CandidateId', id);

            var deffered = $q.defer();
            $http.post(uploadUrl, fileFormData, {
                transformRequest: angular.identity,
                headers: { 'Content-Type': undefined }

            }).success(function (response) {
                deffered.resolve(response);

            }).error(function (response) {
                deffered.reject(response);
            });

            return deffered.promise;
        }
    });
    var loadCandidateDocuments = function () {
        var url = 'http://localhost:8080/api/candidatedocument/' + perfDatatable.recordId;
        _this.service.loadRecords(url)
                     .then(function (response) {
                         $scope.CandidateDocuments = response.data;
                         perfDatatable.recordId = 0;
                     });
    };
    //if (_this.CandidateCommonServices.getCandidateId() > 0) {
        loadCandidateDocuments();
    //};
})();