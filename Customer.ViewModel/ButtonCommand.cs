using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Customer.ViewModel
{
    public class ButtonCommand : ICommand
    {
        private CustomerViewModel obj; // Point 1
        public ButtonCommand(CustomerViewModel _obj) // Point 2
        {
            obj = _obj;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true; // Point 3
        }
        public void Execute(object parameter)
        {
            obj.Calculate(); // Point 4
        }
    }
}
