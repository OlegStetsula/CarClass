using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.Generic;

namespace ClassTask
{
    class Car
    {
        string model;
        string color;
        decimal price;
        static List<Car> cars = new List<Car>();
        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        public Car()
        {
            model = "Unknown";
            color = "Unknown";
            price = 0;
            cars.Add(this);
        }
        public Car(string l, string c, decimal p)
        {
            model = l;
            color = c;
            price = p;
        }
        public void Input()
        {
            string model = Console.ReadLine();
            string color = Console.ReadLine();
            decimal price = decimal.Parse(Console.ReadLine());
            this.model = model;
            this.color = color;
            this.price = price;
        }
        public void Output()
        {
            Console.WriteLine("Model of this {0} car is {1} with price {2}", this.color, this.model, this.price);
        }
        public void ChangePrice(double x)
        {
            decimal percent = (this.price * (decimal)x) / 100;
            this.price += percent;
        }

    }
}
