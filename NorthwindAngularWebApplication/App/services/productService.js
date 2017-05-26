/*
    Used for retreiving product data in JSON data
*/

app.service('productService', function ($http) {
    //get all employees
    this.getProductCount = function () {
        return $http({
            method: "GET",
            url: "http://localhost:1024/Product/SelectProductCount",
            headers: { 'Content-Type': 'application/json' }
        }).success(function (data) {

        }).error(function (data) {
    
        });
    };

    this.searchProductById = function (productID) {
        return $http({
            method: "GET",
            url: "http://localhost:1024/Product/SelectProductByID/" + productID,
            headers: { 'Content-Type': 'application/json' }
        }).success(function (data) {
            //alert(JSON.stringify(data));
        }).error(function (data) {

        });
    };



  
});