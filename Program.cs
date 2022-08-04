using System.Diagnostics;
using UsedCarLotLab;
var cruze = new  UsedCar("Chevrolet", "Cruze", 2015, 10000.00m, 63000.00);
var rav4 = new UsedCar("Toyota", "Rav4", 2016, 21000.00m, 62000.00);
var flex = new UsedCar("Ford", "Flex", 2019, 20000.00m, 48000.00);

var aventador = new Car("Lambourgini", "Aventador", 2022, 300000.00m);
var modelSPlaid = new Car("Tesla", "Model S Plaid", 2022, 200000.00m);
var ferrari = new Car("Ferrari", "F8 Spider", 2022, 302500.00m);

//methods

var listOfVehicles = new List<Car>() { cruze, rav4, flex, aventador, modelSPlaid, ferrari }; //POLYMORPHISM


//foreach (var car in listOfVehicles)
//{

//    Console.WriteLine(car.ToString());
//}


CarLot.ListCars(listOfVehicles);

CarLot.AddNewCar(listOfVehicles);

CarLot.ListCars(listOfVehicles);
