

$(document).ready(function () {
    loadCategoriesIntoSelectList();
})


$("#selectCategories").change(function () {
    
    //extract the CategoryID of the selected Category
    var categoryID = $(this).val();
    loadProductsIntoSelectList(categoryID);
});


$("#selectProducts").change(function () {

    var productID = $(this).val();
    if (productID == 0) {
       
        alert("Pick a valid Product");
        $('#ulProductData').empty();
    }
    else {
        $('#ulProductData').empty();
        loadProductIntoUL(productID);
    }

   
});




function loadProductIntoUL(productID) {

    //ajax call and display the product data in the unorderedlist
    //make ajax call
    var route = "/NorthwindService/GetProductByID/" + productID;
    //loadDefaultOption();
    $.ajax({

        url: route,
        type: "GET"

    }).success(function (product) {
          $("#pDetails").html("Viewing details for " + product.ProductName)
            //append categories to the select list
        $("#ulProductData").append("<li>" + "ProductID: " + product.ProductID + "</li>" +
                                   "<li>" + "ProductName: " + product.ProductName + "</li>" +
                                   "<li>" + "UnitPrice: " + product.FormattedPrice + "</li>" +
                                   "<li>" + "Discontinued: " + product.Discontinued + "</li>");

        
    }).fail(function (error) {
        //fail
        alert(JSON.stringify(error));

    });

}


function loadCategoriesIntoSelectList() {

    //ajax call here
    var route = "/NorthwindService/GetAllCategories";

    $.ajax({

        url: route,
        type: "GET"

    }).success(function (categories) {
        $.each(categories, function (i, category) {

            //append categories to the select list
            $('#selectCategories').append($("<option></option>")
                                  .attr("value", category.CategoryID)
                                  .text(category.CategoryName));

        });
    }).fail(function (error) {
        //fail
        alert(JSON.stringify(error));

    });
}


function loadProductsIntoSelectList(categoryID) {

    //make ajax call
    var route = "/NorthwindService/GetProductsByCategoryID/" + categoryID;
    //loadDefaultOption();
    $.ajax({

        url: route,
        type: "GET"

    }).success(function (products) {

        

        $.each(products, function (i, product) {

            //append categories to the select list
            $('#selectProducts').append($("<option></option>")
                                  .attr("value", product.ProductID)
                                  .text(product.ProductName));

        });
    }).fail(function (error) {
        //fail
        alert(JSON.stringify(error));

    });
    
}


function loadDefaultOption() {
    $('#selectProducts').children().remove().end().append('<option selected value="0">Choose a Product</option>');
}