using System;
using System.Collections.Generic;
using System.Text;

namespace Cadastro_de_Produtos
{
    public class Products
    {
        private DateTime registerProduct;
        public Products(DateTime registerProduct)
        {
            this.registerProduct = registerProduct;
        }

        public string NewProduct (string productName, double productPrice, string productColor)
        {           
            return $"Register at: {registerProduct}\nName: '{productName}'\nPrice: '{productPrice.ToString("C")}'\nColor: '{productColor}'";
        }
    }
}
