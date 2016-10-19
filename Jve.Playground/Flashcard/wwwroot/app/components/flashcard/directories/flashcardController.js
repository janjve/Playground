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
                back: '@',
                imageUrl: '@'
            }
        };
        return directive;
    }

    flashcardController.$inject = [];

    function flashcardController() {
        var vm = this;

        vm.flipped = false;
        vm.flip = flip;
        
        ///////////////////////

        function flip() {
            vm.flipped = !vm.flipped;
        }
    }

})();