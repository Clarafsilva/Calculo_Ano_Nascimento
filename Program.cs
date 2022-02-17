using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculo_Ano_Nascimento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Nome;
            string Idade;


            Console.WriteLine("Calculando o seu ano de nascimento:");

            Console.Write("Escreva o seu nome: ");
            Nome = Console.ReadLine();
            Console.Write("Digite a sua idade: ");
            Idade = Console.ReadLine();

            int IdadeUsuario = int.Parse(Idade);
            int CalcularAno = DateTime.Now.Year - IdadeUsuario;
            Console.WriteLine("O ano (aproximado) do seu nascimento é: " + CalcularAno);
            Console.ReadKey();
            

            




            

        }
    }
}
