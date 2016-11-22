(function () {
    'use strict';
    mainApp.service('fileuploadServices', function ($http, $q) {

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
})();