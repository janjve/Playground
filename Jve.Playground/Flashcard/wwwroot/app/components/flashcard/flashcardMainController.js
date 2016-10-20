(function () {
    'use strict';

    angular.module('app')
        .controller('flashcardMainController', flashcardMainController);

    flashcardMainController.$inject = ['flashcardService'];

    function flashcardMainController(flashcardService) {
        var vm = this;

        vm.showAnswer = false;
        vm.toggleShowAnswer = toggleShowAnswer;
        vm.flashcards = [];

        activate();

        ///////////////////////

        function activate() {
            flashcardService.getAllFlashcards().then(function (result) {
                vm.flashcards = result;
            });
        }

        function toggleShowAnswer() {
            vm.showAnswer = !vm.showAnswer;
        }
    }

})();