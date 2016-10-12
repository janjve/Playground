(function () {
    'use strict';
    // NOT YET IMPLEMENTED

    angular.module('app')
        .directive("tfsProjectDetailsAdmin", tfsProjectDetailsAdmin);

    tfsProjectDetailsAdmin.$inject = ['componentBaseUrl'];

    function tfsProjectDetailsAdmin(componentBaseUrl) {
        var directive = {
            templateUrl: format('{0}/projectDetails/templates/tfsProjectDetailsAdmin.html', componentBaseUrl),
            restrict: 'EA',
            scope: {
                roles: '=',
                users: '='
            },
            controller: tfsProjectDetailsAdminController,
            controllerAs: 'vm',
            bindToController: true
        };

        return directive;
    }

    tfsProjectDetailsAdminController.$inject = [];

    function tfsProjectDetailsAdminController() {
        var vm = this;

        vm.onAccessChange = [];


        activate();

        ///////////////////

        function activate() {
        }
    }


})();