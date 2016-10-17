(function () {
    'use strict';

    angular.module('app')
        .controller('flashcardMainController', flashcardMainController);

    flashcardMainController.$inject = [];

    function flashcardMainController() {
        var vm = this;

        vm.helloWorld = "Hello from flashcardMainController!";
    }

})();