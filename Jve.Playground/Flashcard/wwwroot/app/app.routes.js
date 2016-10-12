(function () {
    'use strict';

    angular.module('app')
        .run(appRun);

    appRun.$inject = ['routerHelper'];

    function appRun(routerHelper) {
        routerHelper.configureStates(getStates(), 'projects');
    }

    function getStates() {
        var baseTemplateUrl = 'wwwroot/app/components';
        return [
            {
                state: 'projects',
                config: {
                    url: '/projects',
                    templateUrl: format('{0}/projects/projects.html', baseTemplateUrl),
                    controller: 'projectsController as vm',
                    bindToController: true
                }
            },
            {
                state: 'projectDetails',
                config: {
                    url: '/details/:projectId',
                    templateUrl: format('{0}/projectDetails/projectDetails.html', baseTemplateUrl),
                    controller: 'projectDetailsController as vm',
                    bindToController: true,
                    resolve: {
                        projectDetailsPrepService: ['$stateParams', function ($stateParams) {
                            var userModel = {
                                userRole: 'Unknown', // Lookup
                                projectId: $stateParams.projectId,
                                projectName: "ProjectName", // Lookup
                                users: ['user1', 'user2', 'user3'], // Lookup
                                roles: ['role1', 'role2', 'role3'] // Lookup
                            }
                            return userModel;
                        }]
                    }
                }
            }
        ];
    }
})();