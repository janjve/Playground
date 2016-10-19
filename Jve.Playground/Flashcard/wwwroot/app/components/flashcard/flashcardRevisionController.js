(function () {
    'use strict';

    angular.module('app')
        .controller('flashcardRevisionController', flashcardRevisionController);

    flashcardRevisionController.$inject = [];

    function flashcardRevisionController() {
        var vm = this;

        vm.helloWorld = "Hello from flashcardRevisionController!";
    }

})();