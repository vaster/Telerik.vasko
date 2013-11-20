(function () {
    "use strict";

    var networkInfo = Windows.Networking.Connectivity.NetworkInformation;
    var networkConnectivityInfo = Windows.Networking.Connectivity.NetworkConnectivityLevel;

    function isConnected() {
        var connectionProfile = networkInfo.getInternetConnectionProfile();

        if (connectionProfile == null) {
            return false;
        }

        var networkConnectivityLevel = connectionProfile.getNetworkConnectivityLevel();

        if (networkConnectivityLevel == networkConnectivityInfo.none
                    || networkConnectivityLevel == networkConnectivityInfo.localAccess
                    || networkConnectivityLevel == networkConnectivityInfo.constrainedInternetAccess) {

            return false;
        }

        return true;
    }

    WinJS.Namespace.define("OCR.Internet", {
        isConnected: isConnected,
    });
})();
