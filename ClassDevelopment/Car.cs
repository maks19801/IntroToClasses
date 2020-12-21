using System;
using System.Collections.Generic;
using System.Text;

namespace ClassDevelopment
{
    public partial class Car
    {
       
        private decimal price;
        public int maxSpeed;
        public int currentSpeed;
        public double maxGasolineQuantity;
        public double currentGasolineQuantity;
        public double milage;
        public double gasolineConsumptionPerMile;

        public static int totalNumberOfCars;
        public static int speedIncrement;
        public static int speedDecrement;

        static Car()
        {
            totalNumberOfCars = 0;
            speedIncrement = 5;
            speedDecrement = 5;
        
        }

        public Car()
        {
            Manufacturer = "nothing yet";
            Model = "nothing yet";
            Color = "nothing yet";
            RegistrationNumber = "nothing yet";
            Price = 1000.00M;
            DateOfManufacture = "nothing yet";
            maxSpeed = 0;
            currentSpeed = 0;
            maxGasolineQuantity = 0.0;
            currentGasolineQuantity = 0.0;
            milage = 0.0;
            gasolineConsumptionPerMile = 0.0;
            totalNumberOfCars++;
        }

        public Car(string manufacturer, string model, string color,
                   string registrationNumber, decimal price, string dateOfManufacture, double gasolineConsumptionPerMile)
        {
            Manufacturer = manufacturer;
            Model = model;
            Color = color;
            RegistrationNumber = registrationNumber;
            Price = price;
            DateOfManufacture = dateOfManufacture;
            this.gasolineConsumptionPerMile = gasolineConsumptionPerMile;
            totalNumberOfCars++;

        }

        public Car(string manufacturer, string model, string color,
                   string registrationNumber, decimal price, string dateOfManufacture,
                   int maxSpeed, double gasolineQuantity, double milage, double gasolineConsumptionPerMile)
        {
            Manufacturer = manufacturer;
            Model = model;
            Color = color;
            RegistrationNumber = registrationNumber;
            Price = price;
            DateOfManufacture = dateOfManufacture;
            this.maxSpeed = maxSpeed;
            this.maxGasolineQuantity = gasolineQuantity;
            this.milage = milage;
            this.gasolineConsumptionPerMile = gasolineConsumptionPerMile;
            totalNumberOfCars++;
          
        }

        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public string RegistrationNumber { get; set; }
        public decimal Price 
        {
           set 
            {
                if (value > 100000 || value < 1000)
                {
                    Console.WriteLine("Price should be between 1000 and 100000 dollars");
                }
                else
                {
                    price = value;
                }

            }
            get { return price; }
        }

        public override string ToString()
        {
            return "Manufacturer: " + Manufacturer + " " + "\n" +
            "Model: " + Model + " " + "\n" +
            "Color: " + Color + " " + "\n" +
            "RegistrationNumber: " + RegistrationNumber + " " + "\n" +
            "Price: " + Price + " " + "\n" +
            "DateOfManufacture: " + DateOfManufacture + " " + "\n" +
            "maxSpeed: " + maxSpeed + " " + "\n" +
            "currentSpeed: " + currentSpeed + " " + "\n" +
            "maxGasolineQuantity: " + maxGasolineQuantity + " " + "\n" +
            "currentGasolineQuantity: " + currentGasolineQuantity + " " + "\n" +
            "gasolineConsumptionPerMile: " + gasolineConsumptionPerMile + " " + "\n" +
            "milage: " + milage + " " + "\n"; 
        }

        public string DateOfManufacture { get; set; }

        public void AddGasoline(double gasolineQuantity)
        {
            if (gasolineQuantity <= maxGasolineQuantity - currentGasolineQuantity)
            {
                currentGasolineQuantity = currentGasolineQuantity + gasolineQuantity;
            } 
            else
            {
                currentGasolineQuantity =  maxGasolineQuantity - currentGasolineQuantity;
            }
        }
        public void IncreaseSpeed()
        {
            if(currentSpeed + speedIncrement > maxSpeed)
            {
                currentSpeed = maxSpeed;
            }
            else
            {
                currentSpeed += speedIncrement;
            }
            
        }

        public void DecreaseSpeed()
        {
            if (currentSpeed - speedDecrement <= 0)
            {
                currentSpeed = 0;
            }
            else
            {
                currentSpeed -= speedDecrement;
            }
        }
    }
}
