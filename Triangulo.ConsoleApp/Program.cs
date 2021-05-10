using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangulo.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            DescobreTipoTriangulo tipo = new DescobreTipoTriangulo();
            string opcao;
            Console.WriteLine("BEM VINDO");
            while (true)
            {
                Console.WriteLine("DIGITE QUALQUER LETRA EXCESSO 'S' PARA COMEÇAR, OU 'S' PARA SAIR DA APLICAÇÃO");
                opcao = Console.ReadLine();
                if (opcao != "s" && opcao != "S")
                {
                    Console.Clear();
                    tipo.Calcula();
                    Console.ReadLine();
                    Console.Clear();
                }
                else
                    break;
            }



        }
    }
}
