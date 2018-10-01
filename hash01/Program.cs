using System;
using System.Security.Cryptography;
using System.Text;

namespace hash01
{

    class Program
    {
        static void Main(string[] args)
        {
            var textIn = "";
            while (string.IsNullOrEmpty(textIn))
            {
                Console.Clear();
                Console.Write("Entra text: "); 
                textIn = Console.ReadLine();
            }
            // Convertim l'string a un array de bytes
            byte[] bytesIn = Encoding.UTF8.GetBytes(textIn);
            // Instanciar classe per fer hash
            using (SHA512Managed SHA512 = new SHA512Managed())
            {
                // Calcular hash
                byte[] hashResult = SHA512.ComputeHash(bytesIn);

                // Si volem mostrar el hash per pantalla o guardar-lo en un arxiu de text
                // cal convertir-lo a un string

                var textOut = BitConverter.ToString(hashResult).Replace("-", string.Empty);
                Console.WriteLine($"Hash del text {textIn}");
                Console.WriteLine(textOut);
                Console.ReadKey();

            }
        }
    }
}
