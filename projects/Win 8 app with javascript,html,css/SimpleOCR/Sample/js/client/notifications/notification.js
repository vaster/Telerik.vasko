/// <reference path="//Microsoft.WinJS.1.0/js/base.js" />
(function () {
    "use strict";

    var notifications = Windows.UI.Notifications;
    
    var template = notifications.TileTemplateType.tileWide310x150ImageAndText01;
    var tile = notifications.TileUpdateManager.getTemplateContent(template);
    
    tile.createTextNode("Hi").innerText = "Powerfull."
    tile.createElement("text").innerText = "I am OCR. Meet me." ;
    var tileNotification = new notifications.TileNotification(tile);
    
    var currentTime = new Date();
    tileNotification.expirationTime = new Date(currentTime.getTime() + 1000 * 1000);
    
 

    var callSaveFileNotification = function () {
        var template = notifications.ToastTemplateType.toastText01;
        var toast = notifications.ToastNotificationManager.getTemplateContent(template);
        toast.createElement("text");
        var text = toast.getElementsByTagName("text");
        text.getAt(0).innerText = "File saved succsesfully.";
        var toast = new notifications.ToastNotification(toast);
        var toastNotifier = notifications.ToastNotificationManager.createToastNotifier();
        toastNotifier.show(toast);
    }

    WinJS.Namespace.define("OCR.Notifications", {
        activateFileSavedNotification:callSaveFileNotification,
    });

})()