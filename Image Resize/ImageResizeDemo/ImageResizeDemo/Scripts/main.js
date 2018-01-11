$(document).ready(function () {
    var BrowserClientInfoId = null;
    var BrowserClientInfo = {};
    BrowserClientInfo["UserAgentString"] = navigator.userAgent;
    BrowserClientInfo["DisplayResolutionHeight"] = window.innerHeight;
    BrowserClientInfo["DisplayResolutionWidth"] = window.innerWidth;

    $("#height").text(window.innerHeight);
    $("#width").text(window.innerWidth);

    $.post("api/BrowserClientInfo/SetBrowserClientInfo", BrowserClientInfo, function (data) {
        BrowserClientInfoId = data;
    }).always(function () {
        if (BrowserClientInfoId !== null || BrowserClientInfoId !== undefined);
        $.get("api/BrowserClientInfo/GetUserAgentString", { clientBrowserInfoId: BrowserClientInfoId }, function (data) {
            $("#test").text(data);
        });
    });
});