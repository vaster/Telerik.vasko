(function () {
    "use strict";

    WinJS.Application.onerror = function (customEventObject) {
        var errorMessage = customEventObject.detail.errorMessage;

        var errorFlyout = document.getElementById("error-flyout").winControl;
        var anchor = document.getElementById("view-pic-frame");
        var errorHolder = document.getElementById("error-holder");
        errorHolder.innerHTML = errorMessage;

        errorFlyout.show(anchor, "right", "center");

        return true;
    }
})()