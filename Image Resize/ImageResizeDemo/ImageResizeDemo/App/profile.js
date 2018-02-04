$(document).ready(function () {
    $("img.dynamicSize").each(function () {
        var self = this;
        var imageHeight = $(self).css("height").replace("px", "");
        var imageWidth = $(self).css("width").replace("px", "");

        $.get("api/image/GetProfilePictureBase64/",
            { id: '20e49fb4-597d-4db0-b45a-781875ea35d9', height: imageHeight, width: imageWidth },
            function (data) {
                $(self).attr("src", "data:image/jpg;base64," + data);
        })
    });
});