$(document).ready(function () {
    var imageHeight = $("#profilePic").css("height");
    var imageWidth = $("#profilePic").css("width");

    $.get("api/image/GetProfilePicture/", { id: '20e49fb4-597d-4db0-b45a-781875ea35d9' }, function (data) {
        $("profilePic").attr("src", data);
    })
});