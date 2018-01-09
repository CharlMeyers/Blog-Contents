$(document).ready(function () {
    var BrowserClientInfo = {};
    BrowserClientInfo["UserAgentString"] = Navigator.UserAgentString;
    BrowserClientInfo["DisplayResolutionHeight"] = window.innerHeight;
    BrowserClientInfo["DisplayResolutionWidth"] = window.innerWidth;

    $("#height").text(window.innerHeight);
    $("#width").text(window.innerWidth);

    $.post("api/BrowserClientInfo/SetBrowserClientInfo", BrowserClientInfo, function (data) {
        $("#test").text(data);
    });
});