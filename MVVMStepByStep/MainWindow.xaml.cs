using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MVVMStepByStep
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        public Customer.Model.Customer customer = new Customer.Model.Customer();
        /// <summary>
        /// Behind code is here
        /// </summary>
        private void ConversionAndMappingLogic()
        {
            lblName.Text = customer.Name; // mapping code
            lblAmount.Text = customer.Amount.ToString(); // mapping code

            if (customer.Amount > 2000) // transformation code
            {
                lblBuyingHabits.Background = new SolidColorBrush(Colors.Blue);
            }
            else if (customer.Amount > 1500) // transformation code
            {
                lblBuyingHabits.Background = new SolidColorBrush(Colors.Red);
            }

            if (customer.Married == "Married") // transformation code
            {
                chkMarried.IsChecked = true;
            }
            else
            {
                chkMarried.IsChecked = false;
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ConversionAndMappingLogic();
        }
    }
}
