(function () {
    'use strict';

    angular.module('app')
        .controller('flashcardRevisionController', flashcardRevisionController);

    flashcardRevisionController.$inject = ['flashcardService'];

    function flashcardRevisionController(flashcardService) {
        var vm = this;

        vm.isLoading = false;
        vm.flashCardCache = [];
        vm.flashcard = null;

        activate();

        //////////////////
        
        function activate() {
            vm.isLoading = true;
            flashcardService.GetFlashcardBatch().then(function (result) {
                if (_.some(result)) {
                    vm.flashCard = result;
                    nextFlashcard();
                } else {
                    // Recently answered all cards.
                }
                vm.isLoading = false;
            });
        }

        function feedback(answer) {
            alert('callback with answer:' + answer);
            // Todo: report feedback.
            if (_.some(vm.flashCardCache)) {
                nextFlashcard();
            } else {
                // Empty cache, get new batch.
                activate();
            }
        }

        function nextFlashcard() {
            vm.flashCard = _.head(flashCardCache);
            vm.flashCardCache = _.tail(flashCardCache);
        }
    }

})();