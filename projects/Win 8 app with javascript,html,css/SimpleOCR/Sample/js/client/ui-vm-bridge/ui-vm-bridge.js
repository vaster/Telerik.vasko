/// <reference path="../../default.js" />
/// <reference path="../../api/ocrService.js" />
/// <reference path="../MVVM/viewModels/default.js" />
(function () {
    "use strict";

    var pickedFile = [];
    var outPutText = [];
    var toExecute = true;

    var setPickedFile = function (file) {
        if (pickedFile.length != 0) {
            pickedFile.splice(0, 1);
        }
        pickedFile.push(file);

        var fileE = MSApp.createFileFromStorageFile(file);
        var url = URL.createObjectURL(fileE, { oneTimeOnly: true });

        var result = OCR.ViewModels.obsPicture(file.displayName, 0, 0, url, file.fileType);
        // data storage
        OCR.Commands.Sessionhandler.storeUserProducedData(file);

        var element = document.getElementById("image-to-proccess-holder");
        WinJS.Binding.processAll(element, result);
    }

    var setOutputText = function (outputText) {
        var element = document.getElementById("proccess-output");
        WinJS.Binding.processAll(element, outputText);
    }

    var saveFileToDocumentLibrary = function (extension, textToWrite) {
        var fileName = Date.now();
        var indicator = OCR.Commands.Sessionhandler.restoreFileNameIndicator();
        if (extension === ".txt") {
            Windows.Storage.KnownFolders.picturesLibrary.getFolderAsync("SimpleOCR").then(function (folder) {
                folder.createFileAsync("sample" + indicator + ".txt",
                 Windows.Storage.CreationCollisionOption.replaceExisting).then(function (file) {
                     Windows.Storage.FileIO.writeTextAsync(file, textToWrite).then(function (success) {
                         OCR.Notifications.activateFileSavedNotification();
                         OCR.Commands.Sessionhandler.stroreFileNameIndicator();
                     });
                 })
            });
        }
        if (extension === ".pdf") {
            var doc = new jsPDF();
            doc.text(textToWrite, 0, 15);
            var out = doc.output();
            Windows.Storage.KnownFolders.picturesLibrary.getFolderAsync("SimpleOCR").then(function (folder) {
                folder.createFileAsync("sample" + indicator + ".pdf",
                 Windows.Storage.CreationCollisionOption.replaceExisting).then(function (file) {
                     Windows.Storage.FileIO.writeTextAsync(file, out).then(function (success) {
                         OCR.Notifications.activateFileSavedNotification();
                         OCR.Commands.Sessionhandler.stroreFileNameIndicator();
                     });
                 })
            });

        }
    }

    var proccessPictureFile = function () {

        OCR.Xhr.proccessPicture(Brigde.UIVM.pickedFile[0]).then(function (textWrapper) {
            var parsed = JSON.parse(textWrapper.responseText);
            var result = OCR.ViewModels.obsTxt("", parsed);

            OCR.Commands.hindeProgressRing();
            setOutputText(result);
            // data storage
            OCR.Commands.Sessionhandler.storeUserProducedContent(result);

            if (outPutText.length != 0) {
                outPutText.splice(0, 1);
            }
            outPutText.push(result);

            //OCR.Commands.initAutoSpellCheckWorkAround(parsed);

            var applicationData = Windows.Storage.ApplicationData.current;
            var localSettings = applicationData.localSettings;

            var mode = localSettings.values["autoSaveMode"];
            if (mode === "on") {
                var extType = localSettings.values["extensionType"];
                saveFileToDocumentLibrary(extType, result.content);
            }
        })
    }

    WinJS.Namespace.define("Brigde.UIVM", {
        setPickedFile: setPickedFile,
        setOutputText: setOutputText,
        pickedFile: pickedFile,
        outPutText: outPutText,
        proccessPictureFile: proccessPictureFile
    })
})();