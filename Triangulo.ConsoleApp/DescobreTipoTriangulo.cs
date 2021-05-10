using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangulo.ConsoleApp
{
    class DescobreTipoTriangulo
    {
        public string RetornaTipo(Triangulo triangulo)
        {
            if (triangulo.X + triangulo.Y < triangulo.Z || triangulo.X + triangulo.Z < triangulo.Y || triangulo.Y + triangulo.Z < triangulo.X)
            {
                triangulo.TipoTriangulo = "Triângulo inválido";
            }
            else if (triangulo.X == triangulo.Y && triangulo.Y == triangulo.Z)
            {
                triangulo.TipoTriangulo = "É um eqüilátero";
            }
            else if (triangulo.X != triangulo.Y && triangulo.Y != triangulo.Z && triangulo.X != triangulo.Z)
            {
                triangulo.TipoTriangulo = "É um escaleno";
            }
            else
            {
                triangulo.TipoTriangulo = "É um isósceles";
            }
            return triangulo.TipoTriangulo;
        }

    }
}
