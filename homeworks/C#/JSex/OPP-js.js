function Viechle(speed, propUnit) {
	this.speed = speed;
	this.propUnit = propUnit;

	this.Accelerate = function () {
		return speed + propUnit;
	}
}


function PropUnit() {
	this.produceAceleration = function () {
		//
	}
}


Wheels.prototype = new PropUnit();
Wheels.prototype.constructor = Wheels;

function Wheels(radius) {
	this.produceAceleration = function () {
		return 2 * Math.PI * radius;
	}
}


PropelingNozzle.prototype = new PropUnit();
PropelingNozzle.prototype.constructor = PropelingNozzle;

function PropelingNozzle(power, afterBurnerSwitch) {
	this.produceAceleration = function () {
		if (afterBurnerSwitch) {
			return 2 * power;
		}
		return power;
	}
}

Propeller.prototype = new PropUnit();
Propeller.prototype.constructor = Propeller;

function Propeller() {
	this.produceAceleration = function (fins, spinDir) {
		if (spinDir >= 0) {
			return fins;
		}

		return fins*(-1);

	}
}

LandViechle.prototype = new Viechle();
LandViechle.prototype.constructor = LandViechle;

function LandViechle(speed, propUnit) {
	this.speed = speed;
	this.propUnit = propUnit;
	this.Accelerate = function () {
		return this.propUnit.produceAceleration();
	}
}

