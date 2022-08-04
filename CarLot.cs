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

        public static void listCars(List<Car> listOfCars)
        {
            foreach (var car in listOfCars)
            {
                Console.WriteLine(car.ToString());
            }
        } 





    }
}
