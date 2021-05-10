using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangulo.ConsoleApp
{
    class PedirLados
    {

        public void PedeLados()
        {
            DescobreTipoTriangulo tipo = new DescobreTipoTriangulo();
            while (true)
            {
                double a, b, c;
                Console.Write("Digite o valor X: ");
                a = Convert.ToDouble(Console.ReadLine());

                Console.Write("Digite o valor Y: ");
                b = Convert.ToDouble(Console.ReadLine());

                Console.Write("Digite o valor Z: ");
                c = Convert.ToDouble(Console.ReadLine());

                

                Triangulo triangulo = new Triangulo(a, b, c);
                Console.WriteLine(tipo.RetornaTipo(triangulo));

                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}


