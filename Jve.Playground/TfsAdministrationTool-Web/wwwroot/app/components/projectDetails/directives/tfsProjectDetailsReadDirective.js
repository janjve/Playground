(function () {
    'use strict';
    // NOT YET IMPLEMENTED

    angular.module('app')
        .directive("tfsProjectDetailsRead", tfsProjectDetailsRead);

    tfsProjectDetailsRead.$inject = ['componentBaseUrl'];

    function tfsProjectDetailsRead(componentBaseUrl) {
        var directive = {
            templateUrl: format('{0}/projectDetails/templates/tfsProjectDetailsRead.html', componentBaseUrl),
            restrict: 'EA',
            scope: {
                roles: '=',
                users: '='
            },
            controller: tfsProjectDetailReadController,
            controllerAs: 'vm',
            bindToController: true
        };

        return directive;
    }

    tfsProjectDetailReadController.$inject = [];

    function tfsProjectDetailReadController() {
        var vm = this;

        activate();

        ///////////////////

        function activate() {
        }
    }


})();