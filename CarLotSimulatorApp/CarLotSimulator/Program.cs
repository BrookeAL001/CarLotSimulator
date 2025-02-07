﻿using System;
using System.Collections.Generic;

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

            var SmithCar = new Car();
            SmithCar.Make = "Toyota";
            SmithCar.Model = "Tacoma";
            SmithCar.Year = 2019;
            SmithCar.EngineNoise = "Rattle";
            SmithCar.HonkNoise = "Beep Boop";
            SmithCar.IsDriveable = true;

            var JonesCar = new Car();
            JonesCar.Make = "Honda";
            JonesCar.Model = "Civic";
            JonesCar.Year = 2022;
            JonesCar.EngineNoise = "Purr";
            JonesCar.HonkNoise = "Meep Meep";
            JonesCar.IsDriveable = true;


            var cars = new List<Car>();
            cars.Add(SmithCar);
            cars.Add(JonesCar);

            foreach(var Car in cars)
            {
                Car.MakeEngineNoise();
                Car.MakeHonkNoise();

            }


            Console.Write($"Number of cars created: {CarLot.numberOfCars}");

            

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
