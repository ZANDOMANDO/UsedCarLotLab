using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsedCarLotLab
{
    public class UsedCar : Car
    {
        //Constructor
        public UsedCar(string _make, string _model, int _year, decimal _price, double _mileage) : base(_make, _model, _year, _price) 
        { 
            Mileage = _mileage; 
        }      
        public double Mileage { get; set; }

        public override string ToString()
        {
            return $"{Make}, {Model} , {Year} , {Price}";
        }
    }     
}
