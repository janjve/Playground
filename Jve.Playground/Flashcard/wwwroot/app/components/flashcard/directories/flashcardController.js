(function() {
    'use strict';

    angular
        .module('app')
        .directive('flashcard', flashcardDirective);

    flashcardDirective.$inject = ['componentBaseUrl'];
    
    function flashcardDirective(componentBaseUrl) {
        var directive = {
            templateUrl: format('{0}/flashcard/directories/flashcardView.html', componentBaseUrl),
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