/// <binding BeforeBuild='default-build' />
/*
This file in the main entry point for defining grunt tasks and using grunt plugins.
Click here to learn more. http://go.microsoft.com/fwlink/?LinkID=513275&clcid=0x409
*/
module.exports = function (grunt) {

    grunt.loadNpmTasks('grunt-contrib-uglify');
    grunt.loadNpmTasks('grunt-contrib-watch');

    grunt.initConfig({
        uglify: {
            my_target: {
                files: { 'scripts/combined-min.js': ['scripts/app/app.js', 'scripts/controller/*.js'] }
            }
        },

        watch: {
            scripts: {
                files: ['scripts/controller/*.js'],
                tasks: ['uglify']
            }
        }
    });

    //grunt.registerTask('default-build', ['uglify', 'watch']);
};