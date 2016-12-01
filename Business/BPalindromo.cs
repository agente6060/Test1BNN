using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class BPalindromo
    {
        /// <summary>
        /// Valida si la palabra es palindromo o no
        /// </summary>
        /// <param name="palabra">Cadena a validar si es palindromo</param>
        /// <returns>Indica si es palindromo la palabra</returns>
        internal bool EsPalindromo(string palabra)
        {
            string palabraTemp = string.Empty;
            int lonPalabra = palabra.Length;

            try
            {
                for (int i = lonPalabra - 1; i >= 0; i--)
                {
                    palabraTemp = palabraTemp + palabra.Substring(i, 1);
                }
                return palabra == palabraTemp;
            }
            catch
            {
                return false;
            }
        }

        public List<Palindromo> ValidarPalindromos(List<String> palabras)
        {
            List<Palindromo> result = new List<Palindromo>();

            foreach (string palabra in palabras)
            {
                if (!string.IsNullOrWhiteSpace(palabra))
                { 
                    result.Add(new Palindromo { Palabra= palabra, EsPalindromo = EsPalindromo(palabra) });
                }
            }
            return result;
        }
    }
}
