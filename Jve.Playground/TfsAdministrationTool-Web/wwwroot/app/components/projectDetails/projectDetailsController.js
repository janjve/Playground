(function () {
    'use strict';

    angular
        .module('app')
        .controller('projectDetailsController', projectDetailsController);

    projectDetailsController.$inject = ['$location', 'projectDetailsPrepService', 'userRoles'];

    function projectDetailsController($location, projectDetailsPrepService, userRoles) {
        /* jshint validthis:true */
        var vm = this;

        vm.userRoles = userRoles;

        vm.userRole = projectDetailsPrepService.userRole;
        vm.projectId = projectDetailsPrepService.projectId;
        vm.projectName = projectDetailsPrepService.projectName;
        vm.users = projectDetailsPrepService.users;
        vm.roles = projectDetailsPrepService.roles;

        activate();

        function activate() { }


    }
})();
