$(function () {
    var ps = $("p");

    var strongPs = ps.filter(function () {
        return $(this).children("strong").length > 0;
    }).css("background", "red");

    // strongPs.css("background", "red");
})