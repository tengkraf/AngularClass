

$(document).ready(function () {
    loadEmployeesIntoTable();
});




function loadEmployeesIntoTable() {


    //make an jquery ajax call to the webapi
    var route = "/NorthwindService/GetAllEmployees";

    $.ajax({
        //control section
        url: route,
        type: "GET"
    }).success(function (employees) {
        //success
        $.each(employees, function (i, employee) {
            //append the data to the table tbody element
            $("#tableEmployees > tbody").append("<tr><td>" + employee.EmployeeID + "</td>" +
                                                  "<td>" + employee.LastName + "</td>" +
                                                  "<td>" + employee.FirstName + "</td>" +
                                                  "<td>" + employee.Title + "</td>" +
                                                  "<td>" + employee.HomePhone + "</td>" +
                                                  "<td>" + employee.ShortHireDate + "</td></tr>");
        });

    }).fail(function (error) {
        //fail
        alert(JSON.stringify(error));
    });
}
