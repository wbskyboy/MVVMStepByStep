﻿using Customer.ViewModel;
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


        public CustomerViewModel customer = new CustomerViewModel();

        private void DisplayUi(CustomerViewModel o)
        {
            lblName.Text = o.TxtCustomerName;
            lblAmount.Text = o.TxtAmount;
            BrushConverter brushconv = new BrushConverter();
            lblBuyingHabits.Background = brushconv.ConvertFromString(o.LblAmountColor) as SolidColorBrush;
            chkMarried.IsChecked = o.IsMarried;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            DisplayUi(customer);
        }
    }
}
