$(document).ready(function () {
    getEmployeesTable();
});




function getEmployeesTable() {

    var route = "/Employee/GetEmployeesTable";

    $.ajax({
        url: route,
        type: "GET"
    }).success(function (table) {

        $("#divEmployeesTableContainer").html(table);

    }).fail(function (error) {
        alert(JSON.stringify(error));
    });

}