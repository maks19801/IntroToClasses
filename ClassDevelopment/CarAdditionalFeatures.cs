using System;
using System.Collections.Generic;
using System.Text;

namespace ClassDevelopment
{
    public partial class Car
    {
        public double driveTime;
        public void Drive(double miles)
        {
            driveTime = miles / currentSpeed;

            if (currentGasolineQuantity < miles * gasolineConsumptionPerMile)
            {
                Console.WriteLine("Not enough gasoline! Please add gasoline!");
            }
            else
            {
                currentGasolineQuantity = currentGasolineQuantity - miles * gasolineConsumptionPerMile;
                Console.WriteLine("Congrats! You have reached your destination in " + driveTime + " hours!\n" + "You have still " + currentGasolineQuantity + " litres of gasoline left!\n");
            }
        }
    }
}
