using System;
using System.Collections.Generic;
using System.IO;

namespace MyApp
{
    internal class Program
    {
        public static StreamReader chip7file = new StreamReader(@"C:\Users\silva\Documents\GitHub\ATEC\.NET\files\chip7.txt", System.Text.Encoding.UTF8);
        static List<Produto> produtos = new List<Produto>();
        static void Main(string[] args)
        {
            produtos = FileToProduct(chip7file);
            Menu();
        }
        static List<Produto> FileToProduct(StreamReader reader)
        {
            List<Produto> softwares = new List<Produto>();
            string? line;
            while ((line = chip7file.ReadLine()) != null)
            {
                Produto software = new Produto();
                software.produto = line.Substring(0, line.IndexOf("&"));
                string remainLine = line.Substring(line.IndexOf("&") + 1, line.Length - line.IndexOf("&") - 1);
                software.preco = int.Parse(remainLine.Substring(0, remainLine.IndexOf("&")));
                remainLine = remainLine.Substring(remainLine.IndexOf("&") + 2, remainLine.Length - remainLine.IndexOf("&") - 2);
                software.stock = int.Parse(remainLine.Substring(0, remainLine.IndexOf("&")));
                remainLine = remainLine.Substring(remainLine.IndexOf("&") + 3, remainLine.Length - remainLine.IndexOf("&") - 3);
                software.loja = remainLine;
                softwares.Add(software);
            }
            return softwares;
        }
        public static void Menu()
        {
            Console.Clear();
            Console.Write(
                "1 – Mostrar no ecran o conteúdo de todo o ficheiro \r\n" +
                "2 – Mostrar no ecran apenas os produtos do armazém “Setúbal” \r\n" +
                "3 – Mostrar no ecran apenas os produtos com preço final superior a 1000€  \r\n" +
                "4 – Mostrar no ecran apenas os produtos do Armazém do “Porto” e que sejam “ATI Radeon” \r\n" +
                "5 – Mostrar no ecran o total da soma de todos os preços finais \r\n" +
                "6 – Mostrar no ecran a média geral das quantidades de produtos \r\n" +
                "7 – Gerar um ficheiro “Faro.txt” que deverá conter todos os produtos do armazém de “Faro” \r\n" +
                "8 – Gerar um ficheiro “Monitores.txt” que deverá conter todos “Monitor …”\r\n" +
                "9 - Gerar um ficheiro “Portateis_ASUS.txt” \r\n" +
                "10 - Gerar um ficheiro “Preco_ordenado.txt \r\n" +
                "11 - Permitir ao utilizador inserir uma linha no ficheiro “chip7” \r\n" +
                "12 - Criar um ficheiro designado “encomendar_a_fornecedor.txt” \r\n" +
                "13 - Sair \r\n" +
                "Opção: ");
            int.TryParse(Console.ReadLine(), out int opt);
            if (opt > 0 && opt <= 13) Options(opt);
            else Menu();
        }
        public static void Options(int opt)
        {
            switch (opt)
            {
                case 1 : ShowAll(); break;
                case 2 : ProdutosSetubal(); break;
            }
            Console.Read();
            Menu();
        }
        public static void ShowAll()
        {
            Console.Clear();
            foreach (var prod in produtos)
            {
                Console.WriteLine($"{prod.produto} | {prod.preco} || {prod.stock} ||| {prod.loja}");
            }
        }
        public static void ProdutosSetubal()
        {
            Console.Clear();
            foreach (var prod in produtos.Where(prod => prod.loja == "Setúbal"))
            {
                Console.WriteLine($"{prod.produto} | {prod.preco} || {prod.stock} ||| {prod.loja}");
            }
        }
    }
    public struct Produto
    {
        public string produto;
        public int preco;
        public int stock;
        public string loja;
    }
}