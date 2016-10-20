(function () {
    'use strict';

    angular.module('app')
        .controller('flashcardMainController', flashcardMainController);

    flashcardMainController.$inject = ['flashcardService', '$state'];

    function flashcardMainController(flashcardService, $state) {
        var vm = this;

        vm.showAnswer = false;
        vm.toggleShowAnswer = toggleShowAnswer;
        vm.flashcards = [];
        vm.navigate = $state.go;

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