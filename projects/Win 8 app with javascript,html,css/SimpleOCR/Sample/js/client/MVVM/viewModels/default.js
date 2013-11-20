/// <reference path="//Microsoft.WinJS.1.0/js/base.js" />
/// <reference path="../models/outputText.js" />
/// <reference path="../models/picture.js" />
(function () {
    "use strict";

    var bindablePicture = WinJS.Binding.define(OCR.Models.pictureFile);
    var obsPicture = function (name, width, height, imageUrl, fileExtension) {
        return new bindablePicture({
            name: "Name: " + name,
            imageUrl: imageUrl,
            width: width,
            height: height,
            fileExtension: "File Extension:" + fileExtension,
        });
    }

    var bindableTxt = WinJS.Binding.define(OCR.Models.textFile);
    var obsTxt = function (name, content) {
        return new bindableTxt({
            name: name,
            content: content,
        });
    }

    WinJS.Namespace.define("OCR.ViewModels", {
        obsPicture: obsPicture,
        obsTxt: obsTxt,
    });
})();