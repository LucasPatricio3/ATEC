using System;
using System.IO;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileInfo file = new FileInfo(@"C:\Users\silva\Desktop\euromilhoes.txt");
            StreamWriter writer = file.CreateText();
            string numberWinner = $"{NumGen(false)} {NumGen(false)} {NumGen(false)} {NumGen(false)} {NumGen(false)}|{NumGen(true)}* {NumGen(true)}*";
            writer.WriteLine(numberWinner);
            writer.Close();
            Environment.Exit(0);
        }
        public static int NumGen(bool isStar)
        {
            Random rnd = new Random();
            int maxValue = isStar ? 12 : 50;
            return rnd.Next(1, maxValue);
        }
    }
}