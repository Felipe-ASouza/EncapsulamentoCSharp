using System;

namespace Encapsulamento
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Produto produto = new Produto("TV", 500, 10);

            produto.Nome = "T";
            
            Console.WriteLine(produto.Nome);
            Console.WriteLine(produto.Preco);


        }
    }
}