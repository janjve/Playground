(function () {
    'use strict';

    angular.module('app')
        .controller('flashcardMainController', flashcardMainController);

    flashcardMainController.$inject = ['flashcardService'];

    function flashcardMainController(flashcardService) {
        var vm = this;

        vm.showAnswer = false;
        vm.toggleShowAnswer = toggleShowAnswer;

        activate();

        ///////////////////////

        function activate() {
            //flashcardService.get
        }

        function toggleShowAnswer() {
            vm.showAnswer = !vm.showAnswer;
        }
    }

})();