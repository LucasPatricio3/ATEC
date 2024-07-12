using System;
using System.Collections.Generic;
using System.IO;

namespace MyApp
{
    internal class Program
    {
        public static StreamReader softwareFile = new StreamReader(@"C:\Users\silva\Documents\GitHub\ATEC\.NET\files\software.txt");
        static List<Software> softwares = new List<Software>();
        static void Main(string[] args)
        {
            softwares = FileToProduct(softwareFile);
            Menu();
        }
        static List<Software> FileToProduct(StreamReader reader)
        {
            List<Software> softwares = new List<Software>();
            string? line;
            while ((line = softwareFile.ReadLine()) != null)
            {
                Software software = new Software();
                software.software = line.Substring(0, line.IndexOf("&"));
                string remainLine = line.Substring(line.IndexOf("&") + 1,  line.Length - line.IndexOf("&") - 1);
                software.empresa = remainLine.Substring(0, remainLine.IndexOf("&"));
                remainLine = remainLine.Substring(remainLine.IndexOf("&") + 1, remainLine.Length - remainLine.IndexOf("&") - 1);
                software.anoAquisicao = int.Parse(remainLine.Substring(0, remainLine.IndexOf("&")));
                remainLine = remainLine.Substring(remainLine.IndexOf("&") + 1, remainLine.Length - remainLine.IndexOf("&") - 1);
                software.quantidade = int.Parse(remainLine);
                softwares.Add(software);
            }
            return softwares;
        }
        public static void Menu()
        {
            Console.Clear();
            Console.Write(
                "1 – Mostrar no ecran o conteúdo de todo o ficheiro \r\n" +
                "2 – Mostrar no ecran apenas os softwares da “Microsoft” \r\n" +
                "3 – Mostrar no ecran apenas os softwares com quantidade superior a 25  \r\n" +
                "4 – Perguntar ao utilizador qual o ano de aquisição mostrar só os produtos desse ano \r\n" +
                "5 – Mostrar no ecran o total da soma de todas as quantidades \r\n" +
                "6 – Mostrar no ecran todos os softwares, ordenando de forma descendente pela quantidade\r\n" +
                "7 – Gerar um ficheiro “Symantec.txt” que deverá conter todos os softwares da “Symantec” \r\n" +
                "8 – Mostrar no ecran todos os produtos adquiridos há mais de 5 anos (calcular em função da data do sistema)\r\n" +
                "9 - Sair\r\n" +
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
                case 2:
                    ShowMicrosoft();
                    break;
                case 3:
                    ShowQuantity25Plus();
                    break;
                case 4:
                    ShowAskedYear();
                    break;
                case 5:
                    ShowSumQuantity();
                    break;
                case 6:
                    ShowAllByQuantityOrder();
                    break;
                case 7:
                    CreateSymantecFile();
                    break;
                //case 8:

            }
        }
        public static void ShowAll()
        {
            Console.Clear();
            Console.WriteLine("SOFTWARE - EMPRESA - ANO DE AQUISIÇÃO - QUANTIDADE:");
            foreach (var item in softwares)
            {
                Console.WriteLine($"{item.software} - {item.empresa} - {item.anoAquisicao} - {item.quantidade}");
            }
            Console.Read();
            Menu();
        }
        public static void ShowMicrosoft()
        {
            Console.Clear();
            Console.WriteLine("SOFTWARE - MICROSOFT - ANO DE AQUISIÇÃO - QUANTIDADE:");
            foreach (var item in softwares.Where(software => software.empresa == "Microsoft"))
            {
                Console.WriteLine($"{item.software} - {item.empresa} - {item.anoAquisicao} - {item.quantidade}");
            }
            Console.Read();
            Menu();
        }
        public static void ShowQuantity25Plus()
        {
            Console.Clear();
            Console.WriteLine("SOFTWARE - EMPRESA - ANO DE AQUISIÇÃO - QUANTIDADE(>25):");
            foreach (var item in softwares.Where(software => software.quantidade > 25))
            {
                Console.WriteLine($"{item.software} - {item.empresa} - {item.anoAquisicao} - {item.quantidade}");
            }
            Console.Read();
            Menu();
        }
        public static void ShowAskedYear()
        {
            Console.Clear();
            Console.Write("Qual é o ano de aquisição do Software que procura?: ");
            int year;
            if (int.TryParse(Console.ReadLine(), out year))
            {
                Console.WriteLine($"SOFTWARE - EMPRESA - ANO DE AQUISIÇÃO({year}) - QUANTIDADE:");
                foreach (var item in softwares.Where(software => software.anoAquisicao == year))
                {
                    Console.WriteLine($"{item.software} - {item.empresa} - {item.anoAquisicao} - {item.quantidade}");
                }
                Console.Read();
                Menu();
            }
            else Console.WriteLine("Introduza um número válido!");
            Console.Read();
            ShowAskedYear();
        }
        public static void ShowSumQuantity()
        {
            Console.Clear();
            Console.WriteLine("QUANTIDADE TOTAL:");
            Console.WriteLine($"{softwares.Sum(software => software.quantidade)}");
            Console.Read();
            Menu();
        }
        public static void ShowAllByQuantityOrder()
        {
            Console.Clear();
            Console.WriteLine("SOFTWARE - EMPRESA - ANO DE AQUISIÇÃO - QUANTIDADE:");
            foreach (var item in softwares.OrderByDescending(software => software.quantidade))
            {
                Console.WriteLine($"{item.software} - {item.empresa} - {item.anoAquisicao} - {item.quantidade}");
            }
            Console.Read();
            Menu();
        }
        public static void CreateSymantecFile()
        {
            Console.Clear();
            StreamWriter streamWriter = new StreamWriter(@"C:\Users\silva\Documents\GitHub\ATEC\.NET\files\Symantec.txt");
            foreach (var item in softwares.Where(software => software.empresa == "Symantec"))
            {
                streamWriter.WriteLine($"{item.software}&{item.empresa}&{item.anoAquisicao}&{item.quantidade}");
            }
            Console.WriteLine("Ficheiro Criado!");
            streamWriter.Close();
            Console.Read();
            Menu();
        }
    }
    public struct Software
    {
        public string software;
        public string empresa;
        public int anoAquisicao;
        public int quantidade;
    }
}