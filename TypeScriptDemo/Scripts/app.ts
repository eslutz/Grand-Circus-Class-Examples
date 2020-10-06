interface Car {
	model: String,
	color: String,
	drive(): void
}

function trip(car: Car) {
	console.log("Welcome to the trip function");
	car.drive();
	console.log(`You are driving a ${car.color} ${car.model}.`);
	console.log("Finished the trip.");
}

function testtrip() {
	let honda: Car = {
		model: "Civic",
		color: "Red",
		drive: function () {
			console.log("Honda is driving");
		}
	};

	let schwin = {
		model: "Abc",
		color: "Black",
		wheelsize: 30
	};

	let chevy: Car = {
		model: "Trax",
		color: "Blue",
		drive: function () {
			console.log("Chevy is driving");
		}
	};

	trip(honda);
	trip(chevy);
	//trip(schwin);
}