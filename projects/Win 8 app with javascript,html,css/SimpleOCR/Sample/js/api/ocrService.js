/// <reference path="../commands/initFilePicker.js" />
/// <reference path="../commands/initEvents.js" />
/// <reference path="../view-model/text-view-model.js" />
/// <reference path="../commands/Session Storage Layer/intSessionHanlder.js" />
/// <reference path="../view-model/text-view-model.js" />
/// <reference path="../notifications/notification.js" />
/// <reference path="//Microsoft.WinJS.1.0/js/base.js" />
(function () {
    var proccessPicture = function (picFile) {
        //var lang = OCR.Commands.getLanguage[0];
        //var extType = OCR.Commands.getDocumentExtension[0];
        var imgBlob = [];
        picFile.openAsync(Windows.Storage.FileAccessMode.read).then(function (stream) {
            if (imgBlob.length != 0) {
                imgBlob.splice(0, 1);
            }
            imgBlob.push(MSApp.createBlobFromRandomAccessStream("image/bmp", stream));
        })

        return WinJS.xhr({
            type: "POST",
            url: "http://ocr-google.apphb.com/api/Ocr?lang=" + "eng" + "&typeExt=" + ".txt",
            data: imgBlob[0],
        });
    }
    WinJS.Namespace.define("OCR.Xhr", {
        proccessPicture: proccessPicture,
    });
})()