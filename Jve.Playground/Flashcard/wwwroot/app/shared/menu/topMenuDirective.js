(function() {
    'use strict';

    angular
        .module('app')
        .directive('topMenu', topMenuDirective);

    topMenuDirective.$inject = ['sharedBaseUrl'];
    
    function topMenuDirective(sharedBaseUrl) {
        // Usage:
        //     <topMenuDirective></topMenuDirective>
        // Creates:
        // 
        var directive = {
            templateUrl: format('{0}/menu/topMenu.html', sharedBaseUrl),
            link: link,
            restrict: 'EA',
            controller: topMenuController,
            controllerAs: 'vm',
            bindToController: true
        };
        return directive;

        function link(scope, element, attrs) {
        }
    }

    topMenuController.$inject = [];

    function topMenuController() {

    }

})();