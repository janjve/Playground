(function() {
    'use strict';

    angular
        .module('app')
        .directive('flashcard', flashcardDirective);

    flashcardDirective.$inject = [];
    
    function flashcardDirective() {
        var directive = {
            templateUrl: '/wwwroot/app/components/flashcard/directories/flashcardView.html',
            restrict: 'EA',
            controller: flashcardController,
            controllerAs: 'vm',
            bindToController: true,
            scope: {
                front: '@',
                back: '@'
            }
        };
        return directive;
    }

    flashcardController.$inject = [];

    function flashcardController() {
        var vm = this;

    }

})();