/*
    Used for retreiving employee data in JSON data
*/

app.service('employeeService', function ($http) {
    //get all employees
    this.getAllEmployees = function () {
        return $http({
            method: "GET",
            url: "http://localhost:1024/Employee/SelectAllEmployees",
            headers: { 'Content-Type': 'application/json' }
        }).success(function (data) {
        }).error(function (data) {
        });
    };

    //create employee
    this.createEmployee = function (employee) {
        return $http({
            method: "POST",
            url: "http://localhost:1024/Employee/InsertEmployee",
            data: employee,
        }).success(function (data) {

        }).error(function (data) {
          
        });
    };


    this.getEmployeesFromFile = function () {
        return $http({
            method: "GET",
            url: "../json/employees.json",

        }).success(function (data) {

        });
    };
});