'use strict'
/*
    Angular 1 controllers should have no knowledge of where data comes from
*/



app.controller('searchProductController', function ( productService) {
    var vm = this;
    vm.message = "Search for a Product";

    vm.search = function () {
        //call service and get the data back
        var promiseGet = productService.searchProductById(vm.product.productID);
        //var promiseGet = employeeService.getEmployeesFromFile();
        //load from object to application scope
        promiseGet.then(function (p1) {
            vm.product = p1.data;
        }, function (errorp1) {
            alert("Failure loading product", errorp1)
        });
    };

    
});