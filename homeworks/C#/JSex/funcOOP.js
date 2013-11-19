var Class = (function () {
	function createClass(properties) {
		var func = function () {
			if (this._superConstructor) {
				this._super = new this._superConstructor(arguments);
			}

			this.init.apply(this, arguments);
		}
		for (var prop in properties) {
			func.prototype[prop] = properties[prop];
		}

		return func;
	}


	Function.prototype.inherit = function (parent) {
		var oldPrototype = this.prototype;
		this.prototype = new parent();
		this.prototype._superConstructor = parent;
		for (var prop in oldPrototype) {
			this.prototype[prop] = oldPrototype[prop];
		}
	}

	return {
		create: createClass,
	};
}());

var school = Class.create({
	init: function (name, town, classes) {
		this.name = name;
		this.town = town;
		this.classes = classes;
	}
});

var schoolClass = Class.create({
	init: function (name,capacity,formTeacher) {
		this.students = new Array();
		this.name = name;
		this.capacity = capacity;
		this.formTeacher = formTeacher;
	},
	add: function (student) {
		this.students.push(student);
	}
});

var schoolCharachter = Class.create({
	init: function (fname, lname, age) {
		this.fname = fname;
		this.lname = lname;
		this.age = age;
	},
	toString: function () {
		return "Name: " + this.fname + " " + this.lname + ", age " + this.age;
	}
});

var student = Class.create({
	init: function (fname, lname, age, grade) {
		this._super.init(fname, lname, age);
		this.grade = grade;
	},
	toString: function () {
		return this._super.toString() + ", grade " + this.grade;
	}
});

student.inherit(schoolCharachter);


var classOne = new schoolClass();
classOne.init("one", 5, "vasko-krypkata");

var studOne = new student();
studOne.init("a", "a", 17, 9);
var studTwo = new student();
studTwo.init("b", "b", 18, 12);

classOne.add(studOne);
classOne.add(studTwo);

var school = new school();
school.init("levski", "madagascar", classOne);

console.log(studOne.toString());