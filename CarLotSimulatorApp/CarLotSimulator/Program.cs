using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car - DONE
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable - DONE
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise() - DONE
            //The methods should take one string parameter: the respective noise property - DONE

            var myCar1 = new Car() // Object Initialization
            {
                Make = "Toyota",
                Model = "Camry",
                Year = 1999,
                EngineNoise = "VROOM!",
                HonkNoise = "HONK!",
                IsDriveable = true,
            };

            var myCar2 = new Car() { Make = "Honda", Model = "Pilot", Year = 2002, EngineNoise = "VROOM!",
                HonkNoise = "BEEP", IsDriveable = true };

            var myCar3 = new Car(); // Instanciating
            myCar3.Make = "Jeep";
            myCar3.Model = "Wrangler";
            myCar3.Year = 2022;
            myCar3.EngineNoise = "VROOM!";
            myCar3.HonkNoise = "HONK!";
            myCar3.IsDriveable = true;            

            Car.MakeEngineNoise(myCar1);
            Car.MakeHonkNoise(myCar1);
            Car.MakeEngineNoise(myCar2);
            Car.MakeHonkNoise(myCar2);
            Car.MakeEngineNoise(myCar3);
            Car.MakeHonkNoise(myCar3);
            //Now that the Car class is created we can instanciate 3 new cars - DONE
            //Set the properties for each of the cars - DONE
            //Call each of the methods for each car - DONE

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car - DONE

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}
