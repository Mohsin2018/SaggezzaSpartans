// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$(document).ready(function () {

    $("#My_Table").DataTable(
        {
            //"ajax": {
            //    "url": "/Employee/GetList",
            //    "type": "GET",
            //    "datatype": "json"
            //},
            "columns": [
                { "data": "Name" },
                { "data": "Designation" },
                { "data": "Age" },
            ]

        });

});