$(document).ready(function () {    
    var BrowserClientInfo = {};
    BrowserClientInfo["DisplayResolutionHeight"] = window.innerHeight;
    BrowserClientInfo["DisplayResolutionWidth"] = window.innerWidth;    

    $.post("api/BrowserClientInfo/SetBrowserClientInfo", BrowserClientInfo, function () {
        window.location.replace("/Home")
    });
});