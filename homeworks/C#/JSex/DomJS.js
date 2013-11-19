var domManipulator = (function () {

	function appendChild(element, selector) {
		var el = document.createElement(element);
		var parent = document.querySelector(selector);

		el.className = "custom";
		parent.appendChild(el);
	}

	function removeElement(parent, selector) {
		var parentEl = document.getElementsByTagName(parent)[0];
		var elForDel = document.querySelector(selector);

		parentEl.removeChild(elForDel);
	}

	function addEvent(selector, event, eventHandler) {
		var element = document.querySelector(selector);
		element.addEventListener(event,eventHandler);
	}

	return {
		appendChild: appendChild,
		removeElement: removeElement,
		addEvent:addEvent,
	};
})();


