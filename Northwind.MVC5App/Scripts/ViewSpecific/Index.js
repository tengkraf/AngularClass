
$(document).ready(function () {
    loadProductCount();
});



function loadProductCount() {
    var route = "/NorthwindService/GetProductCount";
    //loadDefaultOption();
    $.ajax({

        url: route,
        type: "GET"

    }).success(function (productCount) {

        $("#spanProductCount").html(productCount);


    }).fail(function (error) {
        //fail
        alert(JSON.stringify(error));

    });

}