using System;

namespace Cadastro_de_Produtos
{
    public class Program
    {
        static void Main(string[] args)
        {
            string prodName, prodColor;
            double prodPrice;

            Console.Write("Insira o nome do produto a cadastrar => ");
            prodName = Console.ReadLine();
            Console.Clear();
            Console.Write($"Insira o preço do {prodName} => ");
            prodPrice = double.Parse(Console.ReadLine());
            Console.Clear();
            Console.Write($"Insira a cor do {prodName} => ");
            prodColor = Console.ReadLine();
            Console.Clear();

            Products prod = new Products(DateTime.Now);
            Console.WriteLine(prod.NewProduct(prodName, prodPrice, prodColor));
        }
    }
}
