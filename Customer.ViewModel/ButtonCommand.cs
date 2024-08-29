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
        private Action WhattoExecute;
        private Func<bool> WhentoExecute;
        public ButtonCommand(Action What, Func<bool> When) // Point 1
        {
            WhattoExecute = What;
            WhentoExecute = When;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return WhentoExecute(); // Point 2
        }
        public void Execute(object parameter)
        {
            WhattoExecute(); // Point 3
        }
    }
}
