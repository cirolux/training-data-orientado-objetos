using System;

namespace ExpressoesAritmeticas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro número: ");
            double numero1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            double numero2 = double.Parse(Console.ReadLine());

            double soma = numero1 + numero2;
            double subtracao = numero1 - numero2;
            double multiplicacao = numero1 * numero2;

            double divisao = 0;
            
            if (numero1 > 0)
            {
                divisao = numero1 / numero2;

            } else
            {
                Console.WriteLine("Número preca ser maior que zero");
            }

            double resto = 0; 

            if (numero1 > 0)
            {
                resto = numero1 % numero2;
            }
            else
            {
                Console.WriteLine("Número preca ser maior que zero");
            }
            

            Console.WriteLine($"O resultado da soma entre  {numero1} e {numero2} é {soma}");
            Console.WriteLine($"O resultado da subtração entre  {numero1} e {numero2} é {subtracao}");
            Console.WriteLine($"O resultado da multiplicação entre  {numero1} e {numero2} é {multiplicacao}");
            Console.WriteLine($"O resultado da divisão entre  {numero1} e {numero2} é {divisao}");
            Console.WriteLine($"O resto da divisão entre  {numero1} e {numero2} é {resto}");

            Console.WriteLine("\nDigite um número para separar em centenas, dezenas e unidades: ");
            int numeroInt = int.Parse(Console.ReadLine());

            int somar = 0;

            int unidade = numeroInt % 10;
            somar += unidade;

            int dezena = numeroInt / 10 % 10;
            somar += dezena;

            int centena = numeroInt /100 % 10;

            Console.WriteLine($"Centena: {centena}, dezena: {dezena}, unidade: {unidade}");
        }
    }
}
