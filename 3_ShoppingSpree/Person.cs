using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingSpree
{
    public class Person
    {
        //Each person should have a name, money and a bag of products. 

        private string name;
        private decimal money;
        private readonly List<Product> bag;

        public Person(string name, decimal money)
        {
            this.Name = name;
            this.Money = money;
            bag = new List<Product>();
        }


        public string Name
        {
            get => name;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be empty");
                }
                name = value;
            }
        }

        public decimal Money
        {
            get => money;
            private set
            {
                if (value<0)
                {
                    throw new ArgumentException("Money cannot be negative");
                }
                money = value;
            }
        }

        public void Buy(Product product)
        {
            if (product.Price>this.Money)
            {
                throw new InvalidOperationException($"{this.Name} can't afford {product.Name}");
            }

            Money -= product.Price;
            bag.Add(product);
            Console.WriteLine($"{this.Name} bought {product.Name}");
        }

        public override string ToString()
        {
            if (bag.Count==0)
            {
                return $"{this.Name} - Nothing bought";
            }

            return $"{Name} - {string.Join(", ", bag.Select(b => b.Name))}";
        }
    }
}