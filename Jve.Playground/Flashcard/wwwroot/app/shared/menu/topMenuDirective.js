(function() {
    'use strict';

    angular
        .module('app')
        .directive('topMenu', topMenuDirective);

    topMenuDirective.$inject = [];
    
    function topMenuDirective () {
        // Usage:
        //     <topMenuDirective></topMenuDirective>
        // Creates:
        // 
        var directive = {
            templateUrl: '/wwwroot/app/shared/menu/topMenu.html',
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