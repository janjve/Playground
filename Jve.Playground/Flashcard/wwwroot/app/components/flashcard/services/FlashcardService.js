(function () {
    'use strict';

    angular.module('app')
        .service('flashcardService', flashcardService);

    flashcardService.$inject = ['$http', 'apiBaseUrl'];

    function flashcardService($http, apiBaseUrl) {
        var service = {
            getFlashcardBatch: getFlashcardBatch,
            getFlashcardList: getFlashcardList
        };

        return service;

        //////////////

        function getFlashcardBatch() {
            return $http.get(format('{0}/Flashcard/GetBatch', apiBaseUrl))
                .then(onComplete);

            function onComplete(response) {
                return response.data;
            }
        }

        function getFlashcardList() {
            return $http.get(format('{0}/Flashcard/GetAll', apiBaseUrl))
                .then(onComplete);

            function onComplete(response) {
                return response.data;
            }
        }


    }

})();