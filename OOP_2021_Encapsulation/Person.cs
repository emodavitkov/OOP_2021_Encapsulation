using System;
using System.Collections.Generic;

namespace PersonsInfo
{
    public class Person
    {
        private string firstName;
        private string lastname;
        private int age;
        private decimal salary;

        

        public string FirstName
        {
            get => this.firstName;
            private set
            {
                if (value.Length<3)
                {
                    throw new ArgumentException("Tova ne e ime??!");
                }

                this.firstName = value;
            }
        }


        //public string FirstName { get; private set; }
        public string LastName { get; private set; }

        public int Age { get; private set; }

        public decimal Salary { get; private set; }

        public void IncreaseSalary(decimal percentage)
        {
            if (Age<30)
            {
                percentage /=2;
            }

            Salary = Salary + Salary * percentage / 100;
        }

        public Person(string firstName,string lastName,int age,decimal salary)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.Salary = salary;
        }

        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName} receives {this.Salary:f2} leva.";
        }
    }
}