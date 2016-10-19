(function () {
    'use strict';

    angular.module('app')
        .controller('flashcardAddController', flashcardAddController);

    flashcardAddController.$inject = [];

    function flashcardAddController() {
        var vm = this;

        vm.helloWorld = "Hello from flashcardAddController!";
    }

})();