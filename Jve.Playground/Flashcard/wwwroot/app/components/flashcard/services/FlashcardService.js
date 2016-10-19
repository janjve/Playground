(function () {
    'use strict';

    angular.module('app')
        .service('flashcardService', flashcardService);

    flashcardService.$inject = ['$http', 'apiBaseUrl'];

    function flashcardService($http, apiBaseUrl) {
        var service = {
            getFlashcardBatch: getFlashcardBatch
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


    }

})();