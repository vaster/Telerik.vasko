/// <reference path="//Microsoft.WinJS.1.0/js/base.js" />
(function () {
    // DTO
    var pictureFile = {
        name: "",
        imageUrl:"#",
        width: "",
        height: "",
    }
    var ObsPictureFile = WinJS.Binding.define(pictureFile);
    var getPictureFile = function (name, width, height, imageUrl) {
        return new ObsPictureFile({
            name: name,
            imageUrl: imageUrl,
            width: width,
            height: height,
        });
    }
    var pictureFileList = new WinJS.Binding.List();

    WinJS.Namespace.define("OCR.ViewModels", {
        pictureFileList: pictureFileList,
        getPictureFil: getPictureFile,
    });

})()