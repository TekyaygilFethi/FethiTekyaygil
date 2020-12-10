




module.exports = function (grunt) {
    grunt.initConfig({
        //clean: ["wwwroot/lib/*", "temp/"],
        jshint: {
            files: ['wwwroot/lib/**/*.js'],
            options: {
                '-W069': false,
            }
        },
        concat: {
            js: {
                src: ['wwwroot/lib/**/*.js','wwwroot/lib/**/*.min.js'],
                dest: 'wwwroot/release/js/combined.min.js'
            },
            css: {
                src: ['wwwroot/lib/**/*.css', 'wwwroot/lib/**/*.min.css'],
                dest: 'wwwroot/release/css/combined.min.css'
            }
        },
        terser: {
            js: {
                src: ['wwwroot/release/js/combined.min.js'],
                dest: 'wwwroot/release/js/combined-uglified.min.js'
            }
        },
        uglify: {
            js: {
                src: ['wwwroot/release/js/combined.min.js'],
                dest: 'wwwroot/release/js/combined-uglified.min.js'
            }
        },
        cssmin: {
            options: {
                mergeIntoShorthands: false,
                roundingPrecision: -1
            },
            target: {
                files: {
                    'wwwroot/release/css/output.css': ['wwwroot/lib/**/*.css', 'wwwroot/lib/**/*.min.css']
                }
            }
        }
    });

    grunt.loadNpmTasks('grunt-contrib-cssmin');
    grunt.loadNpmTasks('grunt-contrib-jshint');
    grunt.loadNpmTasks('grunt-contrib-concat');
    grunt.loadNpmTasks('grunt-contrib-uglify-es');
    //grunt.loadNpmTasks('grunt-contrib-uglify-es');
    grunt.loadNpmTasks('grunt-terser');
    //grunt.loadNpmTasks('terser-webpack-plugin');
    
};