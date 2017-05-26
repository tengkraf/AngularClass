'use strict'

app.controller('homeController', function (productService) {
    var vm = this;
    vm.welcome = "Welcome to Northwind Traders";

    
    var promiseGet = productService.getProductCount();
    //var promiseGet = employeeService.getEmployeesFromFile();
    //load from object to application scope
    promiseGet.then(function (p1) {
        vm.productCount = p1.data;
    }, function (errorp1) {
        alert("Failure retreiving product count.", errorp1)
    });




});