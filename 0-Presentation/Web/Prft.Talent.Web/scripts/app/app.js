var mainApp = angular.module("prftApp",
        ['ngRoute', 'ngResource', 'ngAnimate', 'ngMessages',
         'mwl.calendar', 'ui.bootstrap', 'nya.bootstrap.select',
         'datatables', 'datatables.bootstrap', 'datatables.buttons', 'datatables.columnfilter',
         'ngSanitize', 'ui.select', 'ui.multiselect']);

(function(window){
    mainApp.value('user', {
        loggedUser:{}
    });
	
    /*Set the selected menu/sub-menu open on refresh/reload*/
    var pageEle = '#'+window.location.href.split('#')[1];
    $("#menu li a[href='"+pageEle+"']").parent().addClass('Selected');
	
    var rand = Math.floor(Math.random()*(3-1+1)+1);
	
    mainApp.config(function($routeProvider) {
        $routeProvider
          .when('/home', {
              templateUrl: 'html/dashboard.html',
              controller: ''
          })
          .when('/employee', {
              templateUrl: 'html/employee.html',
              controller: 'employeeController'
          })
            //.when('/addresstype', {
            //    templateUrl: 'html/addresstype.html',
            //    controller : 'addressTypeController'
            //})
            .when('/personalInformation', {
                templateUrl: 'html/basiccandiatedetails.html',
                controller: 'personalInformationController'
            })

            .when('/candidateinformationwizard', {
                templateUrl: 'html/candidateInformationWizard.html',
                controller: 'candidateInformationWizardController'
            })
              .when('/candidateInformation', {
                  templateUrl: 'html/candidateInformation.html',
                  controller: 'candidateController'
              })
           .when('/educationDetails', {
               templateUrl: 'html/educationDetails.html',
               controller: 'educationController'
           })
          .when('/fileupload', {
              templateUrl: 'html/candidatewizard/fileupload.html',
              controller: 'fileuploadController'
          })
          .when('/newcandidate', {
              templateUrl: 'html/candidatewizard/newcandidate.html',
              controller: 'newcandidatecontroller'
          })
         .when('/interviewfeedbackform', {
             templateUrl: 'html/interviewfeedback.html',
             controller: 'interviewFeedbackController'
         })
          .when('/employer', {
              templateUrl: 'html/candidatewizard/employerDetails.html',
              controller: 'employerDetailsController'
          })
            .when('/backofficeInformation', {
                templateUrl: 'html/backOfficeInformation.html',
                controller: 'backOfficeController'
            })

          .otherwise({
              redirectTo: '/home'
          });
    });
}(window));