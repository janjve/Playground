(function () {
    'use strict';

    angular.module('app')
        .constant('userRoles', {
            ADMIN: 'Admin',
            USER: 'User',
            UNKNOWN: 'Unknown'
        })
        .constant('componentBaseUrl', 'wwwroot/app/components')
        .constant('sharedBaseUrl', 'wwwroot/app/shared')
        .constant('apiBaseUrl', 'API_BASE_URL')
    ;
})();