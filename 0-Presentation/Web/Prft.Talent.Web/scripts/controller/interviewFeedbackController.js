(function (angular) {  
    var InterviewFeedbackController = function ($scope, $controller, DTColumnBuilder) {
        $scope.hide = function () {
            return true;
        }
       
        $scope.dateofinterview = new Date();
        var _this = this;
        $scope.dtColumns = [
            DTColumnBuilder.newColumn('fullName').withTitle('Candidate Name'),
            DTColumnBuilder.newColumn('scheduledate').withTitle('Schedule Date'),
            DTColumnBuilder.newColumn('scheduletime').withTitle('Schedule Time')
        ];
        var vm = {
            'title': 'Scheduled Candidates',
            'formId': 'interviewForm',
            'scope': $scope,            
            'updateUrl': perfUrl['updateDesignation'],
            'deleteUrl': perfUrl['deleteDesignation'],
            'loadListUrl': perfUrl['loadCandidateInformation'],
            'deleteRow': false,
            'editRow':false
        };
        angular.extend(this, $controller('AbstractController', { _this: _this, vm: vm }));

        $scope.doi = {
            opened: false
        };

        $scope.doiDate = function () {
            $scope.doi.opened = true;
        };

        var ratingLevel = {
            "availableOptions": [
             { id: '0', name: 'NE' },
            { id: '1', name: '1' },
            { id: '2', name: '2' },
            { id: '3', name: '3' },
            { id: '4', name: '4' },
            { id: '5', name: '5' }
            ],
            educationBackgroundRating: { id: '0', name: 'NE' },
            technicalKnowledgeRating: { id: '0', name: 'NE' },
            experienceLevelRating: { id: '0', name: 'NE' },
            applicationSkillRating: { id: '0', name: 'NE' },
            abilityDemonstrateRating: { id: '0', name: 'NE' },
            communicationSkillsRating: { id: '0', name: 'NE' },
            analyticalSkillsRating: { id: '0', name: 'NE' },
            leadershipQualitiesRating: { id: '0', name: 'NE' },
            interestLevelRating: { id: '0', name: 'NE' }

        };
        $scope.Feedback = {};
        $scope.Feedback.RatingOptions = ratingLevel;     
    };
      
    };
    InterviewFeedbackController.$inject = ['$scope', '$controller', 'DTColumnBuilder'];
    mainApp.controller('interviewFeedbackController', InterviewFeedbackController);
})(angular);