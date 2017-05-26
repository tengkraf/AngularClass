'use strict'
/*
    Angular 1 controllers should have no knowledge of where data comes from
*/



app.controller('employeesController', function (employeeService) {
    var vm = this;
    //call service and get the data back
    var promiseGet = employeeService.getAllEmployees();
    //var promiseGet = employeeService.getEmployeesFromFile();
    //load from object to application scope
    promiseGet.then(function (p1) {
        vm.employees = p1.data;
    }, function (errorp1) {
        alert("Failure loading employees", errorp1)
        });

    vm.message = "Employee Page";
});