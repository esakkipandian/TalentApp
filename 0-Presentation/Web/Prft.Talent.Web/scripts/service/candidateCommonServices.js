(function(angular) {
    mainApp.factory('candidateCommonServices', ['$http',  function ($http) {
        var CandidateCommonService = {            
            CandidateDetails : {}
        };

        CandidateCommonService.addPersonalInformation = function (personalInformation) {
            CandidateCommonService.CandidateDetails.PersonalInformation = personalInformation;
        };

        CandidateCommonService.getPersonalInformation = function () {
            return CandidateCommonService.CandidateDetails.PersonalInformation;
        };

        CandidateCommonService.setCandidateId = function (candidateId) {
            CandidateCommonService.CandidateDetails.candidateId = candidateId;
        };

        CandidateCommonService.getCandidateId = function () {
            return CandidateCommonService.CandidateDetails.candidateId;
        };
	  
	    return CandidateCommonService;
	}]);
})(angular);