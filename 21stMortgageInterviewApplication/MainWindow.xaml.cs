using _21stMortgageInterviewApplication.ViewModels;
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

namespace _21stMortgageInterviewApplication
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {


        private WPFTestViewModel WPFTestViewModel = WPFTestViewModel.GetInstance;
        public MainWindow()
        {
            

            InitializeComponent();
            DataContext = WPFTestViewModel;

            WPFTestViewModel.Results = "";
            WPFTestViewModel.UserInput = "12,-10,3,4,5,8";

        }
    }
}
