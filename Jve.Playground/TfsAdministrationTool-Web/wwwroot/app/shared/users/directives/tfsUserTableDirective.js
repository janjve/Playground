(function () {
    'use strict';

    angular.module('app')
        .directive("tfsUserTable", userTable);

    userTable.$inject = [];

    function userTable() {
        var directive = {
            templateUrl: '/App/Shared/Templates/userTable.html',
            restrict: 'EA',
            scope: {
                users: '=',
                roles: '=',
                onAccessChange: '&'
            },
            controllerAs:'vm'
        };

        return directive;
    }
})();