using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermForComputerProgrammingII
{
    class Product
    {
        //Fields
        String productName;
        decimal productPrice;

        //Constructors
        public Product(String productName, decimal productPrice)
        {
            this.productName = productName;
            this.productPrice = productPrice;
        }

        //Properties
        public string ProductName { get => productName; set => productName = value; }
        public decimal ProductPrice { get => productPrice; set => productPrice = value; }

        //Methods
        public override String ToString()
        {
            return $"{productName} - {productPrice}";
        }
    }
}
