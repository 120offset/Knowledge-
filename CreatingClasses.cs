using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AnimalFarm
{
    public class Chicken
    {
        /// <summary>
        /// this is the property 
        /// </summary>
        public string ChickenName { get; set; }
        public int ChickenAge { get; set; }
        public string ChickenFood { get; set; }
        public string ChickenSound { get; set; }

        public Chicken(string chickenName, int chickenAge, string chickenFood, string chickenSound)
        {
            this.ChickenName = chickenName;
            this.ChickenAge = chickenAge;
            this.ChickenFood = chickenFood;
            this.ChickenSound = chickenSound;
        }

        public string Name()
        {
            return this.ChickenName;
        }
        public int Age()
        {
            return this.ChickenAge;
        }
        public string Food()
        {
            return this.ChickenFood;
        }
        public string Sound()
        {
            return this.ChickenSound;
        }
    }
}
