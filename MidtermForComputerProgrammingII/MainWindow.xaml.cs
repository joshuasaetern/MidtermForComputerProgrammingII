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
using System;

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
        List<Order> completedOrders = new List<Order>();

        //Stores the order which is currently being completed
        Order currentOrder;

        public MainWindow() //Main method
        {
            InitializeComponent();

            //Attaches our completed orders list to the listbox
            comboBoxPreviousOrders.ItemsSource = completedOrders;

            Order order = new Order();

            currentOrder = order;

        }

        //Coffee Buttons
        private void btnDarkCoffee_Click(object sender, RoutedEventArgs e)
        {
            currentOrder.AddProduct(inventory.CoffeeProducts[0]);
            runOrderDisplay.Text = currentOrder.FormattedOrder();
        }

        private void btnMediumCoffee_Click(object sender, RoutedEventArgs e)
        {
            currentOrder.AddProduct(inventory.CoffeeProducts[1]);
            runOrderDisplay.Text = currentOrder.FormattedOrder();
        }

        private void btnLightCoffee_Click(object sender, RoutedEventArgs e)
        {
            currentOrder.AddProduct(inventory.CoffeeProducts[2]);
            runOrderDisplay.Text = currentOrder.FormattedOrder();
        }

        //Tea Buttons

        private void btnTeaBlack_Click(object sender, RoutedEventArgs e)
        {
            currentOrder.AddProduct(inventory.TeaProducts[0]);
            runOrderDisplay.Text = currentOrder.FormattedOrder();
        }
        private void btnTeaGreen_Click(object sender, RoutedEventArgs e)
        {
            currentOrder.AddProduct(inventory.TeaProducts[1]);
            runOrderDisplay.Text = currentOrder.FormattedOrder();
        }
        private void btnTeaChai_Click(object sender, RoutedEventArgs e)
        {
            currentOrder.AddProduct(inventory.TeaProducts[2]);
            runOrderDisplay.Text = currentOrder.FormattedOrder();
        }
        
        //Breakfast Buttons
        private void btnBreakfastSandwich_Click(object sender, RoutedEventArgs e)
        {
            currentOrder.AddProduct(inventory.BreakfastProducts[0]);
            runOrderDisplay.Text = currentOrder.FormattedOrder();
        }

        private void btnBreakfastPastry_Click(object sender, RoutedEventArgs e)
        {
            currentOrder.AddProduct(inventory.BreakfastProducts[1]);
            runOrderDisplay.Text = currentOrder.FormattedOrder();
        }

        private void btnBreakfastFruit_Click(object sender, RoutedEventArgs e)
        {
            currentOrder.AddProduct(inventory.BreakfastProducts[2]);
            runOrderDisplay.Text = currentOrder.FormattedOrder();
        }
        
        //Misc
        private void btnCompletePurchase_Click(object sender, RoutedEventArgs e)
        {
            CompletePurchase();
        }

        private void comboBoxPreviousOrders_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            richTxtBoxPreviousDisplay.Text = completedOrders[comboBoxPreviousOrders.SelectedIndex].FormattedOrder();

            comboBoxPreviousOrders.ItemsSource = completedOrders;
        }

        private void btnRemove_Click(object sender, RoutedEventArgs e)
        {
            RemoveFromOrder();
        }
        private Boolean RemoveFromOrder()
        {
            try
            {
                //Parses text from the index textbox
                int index = int.Parse(txtBoxIndex.Text) - 1;
                //Checks if index exists in the current order
                if (index < 0)
                {
                    MessageBox.Show("Index must be positive");
                    return false;
                }
                //Checks if index exists in currentOrder
                else if (index > currentOrder.Products.Count - 1)
                {
                    MessageBox.Show("Index doesnt exist in current order");
                    return false;
                }
                //Remove from the current order and refresh the richTextBox
                currentOrder.RemoveProduct(index);
                runOrderDisplay.Text = currentOrder.FormattedOrder();
                return true;
            }
            catch
            {
                MessageBox.Show("Not a valid index");
                return false;
            }
        }
        private Boolean CompletePurchase()
        {
            //Checks if any products have been added
            if (currentOrder.Products.Count == 0)
            {
                MessageBox.Show("There has been no products added to purchase");
                return false;
            }
            //Checks is a customerName has been inputed
            if (String.IsNullOrEmpty(txtBoxCustomerName.Text))
            {
                MessageBox.Show("Please enter a name for your order");
                return false;
            }
            //Adds name to our order
            currentOrder.CustomerName = txtBoxCustomerName.Text;
            //Adds our finished order to our list of previous orders
            int index = completedOrders.Count();
            completedOrders.Add(currentOrder);
            //Adds all products into current order
            for (int i = 0; i < currentOrder.Products.Count; i++)
            {
                completedOrders[index].Products.Add(currentOrder.Products[i]);
            }

            comboBoxPreviousOrders.Items.Refresh();

            //Clears runOrderDisplay
            runOrderDisplay.Text = "";
            
            //Resets the current order
            currentOrder.Products.Clear();
            currentOrder = new Order();

            MessageBox.Show("Your order has been completed! Thank you!");
            return true;
        }
    }
}