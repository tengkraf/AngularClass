/*
This is the main application file in an Angular1 SPA application.


*/

var app = angular.module('myApp', ['ngRoute', 'ngMessages'])

    .config(['$routeProvider', function ($routeProvider) {
        $routeProvider
            .when('/', {
                templateUrl: 'views/home.html',
                controller: 'homeController',
                controllerAs: 'vm'
            })
            .when('/contact', {
                templateUrl: 'views/contact.html',
                controller: 'contactController',
                controllerAs: 'vm'
            })
            .when('/about', {
                templateUrl: 'views/about.html',
                controller: 'aboutController',
                controllerAs: 'vm'
            })
            .when('/employees', {
                templateUrl: 'views/employees.html',
                controller: 'employeesController',
                controllerAs: 'vm'
            })
            .when('/product', {
                templateUrl: 'views/searchProduct.html',
                controller: 'searchProductController',
                controllerAs: 'vm'
            })
            .when('/createEmployee', {
                templateUrl: 'views/createEmployee.html',
                controller: 'createEmployeeController',
                controllerAs: 'vm'
            })
    }])

    .controller('mainController', function () {
        var vm = this;
        vm.message = "MessageTest"

    });



	/*
		created by todd 
	*/