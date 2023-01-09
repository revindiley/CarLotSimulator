using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    public class Car
    {
        public Car() { }

        public int? Year { get; set; }
        public string  Make { get; set; }
        public string Model { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public bool IsDriveable { get; set; } 

        //public car(int year, string make, string model, string enginenoise, string honknoise, bool isdriveable)
        //{
        //    year = year;
        //    make = make;
        //    model = model;
        //    enginenoise = enginenoise;
        //    honknoise = honknoise;
        //    isdriveable = isdriveable;
        //}

        public void MakeEngineNoise(string engineNoise)
        {
            Console.WriteLine(engineNoise);
        }

        public void MakeHonkNoise(string honkNoise)
        {
            Console.WriteLine(honkNoise);
        }

   
    
    }




    
    
}
