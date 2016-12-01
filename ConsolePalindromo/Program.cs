using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Business;
using Entities;

namespace ConsolePalindromo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> palabras = new List<string>();
            string palabra = string.Empty;

            FileInfo file = new FileInfo(@"c:\test.txt");

            if (!file.Exists)
            {
                Console.WriteLine(@"Por favor agregue el archivo test.txt en 'c:\' y ejecute de nuevo la aplicación");
                Console.ReadKey();
                return;
            }

            StreamReader archivo = new StreamReader(file.FullName);

            while ((palabra=archivo.ReadLine()) != null)
            {
                palabras.Add(palabra);
            }

            BPalindromo buss = new BPalindromo();

            var palindromos = buss.ValidarPalindromos(palabras);

            foreach (Palindromo palindromo in palindromos)
            {
                Console.WriteLine($"{palindromo.Palabra}: {palindromo.EsPalindromo}");
            }
            Console.ReadKey();
        }
    }
}
