﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace hash01
{

    class Program
    {
        static void Main(string[] args)
        {
            String textIn = null;
            Console.Write("Entra text: ");
            while (textIn == null)
                textIn = Console.ReadLine();

            // Convertim l'string a un array de bytes
            byte[] bytesIn = Encoding.UTF8.GetBytes(textIn);
            // Instanciar classe per fer hash
            // fent servir using ja es delimita el seu àmbit i no cal fer dispose
            using (SHA512Managed SHA512 = new SHA512Managed())
            {
                // Calcular hash
                byte[] hashResult = SHA512.ComputeHash(bytesIn);

                // Si volem mostrar el hash per pantalla o guardar-lo en un arxiu de text
                // cal convertir-lo a un string

                String textOut = BitConverter.ToString(hashResult).Replace("-", string.Empty);
                Console.WriteLine("Hash del text{0}", textIn);
                Console.WriteLine(textOut);
                Console.ReadKey();


            }
        }
    }
}