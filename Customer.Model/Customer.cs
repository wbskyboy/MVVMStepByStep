using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer.Model
{
    public class Customer
    {
        public Customer()
        {
            Name = "ShiV";
            Amount = 2500;
            Married = "Married";
        }
        public string Name { get; set; }

        public double Amount { get; set; }

        public string Married { get; set; }

        private double _Tax;
        public double Tax
        {
            get { return _Tax; }
        }

        public void CalculateTax()
        {
            if (Amount > 2000)
            {
                _Tax = 20;
            }
            else if (Amount > 1000)
            {
                _Tax = 10;
            }
            else
            {
                _Tax = 5;
            }
        }
    }
}
