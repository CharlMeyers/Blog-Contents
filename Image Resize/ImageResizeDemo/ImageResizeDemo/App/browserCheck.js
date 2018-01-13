$(document).ready(function () {    
    var BrowserClientInfo = {};
    BrowserClientInfo["UserAgentString"] = navigator.userAgent;
    BrowserClientInfo["DisplayResolutionHeight"] = window.innerHeight;
    BrowserClientInfo["DisplayResolutionWidth"] = window.innerWidth;    

    $.post("api/BrowserClientInfo/SetBrowserClientInfo", BrowserClientInfo, function () {
        window.location.replace("/Home")
    });
});