﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Car car = new Car();
            Car car1 = new Car();

            car.Color = "White";
            car.Year = 2023;
            car.Model = "Kwid";
            car.Brand = "Renaut";


            car1.Color = "White";
            car1.Year = 2020;
            car1.Model = "Onix";
            car1.Brand = "Chevrolet";

            Console.WriteLine("----Gabriel's Car----");
            Console.WriteLine($"Brand: {car.Brand}");
            Console.WriteLine($"Modelo: {car.Model}");
            Console.WriteLine($"Ano: {car.Year}");
            Console.WriteLine($"Cor: {car.Color}");
            car.Ride();

            Console.WriteLine();


            Console.WriteLine("----Tony's Car----");
            Console.WriteLine($"Brand: {car1.Brand}");
            Console.WriteLine($"Model: {car1.Model}");
            Console.WriteLine($"Year: {car1.Year}");
            Console.WriteLine($"Color: {car1.Color}");
            car1.Parked();
            
            Console.Read();
        }
    }
}