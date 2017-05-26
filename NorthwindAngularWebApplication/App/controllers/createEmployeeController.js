'use strict'

app.controller('createEmployeeController', function ( employeeService) {
    //call service and get the data back
    var vm = this;
    vm.save = function () {

        var employee = {
            LastName: vm.employee.LastName,
            FirstName: vm.employee.FirstName,
            Title: vm.employee.Title,
            HomePhone: vm.employee.HomePhone,
            HireDate: vm.employee.HireDate


        };

        employeeService.createEmployee(employee).success(function (data, status, headers) {
            // do magic stuff with the result
            // (which is in the data param)
            if (data == 1) {
                alert('New Employee Added: ' + employee.FirstName + " " + employee.LastName);
                app.$location.path("/employee");
            }
            else {
                alert("Error has occured while adding the employee" + JSON.stringify(data));
            }
        })
            

    }

    vm.resetForm = function () {
        vm.employeeForm.$setPristine();
        vm.employee = {};

    };

    vm.message = "Create Employee Page";
});