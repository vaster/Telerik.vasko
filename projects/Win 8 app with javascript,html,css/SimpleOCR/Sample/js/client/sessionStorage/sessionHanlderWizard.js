/// <reference path="//Microsoft.WinJS.1.0/js/base.js" />
/// <reference path="../buisness layer/initEvents.js" />
/// <reference path="../../view-model/text-view-model.js" />
/// <reference path="../buisness-viewModel-bridge/buisnessLayer-viewModel-bridge.js" />
(function () {
    "use strict";

    var storeUserProducedData = function (file) {
        if (file) {
            var token = Windows.Storage.AccessCache.StorageApplicationPermissions.futureAccessList.add(file, "currPicFile");
            WinJS.Application.sessionState["fileToken"] = token;
        }

    }

    var storeUserProducedContent = function (outputText) {
        WinJS.Application.sessionState["outputText"] = outputText;
    }


    var restoreUserProducedContent = function () {
        if (WinJS.Application.sessionState["outputText"]) {
            var outputText = WinJS.Application.sessionState["outputText"];
            Brigde.UIVM.setOutputText(outputText._backingData);
        }
    }

    var restoreUserProducedData = function () {
        if (WinJS.Application.sessionState["fileToken"]) {
            Windows.Storage.AccessCache.StorageApplicationPermissions.futureAccessList.getFileAsync(WinJS.Application.sessionState["fileToken"])
            .then(function (file) {
                Brigde.UIVM.setPickedFile(file);
            });

        }
    }

    var storeSettings = function (mode, extension) {
        var applicationData = Windows.Storage.ApplicationData.current;
        var localSettings = applicationData.localSettings;

        if (mode != "") {
            localSettings.values["autoSaveMode"] = mode;
        }
        if (extension != "") {
            localSettings.values["extensionType"] = extension;
        }
    }

    var restoreSettings = function () {
        var applicationData = Windows.Storage.ApplicationData.current;
        var localSettings = applicationData.localSettings;

        var mode = localSettings.values["autoSaveMode"];
        var autoSaveModeSwitch = document.getElementById("auto-save-mode-switch").winControl;
        if (mode === "on") {
            autoSaveModeSwitch.checked = true;
        }
        if (mode === "off") {
            autoSaveModeSwitch.checked = false;
        }

        var extType = localSettings.values["extensionType"];
        var fileTypeExtensionGroup = document.getElementsByName("extensionType");
        for (var currRadio = 0; currRadio < fileTypeExtensionGroup.length; currRadio++) {
            if (fileTypeExtensionGroup[currRadio].value === extType) {
                fileTypeExtensionGroup[currRadio].checked = true;
            }
        }
    }

    var stroreFileNameIndicator = function () {
        var applicationData = Windows.Storage.ApplicationData.current;
        var localSettings = applicationData.localSettings;

        var indicator = localSettings.values["nameIndicator"];
        if (!indicator) {
            indicator = 0;
        }
        indicator++;
        localSettings.values["nameIndicator"] = indicator;
    }

    var restoreFileNameIndicator = function () {
        var applicationData = Windows.Storage.ApplicationData.current;
        var localSettings = applicationData.localSettings;

        if (localSettings.values["nameIndicator"]) {
            return localSettings.values["nameIndicator"];
        }
        else {
            return 0;
        }
    }

    WinJS.Namespace.define("OCR.Commands.Sessionhandler", {
        storeUserProducedData: storeUserProducedData,
        restoreUserProducedData: restoreUserProducedData,
        storeUserProducedContent: storeUserProducedContent,
        restoreUserProducedContent: restoreUserProducedContent,
        storeSettings: storeSettings,
        restoreSettings: restoreSettings,
        stroreFileNameIndicator: stroreFileNameIndicator,
        restoreFileNameIndicator: restoreFileNameIndicator,
    });
})()