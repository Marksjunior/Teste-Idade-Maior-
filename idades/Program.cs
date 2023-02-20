﻿using System;
using System.Globalization;

namespace idades
{
    class IdadeMedia
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            string nome1, nome2, nome3;
            int idade1, idade2, idade3;
            double media;

            Console.WriteLine("Dados da primeira pessoa:");
            Console.Write("Nome: ");
            nome1 = Console.ReadLine();
            Console.Write("Idade: ");
            idade1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da segunda pessoa:");
            Console.Write("Nome: ");
            nome2 = Console.ReadLine();
            Console.Write("Idade: ");
            idade2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da segunda pessoa:");
            Console.Write("Nome: ");
            nome3 = Console.ReadLine();
            Console.Write("Idade: ");
            idade3 = int.Parse(Console.ReadLine());


            media = (idade1 + idade2 + idade3) / 2.0;

            Console.WriteLine("A idade media de " + nome1 + " e " + nome2 + " eh de " + media.ToString("F2", CI) + " anos");
        }
    }
}
