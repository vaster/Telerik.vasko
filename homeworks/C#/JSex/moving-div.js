var module = (function () {
	function addMovment(type) {
		var wrapper = document.getElementById("wrapper");
		var div = document.createElement("div");
		div.className = "custom";

		wrapper.appendChild(div);
	}

	return {
		addMovment:addMovment,
	}

})();