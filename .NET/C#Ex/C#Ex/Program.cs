using System;
using System.Collections.Generic;
using System.IO;

namespace MyApp
{
    internal class Program
    {
        public static StreamReader auchan = new StreamReader(@"C:\Users\silva\Documents\GitHub\ATEC\.NET\files\auchan.txt");
        static void Main(string[] args)
        {
            Menu();
        }
        static List<Produto> FileToProduct(StreamReader reader)
        {
            List<Produto> products = new List<Produto>();
            string? line;
            while ((line = auchan.ReadLine()) != null) {
                Produto produto = new Produto();
                produto.nome = line.Substring(0, line.IndexOf("*"));
                produto.precoFinal = int.Parse(line.Substring(line.IndexOf("*") + 1, line.IndexOf("#")));
                produto.quantidade = int.Parse(line.Substring(line.IndexOf("#") + 1, line.IndexOf("|")));
                produto.seccao = line.Substring(line.IndexOf("|") + 1, line.IndexOf("&"));
                produto.hipermercado = line.Substring(line.IndexOf("&"), line.Length - 1);
                products.Add(produto);
            }
            return products;
        }
        public static void Menu()
        {
            Console.Clear();
            Console.Write(
                "1 – Mostrar no ecran o conteúdo de todo o ficheiro \r\n" +
                "2 – Mostrar no ecran apenas os produtos do Hipermercado de “Setúbal” \r\n" +
                "3 – Mostrar no ecran apenas os produtos da seção “Charcutaria” ordenados por quantidade de forma descendente \r\n" +
                "4 – Mostrar no ecran apenas os produtos do Hipermercado do “Porto” e que sejam da seção “Charcutaria” \r\n" +
                "5 – Mostrar no ecran o total da soma de todos os preços finais \r\n" +
                "6 – Gerar um ficheiro “Setubal.txt” que deverá conter todos os produtos do Hipermercado “Setúbal” \r\n" +
                "7 – Gerar um ficheiro “Peixaria.txt” que deverá conter todos os produtos da seção “Peixaria” \r\n" +
                "8 – Sair\r\n" +
                "Opção: ");
            int.TryParse(Console.ReadLine(), out int opt);
            if (opt > 0 && opt <= 8) Options(opt);
            else Menu();
        }
        public static void Options(int opt)
        {
            switch (opt)
            {
                case 1:
                    ShowAll();
                   break;
            }
        }
        public static void ShowAll()
        {

        }
    }
    public struct Produto
    {
        public string nome;
        public double precoFinal;
        public int quantidade;
        public string seccao;
        public string hipermercado;
    }
}