$(document).ready(function () {
    $("#height").text(window.innerHeight);
    $("#width").text(window.innerWidth);

    $.get("api/browserClientInfo/test", function (data) {
        $("#test").text(data);
    });
});