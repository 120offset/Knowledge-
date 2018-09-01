using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarClass
{
    public class Car
    {
      
        public int YearModel { get; set; }
        public string Make { get; set; }
        public int Speed { get; set; }
        //property


        public Car(int yearModel, string make)
        {
            this.YearModel = yearModel;
            this.Make = make;
            this.Speed = 0;
        }
        //constructor

        public Car()
        {
            this.Speed = 0;
        }

        public void Accelerate()
        {
            this.Speed += 5;
        }
        public void Brake()
        {
            this.Speed -= 5;
        }
        //method
    }
}
