using System;

namespace TipoDeCombustivelURI1134
{
    class Program
    {
        static void Main(string[] args)
        {
            int codigo;
            int contagemAlcool = 0;
            int contagemGasolina = 0;
            int contagemDiesel = 0;

            //Faz a leitura inicial do codigo inserido pelo usuario
            codigo = int.Parse(Console.ReadLine());

            //Repete a operacao, ate que seja digitado o valor de numero 4 para encerrar a operacao
            while (codigo != 4)
            {
                if (codigo == 1)
                {
                    contagemAlcool = contagemAlcool + 1;
                }

                if (codigo == 2)
                {
                    contagemGasolina = contagemGasolina + 1;
                }

                if (codigo == 3)
                {
                    contagemDiesel = contagemDiesel + 1;
                }                
                
                //Faz uma nova leitura caso o usuario insira um numero incorreto
                codigo = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine("Alcool: " + contagemAlcool);
            Console.WriteLine("Gasolina: " + contagemGasolina);
            Console.WriteLine("Diesel: " + contagemDiesel);

        }
    }
}
