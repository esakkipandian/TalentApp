var urlPrefix = '';
var apiUri = 'http://localhost:8080/api/';
var PerfWidgetCache = [];
var lastRequestTime = new Date().getTime();
var timeoutHandle;

(function(){
	mainApp.constant('factoryData',{
    });
	mainApp.constant('filterNames',{
        revertNewLine: 'revertNewLine',
        splitColon: 'splitColon',
        calculateDayDiff: 'calculateDayDiff'
    });
}());