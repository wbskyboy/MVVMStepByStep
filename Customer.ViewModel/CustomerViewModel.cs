using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Customer.ViewModel
{
    public class CustomerViewModel : INotifyPropertyChanged // Point 1
    {
        public CustomerViewModel()
        {
            objCommand = new ButtonCommand(Calculate, obj.IsValid); // Point 2
        }

        private Customer.Model.Customer obj = new Model.Customer();

        public string TxtCustomerName
        {
            get { return obj.Name; }
            set { obj.Name = value; }
        }

        public string TxtAmount
        {
            get { return Convert.ToString(obj.Amount); }
            set { 
                obj.Amount = Convert.ToDouble(value);
                if (PropertyChanged != null) // Point 2
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("LblAmountColor"));
                    // Point 3
                }
            }
        }

        public string Tax
        {
            get { return Convert.ToString(obj.Tax); }
        }


        public string LblAmountColor
        {
            get
            {
                if (obj.Amount > 2000)
                {
                    return "Blue";
                }
                else if (obj.Amount > 1000)
                {
                    return "Red";
                }
                return "Yellow";
            }
        }

        public bool IsMarried
        {
            get
            {
                if (obj.Married == "Married")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }


        private ButtonCommand objCommand; //  Point 1

        public ICommand btnClick // Point 3
        {
            get
            {
                return objCommand;
            }
        }

        public void Calculate()
        {
            obj.CalculateTax();
            if (PropertyChanged != null) // Point 2
            {
                PropertyChanged(this, new PropertyChangedEventArgs("Tax"));
                // Point 3
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
