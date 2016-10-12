(function () {
    'use strict';


    angular.module('app')
        .directive("tfsProjectDetailsLocked", tfsProjectDetailsLocked);

    tfsProjectDetailsLocked.$inject = ['componentBaseUrl'];

    function tfsProjectDetailsLocked(componentBaseUrl) {
        var directive = {
            templateUrl: format('{0}/projectDetails/templates/tfsProjectDetailsLocked.html', componentBaseUrl),
            restrict: 'EA',
            scope: {
                roles: '='
            },
            controller: tfsProjectDetailsLockedController,
            controllerAs: 'vm',
            bindToController: true
        };

        return directive;
    }

    tfsProjectDetailsLockedController.$inject = [];

    function tfsProjectDetailsLockedController() {
        var vm = this;

        vm.onAccessRequest = [];

        activate();

        ///////////////////

        function activate() {
        }
    }


})();