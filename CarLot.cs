using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsedCarLotLab
{
    public abstract class CarLot
    {

        public static void ListCars(List<Car> listOfCars)
        {
            foreach (var car in listOfCars)
            {
                Console.WriteLine(car.ToString());
            }
        }

        public static Car AddNewCar(List<Car> listOfCars)
        {
            Console.WriteLine("Please list the Make of the car:");
            string carMake = Console.ReadLine();
            Console.WriteLine("Please list the Model of the car:");
            string carModel = Console.ReadLine();
            Console.WriteLine("Please list the Year of the car:");
            int carYear = int.Parse(Console.ReadLine());
            Console.WriteLine("Please list the Price of the car:");
            decimal carPrice = decimal.Parse(Console.ReadLine());
            var userCar = new Car(carMake, carModel, carYear, carPrice);
            Console.WriteLine($"{userCar} has been added.");
            listOfCars.Add(userCar);
            return userCar;
        }

        public static UsedCar AddUsedCar(List<Car> listOfCars)
        {
            Console.WriteLine("Please list the Make of the car:");
            string carMake = Console.ReadLine();
            Console.WriteLine("Please list the Model of the car:");
            string carModel = Console.ReadLine();
            Console.WriteLine("Please list the Year of the car:");
            int carYear = int.Parse(Console.ReadLine());
            Console.WriteLine("Please list the Price of the car:");
            decimal carPrice = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Please list the Price of the car:");
            double carMileage = double.Parse(Console.ReadLine());
            var userCar = new UsedCar(carMake, carModel, carYear, carPrice, carMileage);
            Console.WriteLine($"{userCar} has been added.");
            listOfCars.Add(userCar);
            return userCar;
        }

        public static void BuyACar(List<Car> listOfCars)
        {
            Console.WriteLine("What car would you like to buy?");
            string purchaseCar = Console.ReadLine();
            var carList = listOfCars.FindAll(car => car.Make.ToLower() == purchaseCar);
        }
    }
}


   

