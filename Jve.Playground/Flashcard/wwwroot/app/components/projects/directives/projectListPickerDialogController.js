(function () {
    'use strict';


    angular
        .module('app')
        .controller('projectListPickerDialogController', projectListPickerDialogController);

    projectListPickerDialogController.$inject = ['$mdDialog', 'projects'];

    function projectListPickerDialogController($mdDialog, projects) {
        var vm = this;

        vm.projects = projects;
        vm.pickProject = pickProject;

        function pickProject(project) {
            $mdDialog.hide(project);
        }
    }
})();