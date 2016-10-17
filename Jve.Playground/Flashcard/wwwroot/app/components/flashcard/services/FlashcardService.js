(function () {
    'use strict';

    angular.module('app')
        .service('flashcardService', flashcardService);

    flashcardService.$inject = ['apiBaseUrl'];

    function flashcardService($http, apiBaseUrl) {
        var service = {
            getFlashcards: getFlashcards
        };

        return service;

        //////////////

        function getFlashcards() {
            return $http.get(format('{0}/GetFlashcards', apiBaseUrl))
                .then(onComplete);

            function onComplete(response) {
                return response.data;
            }
        }


    }

})();