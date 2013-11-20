/// <reference path="//Microsoft.WinJS.1.0/js/base.js" />
(function () {
    "use strict";

    var filePicker = Windows.Storage.Pickers.FileOpenPicker();

    filePicker.fileTypeFilter.append(".jpg");
    filePicker.fileTypeFilter.append(".jpeg");
    filePicker.fileTypeFilter.append(".bmp");
    filePicker.fileTypeFilter.append(".gif");
    filePicker.fileTypeFilter.append(".png");

    var savePicker = new Windows.Storage.Pickers.FileSavePicker();
    savePicker.defaultFileExtension = ".txt";
    savePicker.fileTypeChoices.insert("Plain Text", [".txt"])
    savePicker.fileTypeChoices.insert("PDF", [".pdf"])
    savePicker.suggestedFileName = "New Document";


    WinJS.Namespace.define("OCR.Commands", {
        getFilePicker: filePicker,
        getSavePicker:savePicker,
    });
})()