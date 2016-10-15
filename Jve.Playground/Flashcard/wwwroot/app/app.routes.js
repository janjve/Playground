(function () {
    'use strict';

    angular.module('app')
        .run(appRun);

    appRun.$inject = ['routerHelper'];

    function appRun(routerHelper) {
        routerHelper.configureStates(getStates(), 'cards');
    }

    function getStates() {
        var baseUrl = "wwwroot/app/components";
        return [
            {
                state: 'cards',
                config: {
                    url: '/cards',
                    templateUrl: format('{0}/flashcard/flashcardView.html', baseUrl),
                    controller: 'flashcardController as vm',
                    bindToController: true
                }
            }
        ];
    }
})();