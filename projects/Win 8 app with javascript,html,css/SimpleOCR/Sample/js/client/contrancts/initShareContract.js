/// <reference path="../buisness layer/initEvents.js" />
/// <reference path="../../view-model/text-view-model.js" />
// <reference path="//Microsoft.WinJS.1.0/js/base.js" />
//(function () {
//    "use strict";
//
//    var dataTransferManager =
//      Windows.ApplicationModel.DataTransfer.DataTransferManager.getForCurrentView();
//    var shareTextHanlder = function (event) {
//        var dataRequest = event.request;
//
//        var result = null;
//
//        dataRequest.data.properties.title = "sample";
//        dataRequest.data.properties.description = "sample";
//        dataRequest.data.setText("sample");
//        dataRequest.data.properties.applicationName = "My Application";
//    }
//    dataTransferManager.addEventListener("datarequested", shareTextHanlder);
//})()