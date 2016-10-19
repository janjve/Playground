(function () {
    'use strict';

    angular.module('app')
        .service('flashcardService', flashcardService);

    flashcardService.$inject = ['apiBaseUrl'];

    function flashcardService($http, apiBaseUrl) {
        var service = {
            GetFlashcardBatch: GetFlashcardBatch
        };

        return service;

        //////////////

        function getFlashcards() {
            return $http.get(format('{0}/GetFlashcardBatch', apiBaseUrl))
                .then(onComplete);

            function onComplete(response) {
                return response.data;
            }
        }


    }

})();