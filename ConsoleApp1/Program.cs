﻿using System;
using System.Globalization;

namespace ProjectOne {
    internal class Program {
        static void Main(string[] args) {
            //bool completo = false;
            //char genero = 'F';
            //char letra = '\u0041';
            //byte n1 = 126;
            //int n2 = 1000;
            //int n3 = 2147483647;
            //long n4 = 2147483648;
            //float n5 = 4.5f;
            //double n6 = 4.5;
            //string nome = "maria green";
            //object obj1 = "alex";
            //object obj2 = 4.5f;

            //Console.WriteLine(obj1);
            //Console.WriteLine(obj2);
            //Console.WriteLine(n5);
            //Console.WriteLine(n6);
            //Console.WriteLine(completo);
            //Console.WriteLine(genero);
            //Console.WriteLine(letra);
            //Console.WriteLine(nome);
            //Console.WriteLine(n1);
            //Console.WriteLine(n2);
            //Console.WriteLine(n3);
            //Console.WriteLine(n4);

            //int n1 = int.MinValue;
            //Console.WriteLine(n1);

            //int n2 = int.MaxValue;
            //Console.WriteLine(n2);

            //sbyte n3 = sbyte.MinValue;
            //Console.WriteLine(n3);

            //decimal n4 = decimal.MaxValue;
            //Console.WriteLine(n4);

            //int idade = 19;
            //double saldo = 10.35784;
            //string nome = "Pedro";

            //Console.WriteLine("{0} tem {1} anos e tem o saldo igual a {2:F2} reais", nome, idade, saldo);
            //Console.WriteLine($"{nome} tem {idade} anos e tem o saldo igual a {saldo:F2} reais");

            //// Concatenação de strings, técnica antiga utilizada
            //Console.WriteLine(nome + "tem" + idade + "anos e tem o saldo igual a " + saldo.ToString("F2", CultureInfo.InvariantCulture) + " reais");

            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine("Produtos:");
            Console.WriteLine($"{produto1}, cujo preço é $ {preco1}");
            Console.WriteLine($"{produto2}, cujo preço é $ {preco2}");

            Console.WriteLine($"Registro: {idade} anos de idade, código {codigo} e gênero {genero}");

            Console.WriteLine($"Medida com oito casas decimais: {medida:F8}");
            Console.WriteLine($"Arredondado (três casas decimais): {medida:F3}");
            Console.WriteLine($"Separador decimal invariant culture: {medida.ToString("F3", CultureInfo.InvariantCulture)}");
        }
    }
}