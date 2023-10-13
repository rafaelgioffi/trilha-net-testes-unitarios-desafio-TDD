using Cadastro_de_Produtos;
using System;
using Xunit;

namespace TestProductsManager
{
    public class UnitTest1
    {
        public Products constructClass()
        {
            DateTime dateTime = DateTime.Now;
            Products prod = new Products(dateTime);
            return prod;
        }

        [Fact]
        public void VerifyProductNameIsNotEmpty()
        {
            // Arrange
            Products prod = constructClass();

            // Act
            string result = prod.NewProduct("Camisa",49.90,"Azul");

            // Assert
            Assert.NotEmpty(result);
        }
    }
}

