using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MiguelC.BasicTypes
{
    public class CoffeeCapsule
    {
        
        private int intensity;
        private double price;

        public string Name { get; set; }
        public int Intensity
        {
            get
            {
                return this.intensity;
            }
            set
            {
                if (value > 0)
                {
                    this.intensity = value;
                }
                else
                {
                    throw new ArgumentException("The intensity cannot be zero or negative.");
                }
            }
        }
        public double Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value > 0)
                {
                    this.price = value;
                }
                else
                {
                    throw new ArgumentException("The price cannot be zero or negative.");
                }
            }
        }

        public CoffeeCapsule(string name, int intensity, double price)
        {
            this.Name = name;
            this.Intensity = intensity;
            this.Price = price;
        }

        public bool isValid()
        {
            return !string.IsNullOrWhiteSpace(this.Name) && this.Intensity > 0 && this.Price > 0;
        }
    }

    public class Request
    {

        public List<KeyValuePair<CoffeeCapsule,int>> Capsules { get; }
        public double PriceTotal { get; }

        public Request()
        {
            this.Capsules = new List<KeyValuePair<CoffeeCapsule, int>>();
            this.PriceTotal = 0;
        }

        public Request(List<KeyValuePair<CoffeeCapsule, int>> capsuleList)
        {
            this.Capsules = capsuleList;
            this.PriceTotal = 0;
            foreach(KeyValuePair<CoffeeCapsule, int> item in capsuleList)
            {
                this.PriceTotal += item.Key.Price * item.Value;
            }
        }
    }

    public class User
    {
        public string Username { get; }
        public double Debt { get; }


    }
}