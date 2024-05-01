using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermForComputerProgrammingII
{
    class Order
    {
        //Initialize Random class
        Random rand = new Random();

        //Fields
        String orderNumber;
        List<Product> products;
        String customerName;
        decimal tax = 0.1m;

        //Constructors
        public Order(String orderNumber, List<Product> products, String customerName)
        {
            //Creates a random number for orderNumber
            this.orderNumber = rand.Next(10000000, 100000000).ToString();
            //Creates a List for products to be stored in
            this.products = new List<Product>();
            this.customerName = customerName;
        }

        //Properties
        public string OrderNumber { get => orderNumber; }
        public string CustomerName { get => customerName; set => customerName = value; }
        internal List<Product> Products { get => products; }

        //Methods
        public void addProduct(Product product)
        {
            products.Add(product);
        }
        public String formattedOrder()
        {

        }
        public decimal SubTotal()
        {
            //Counter
            decimal total = 0;
            //Loop through products
            for (int i = 0; i < products.Count; i++)
            {
                total += products[i].ProductPrice;
            }
            //Return total before tax
            return total;
        }
        public decimal SubTax()
        {
            //Return total tax amount;
            return SubTotal() * tax;
        }
        public override string ToString()
        {
            return $"{customerName} - {orderNumber}"; 
        }
    }
}
