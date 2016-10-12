/// <binding BeforeBuild='bower_setup' />
/*
This file in the main entry point for defining grunt tasks and using grunt plugins.
Click here to learn more. http://go.microsoft.com/fwlink/?LinkID=513275&clcid=0x409
*/
module.exports = function (grunt) {
    grunt.initConfig({
        clean: ["wwwroot/lib/*", "temp/"],
        bower_concat: {
            all: {
                dest: 'temp/_bower.js',
                cssDest: 'temp/_bower.css'
            }
        },
        uglify: {
            all: {
                src: ['temp/_bower.js'],
                dest: 'wwwroot/lib/_bower.min.js'
            },
            options: { separator: ';' }
        },
        cssmin: {
            target: {
                files: [{
                    expand: true,
                    cwd: 'temp',
                    src: ['*.css'],
                    dest: 'wwwroot/lib',
                    ext: '.min.css'
                }]
            }
        },
        watch: {
            files: ["wwwroot/app/**/*.js"],
            tasks: ["bower_setup"]
        }
    });
    require('load-grunt-tasks')(grunt);

    grunt.registerTask("bower_setup", ['clean', 'bower_concat']);
};
