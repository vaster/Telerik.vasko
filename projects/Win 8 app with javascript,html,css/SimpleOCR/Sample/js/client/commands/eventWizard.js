/// <reference path="../sessionStorage/sessionHanlderWizard.js" />
/// <reference path="../connections/internetAccessManager.js" />
/// <reference path="initUIElements.js" />
/// <reference path="../ui-vm-bridge/ui-vm-bridge.js" />
/// <reference path="../../libs/jspdf.min.js" />
/// <reference path="../MVVM/viewModels/default.js" />
/// <reference path="../ui-vm-bridge/ui-vm-bridge.js" />
/// <reference path="../../notifications/notification.js" />
/// <reference path="../buisness-viewModel-bridge/buisnessLayer-viewModel-bridge.js" />
/// <reference path="initFilePicker.js" />
/// <reference path="../ui-vm-bridge/ui-vm-bridge.js" />
/// <reference path="../Api/ocrService.js" />
/// <reference path="//Microsoft.WinJS.1.0/js/base.js" />

(function () {
    "use strict";

   // var toExecuteAreaTextTextReplacement = true;
   //
   // var initAutoSpellCheckWorkAround = function (text) {
   //     var area = document.getElementById("proccess-output");
   //
   //     area.addEventListener('input', function (event) {
   //         if (toExecuteAreaTextTextReplacement) {
   //
   //             toExecuteAreaTextTextReplacement = false;
   //             area.innerHTML = window.toStaticHTML(text);
   //         }
   //     });
   //
   //     area.focus();
   //     area.fireEvent("onkeydown");
   //     area.fireEvent("onkeyup");
   //     area.innerHTML = area.innerHTML;
   // }

    var initAddBtnEvent = function () {

        var addPicBtn = WinJS.Utilities.id("add-local-file").get(0);
        addPicBtn.addEventListener("click", function () {

            var picker = OCR.Commands.getFilePicker;
            picker.pickSingleFileAsync().then(function (file) {
                if (file) {
                    Brigde.UIVM.setPickedFile(file);
                }
            })
        });
    }

    var initInstructionsBtn = function () {
        var instructionsBtn = document.getElementById("instructions-btn");
        instructionsBtn.addEventListener("click", function () {

            var instructionFlyout = document.getElementById("instructions-flyout").winControl;
            var anchor = document.getElementById("header-holder");
          
            instructionFlyout.show(anchor, "auto", "center");
        })
    }

    var initSaveFile = function () {
        var saveBtn = document.getElementById("save-output");
        saveBtn.addEventListener("click", function () {
            if (Brigde.UIVM.outPutText[0]) {
                var savePicker = OCR.Commands.getSavePicker;
                savePicker.pickSaveFileAsync().then(function (file) {
                    if (file) {
                        var content = "";
                        if (file.fileType === ".pdf") {
                            var doc = new jsPDF();
                            doc.text(Brigde.UIVM.outPutText[0].content, 0, 15);
                            var out = doc.output();
                            content = out;
                        }
                        else {
                            content = Brigde.UIVM.outPutText[0].content;
                        }
                        Windows.Storage.FileIO.writeTextAsync(file, content).then(function (success) {
                            OCR.Notifications.activateFileSavedNotification();
                        });
                    }
                })
            }
            else {
                var exc = new Error("No content to write. Please choose picture and then press the proccess button .");
                throw exc;
            }
        });
    }

var initProccedBtn = function () {

    var proccedBtn = WinJS.Utilities.id("proccess").get(0);
    proccedBtn.addEventListener("click", function () {

        if (!(OCR.Internet.isConnected())) {
            var exc = new Error("It appears you don't have internet access. You need access to an internet connection to be able to proceed the process.");
            throw exc;
        }

        if (!Brigde.UIVM.pickedFile[0]) {
            var exc = new Error("Pick picture from the camera or the file system before proceed further.");
            throw exc;
        }
        else {
            OCR.Commands.showProgressRing();
            Brigde.UIVM.proccessPictureFile();
        }
    });

}

var initSettingsBtn = function () {
    var settingsBtn = document.getElementById("settings");
    settingsBtn.addEventListener("click", function () {
        var settingsFlayout = document.getElementById("settings-flyout").winControl;

        settingsFlayout.show(settingsBtn, "auto", "center");
    });
}

var initAutoSaveModeStateChange = function () {
    var autoSaveModeSwitch = document.getElementById("auto-save-mode-switch");
    autoSaveModeSwitch.addEventListener("change", function (e) {
        if (autoSaveModeSwitch.winControl.checked) {
            OCR.Commands.Sessionhandler.storeSettings("on", "");
        }
        else {
            OCR.Commands.Sessionhandler.storeSettings("off", "");
        }
    });

    var fileTypeExtensionGroup = document.getElementsByName("extensionType");
    for (var currRadioIndex = 0; currRadioIndex < fileTypeExtensionGroup.length; currRadioIndex++) {
        fileTypeExtensionGroup[currRadioIndex].addEventListener("click", function (e) {
            OCR.Commands.Sessionhandler.storeSettings("", e.target.value);
        });
    }
}

var initCamera = function () {
    var camerBtn = document.getElementById("take-picture-from-camera");
    camerBtn.addEventListener("click", function () {
        var dialog = new Windows.Media.Capture.CameraCaptureUI();
        var aspectRatio = { width: 1, height: 1 };
        dialog.photoSettings.croppedAspectRatio = aspectRatio;
        dialog.captureFileAsync(Windows.Media.Capture.CameraCaptureUIMode.photo).then(function (file) {
            if (file) {
                Brigde.UIVM.setPickedFile(file);
            }
        });
    });
}

WinJS.Namespace.define("OCR.Commands", {
    initProccedBtn: initProccedBtn,
    initAddBtnEvent: initAddBtnEvent,
    initCamera: initCamera,
    initSaveFile: initSaveFile,
    //initAutoSpellCheckWorkAround: initAutoSpellCheckWorkAround,
    initSettingsBtn: initSettingsBtn,
    initAutoSaveModeStateChange: initAutoSaveModeStateChange,
    initInstructionsBtn: initInstructionsBtn,
});
})()