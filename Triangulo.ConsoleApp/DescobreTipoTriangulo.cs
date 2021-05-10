using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangulo.ConsoleApp
{
    class DescobreTipoTriangulo
    {
        public void Calcula()
        {
            double a, b, c;
            Console.Write("Digite o valor X: ");
            a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o valor Y: ");
            b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o valor Z: ");
            c = Convert.ToDouble(Console.ReadLine());

            Triangulo triangulo = new Triangulo(a, b, c);

            if (triangulo.X + triangulo.Y < triangulo.Z || triangulo.X + triangulo.Z < triangulo.Y || triangulo.Y + triangulo.Z < triangulo.X)
            {
                triangulo.TipoTriangulo = "Triângulo inválido";
                Console.WriteLine(triangulo.TipoTriangulo);
            }else if (triangulo.X == triangulo.Y && triangulo.Y == triangulo.Z)
            {
                triangulo.TipoTriangulo = "É um eqüilátero";
                Console.WriteLine(triangulo.TipoTriangulo);
            }
            else if (triangulo.X != triangulo.Y && triangulo.Y != triangulo.Z && triangulo.X != triangulo.Z)
            {
                triangulo.TipoTriangulo = "É um escaleno";
                Console.WriteLine(triangulo.TipoTriangulo);
            }else if (triangulo.X == triangulo.Y || triangulo.Y == triangulo.Z || triangulo.X != triangulo.Z)
            {
                triangulo.TipoTriangulo = "É um isósceles";
                Console.WriteLine(triangulo.TipoTriangulo);
            }
        }
    }
}
