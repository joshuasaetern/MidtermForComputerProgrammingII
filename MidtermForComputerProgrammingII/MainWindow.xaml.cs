using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MidtermForComputerProgrammingII
{
    /// Joshua Saetern
    /// 05.01.2024
    /// Computer Programming II
    /// Midterm project
    public partial class MainWindow : Window
    {
        //Create an instance of Inventory Class
        Inventory inventory = new Inventory();

        //List for our orders which have been completed
        List<Product> completedOrders = new List<Product>();

        //Stores the order which is currently being completed
        Order currentOrder;

        public MainWindow() //Main method
        {
            InitializeComponent();



        }

        //Coffee Buttons
        private void btnDarkCoffee_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnMediumCoffee_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnLightCoffee_Click(object sender, RoutedEventArgs e)
        {

        }

        //Tea Buttons
        private void btnTeaGreen_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnTeaBlack_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnTeaChai_Click(object sender, RoutedEventArgs e)
        {

        }
        
        //Breakfast Buttons
        private void btnBreakfastSandwich_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnBreakfastPastry_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnBreakfastFruit_Click(object sender, RoutedEventArgs e)
        {

        }
        
        //Misc
        private void btnCompletePurchase_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}