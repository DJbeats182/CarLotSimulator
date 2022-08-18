using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSimulator
{
    internal class Car
    {
        public Car()
        {

        }

        public int Year { get; set; }   
        public string Make { get; set; }
        public string Model { get; set; }   
        public string EngineNoise { get; set; } 
        public string HonkNoise { get; set; }
        public bool IsDriveable { get; set; }

        public static void MakeEngineNoise(Car engineNoise)
        {
            Console.WriteLine("VROOM! VROOM!");
        }

        public static void MakeHonkNoise(Car honkNoise)
        {
            Console.WriteLine("HONK! HONK!");
        }
    }
}
