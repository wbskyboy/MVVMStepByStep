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
            Amount = 200;
            Married = "Married";
        }
        public string Name { get; set; }

        public int Amount { get; set; }

        public string Married { get; set; }
    }
}
