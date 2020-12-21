using System;
using System.Collections.Generic;

namespace ClassDevelopment
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            Car unknownCar = new Car();
            Car fordFiesta = new Car("Ford", "Fiesta", "8178AB", "grey", 70000, "1980", 200, 45.0, 55000, 0.1);
            Car fordMondeo = new Car("Ford", "Mondeo", "8008VM", "blue", 10000, "2000", 0.2);
            Car daewooLanos = new Car("Daewoo", "Lanos", "4253OF", "white", 3500, "2007", 0.2);
            Car daewooMatis = new Car("Daewoo", "Matis", "9076HD", "red", 3000, "2010", 160, 35, 110000, 0.1 );

            cars.Add(unknownCar);
            cars.Add(fordFiesta);
            cars.Add(fordMondeo);
            cars.Add(daewooLanos);
            cars.Add(daewooMatis);
            foreach (Car car in cars)
            {
                Console.WriteLine(car.ToString());
            }

            daewooMatis.AddGasoline(20);
            daewooMatis.AddGasoline(10);
            daewooMatis.IncreaseSpeed();
            daewooMatis.IncreaseSpeed();
            //daewooMatis.DecreaseSpeed();
            daewooMatis.Drive(200);
            Console.WriteLine(daewooMatis.ToString());


            Console.WriteLine("Total number of cars: " + Car.totalNumberOfCars);

        }
    }
}
