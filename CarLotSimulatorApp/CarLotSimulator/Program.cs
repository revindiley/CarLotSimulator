using Microsoft.VisualBasic;
using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            Car devinsCar = new Car();
            devinsCar.Make = "Ford";
            devinsCar.Year = 2017;
            devinsCar.Model = "Edge";
            devinsCar.EngineNoise = "VROOOOOOOOM";
            devinsCar.HonkNoise = "beep";
            devinsCar.IsDriveable= true;

            var samsCar = new Car()
            {
                Year= 2017, 
                Make = "Kia",
                Model = "Optima", 
                EngineNoise= "eeeeooooooowwwwww!!!!!!",
                HonkNoise = "eep eep",
                IsDriveable= true, 
            };

            var momsCar = new Car()
            {
                Year = 2018,
                Make = "Toyota",
                Model = "Corrolla", 
                EngineNoise = "vroom VROOM",
                HonkNoise = "boop boop", 
                IsDriveable= true,
            };

            devinsCar.MakeEngineNoise($"Devin's Car sounds like: {devinsCar.EngineNoise}");
            samsCar.MakeEngineNoise($"Sam's Car sounds like: {samsCar.EngineNoise}");
            momsCar.MakeEngineNoise($"Mom's Car sounds like: {momsCar.EngineNoise}");
            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}
