/// <reference path="client/commands/initUIElements.js" />
/// <reference path="client/commands/initUIElements.js" />
/// <reference path="commands/initEvents.js" />
/// <reference path="Api/ocrService.js" />
// For an introduction to the Blank template, see the following documentation:
// http://go.microsoft.com/fwlink/?LinkId=232509
(function () {
    "use strict";

    WinJS.Binding.optimizeBindingReferences = true;

    var app = WinJS.Application;
    var activation = Windows.ApplicationModel.Activation;

    app.onactivated = function (args) {
        if (args.detail.kind === activation.ActivationKind.launch) {
            WinJS.Application.onsettings = function (e) {
                e.detail.applicationcommands = { "help": { title: "Privacy policy", href: "/privacy/privacy.html" } };
                WinJS.UI.SettingsFlyout.populateSettings(e);
            }
            if (args.detail.previousExecutionState !== activation.ApplicationExecutionState.terminated) {
                // Add privacy policy to settings charm
              

            } else {
                OCR.Commands.Sessionhandler.restoreUserProducedData();
                OCR.Commands.Sessionhandler.restoreUserProducedContent();
            }
            // afther dom tree is loaded
            args.setPromise(WinJS.UI.processAll().then(function () {
                OCR.Commands.initInstructionsBtn();
                OCR.Commands.initAddBtnEvent();
                OCR.Commands.initProccedBtn();
                //OCR.Commands.initCamera();
                OCR.Commands.initSaveFile();
                OCR.Commands.hindeProgressRing();
                OCR.Commands.initSettingsBtn();
                OCR.Commands.initAutoSaveModeStateChange();
                OCR.Commands.Sessionhandler.restoreSettings();
                // create folder for storing output files wich is used form 'auto save mode' when is enabled
                Windows.Storage.KnownFolders.picturesLibrary.createFolderAsync("SimpleOCR");
            }))

        }
    };

    app.oncheckpoint = function (args) {
    };

    app.start();
})();
