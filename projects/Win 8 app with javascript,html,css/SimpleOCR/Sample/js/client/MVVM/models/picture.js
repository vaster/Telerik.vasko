/// <reference path="//Microsoft.WinJS.1.0/js/base.js" />
(function () {
    // DTO
    var pictureFile = {
        name: "No Picture",
        imageUrl: "#",
        width: "",
        height: "",
        fileExtension: "",
    }

    WinJS.Namespace.define("OCR.Models", {
        pictureFile: pictureFile,
    });
})()