function trip(car) {
    console.log("Welcome to the trip function");
    car.drive();
    console.log("You are driving a " + car.color + " " + car.model + ".");
    console.log("Finished the trip.");
}
function testtrip() {
    var honda = {
        model: "Civic",
        color: "Red",
        drive: function () {
            console.log("Honda is driving");
        }
    };
    var schwin = {
        model: "Abc",
        color: "Black",
        wheelsize: 30
    };
    var chevy = {
        model: "Trax",
        color: "Blue",
        drive: function () {
            console.log("Chevy is driving");
        }
    };
    trip(honda);
    trip(chevy);
    //trip(schwin);
    var carshop = [
        honda, chevy
    ];
    carshop.push(chevy);
    //carshop.push(schwin);
    for (var _i = 0, carshop_1 = carshop; _i < carshop_1.length; _i++) {
        var car = carshop_1[_i];
        console.log(car.model);
    }
}
//# sourceMappingURL=app.js.map