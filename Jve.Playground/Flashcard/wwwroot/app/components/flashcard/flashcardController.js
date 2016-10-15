(function () {
    'use strict';

    angular.module('app')
        .controller('flashcardController', flashcardController);

    flashcardController.$inject = [];

    function flashcardController() {
        var vm = this;

        vm.helloWorld = "Hello from flashcardController!";
    }

})();