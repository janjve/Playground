(function () {
    'use strict';

    angular.module('app')
        .controller('flashcardRevisionController', flashcardRevisionController);

    flashcardRevisionController.$inject = ['flashcardService'];

    function flashcardRevisionController(flashcardService) {
        var vm = this;

        vm.isLoading = false;
        vm.flashcardCache = [];
        vm.flashcard = null;
        vm.feedback = feedback;

        activate();

        //////////////////
        
        function activate() {
            vm.isLoading = true;
            flashcardService.getFlashcardBatch().then(function (result) {
                if (_.some(result)) {
                    vm.flashcardCache = result;
                    nextFlashcard();
                } else {
                    vm.flashcardCache = [];
                    vm.flashcard = null;
                    // Recently answered all cards.
                }
                vm.isLoading = false;
            });
        }

        function feedback(answer) {
            // Todo: report feedback.
            if (_.some(vm.flashcardCache)) {
                nextFlashcard();
            } else {
                // Empty cache, get new batch.
                activate();
            }
        }

        function nextFlashcard() {
            vm.flashcard = _.head(vm.flashcardCache);
            vm.flashcardCache = _.tail(vm.flashcardCache);
        }
    }

})();