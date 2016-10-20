(function () {
    'use strict';

    angular.module('app')
        .controller('flashcardRevisionController', flashcardRevisionController);

    flashcardRevisionController.$inject = ['flashcardService', '$state'];

    function flashcardRevisionController(flashcardService, $state) {
        var vm = this;

        vm.isLoading = false;
        vm.flashcardCache = [];     // To visit
        vm.flashcard = null;
        vm.showAnswer = false;

        vm.feedback = feedback;
        vm.nextFlashcard = nextFlashcard;
        vm.navigate = $state.go;

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

            vm.showAnswer = false;
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