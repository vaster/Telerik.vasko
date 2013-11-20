/// <reference path="//Microsoft.WinJS.1.0/js/base.js" />
(function () {
    "use strict";

    var showProgressRing = function () {
        var progressRing = document.getElementById("progress-ring-holder");
        progressRing.style.visibility = "";
    }

    var hindeProgressRing = function () {
        var progressRing = document.getElementById("progress-ring-holder");
        progressRing.style.visibility = "hidden";
    }

    WinJS.Namespace.define("OCR.Commands", {
        showProgressRing: showProgressRing,
        hindeProgressRing: hindeProgressRing,
    });
})();