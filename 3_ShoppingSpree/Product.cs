using System;

namespace ShoppingSpree
{
    public class Product
    {
        //Each product should have a name and a cost. Name cannot be an empty string. Money cannot be a negative number. 

        private string name;
        private decimal price;

        public Product(string name, decimal price)
        {
            this.Name = name;
            this.Price = price;
        }
        public decimal Price
        {
            get => price;
           private set
            {
                if (value<0)
                {
                    throw new ArgumentException("Money cannot be negative");
                }
                price = value;
            }
        }


        public string Name
        {
            get => name;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be empty");
                }
                name = value;
            }
        }


    }
}