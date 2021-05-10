using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangulo.ConsoleApp
{
    class Triangulo
    {
        private double x, y, z;
        private string tipoTriangulo = "";
        public Triangulo(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public double X { get => x; set => x = value; }
        public double Y { get => y; set => y = value; }
        public double Z { get => z; set => z = value; }
        public string TipoTriangulo { get => tipoTriangulo; set => tipoTriangulo = value; }
    }
}
