(function () {
    'use strict';

    angular.module('app')
        .run(appRun);

    appRun.$inject = ['routerHelper', 'componentBaseUrl'];

    function appRun(routerHelper, componentBaseUrl) {
        routerHelper.configureStates(getStates(componentBaseUrl), 'flashcards');
    }

    function getStates(baseUrl) {
        return [
            {
                state: 'flashcardMain',
                config: {
                    url: '/flashcards',
                    templateUrl: format('{0}/flashcard/flashcardMainView.html', baseUrl),
                    controller: 'flashcardMainController as vm',
                    bindToController: true
                }
            },
            {
                state: 'flashcardAdd',
                config: {
                    url: '/flashcards/add',
                    templateUrl: format('{0}/flashcard/flashcardAddView.html', baseUrl),
                    controller: 'flashcardAddController as vm',
                    bindToController: true
                }
            },
            {
                state: 'flashcardRevision',
                config: {
                    url: '/flashcards/revise',
                    templateUrl: format('{0}/flashcard/flashcardRevisionView.html', baseUrl),
                    controller: 'flashcardRevisionController as vm',
                    bindToController: true
                }
            }
        ];
    }
})();