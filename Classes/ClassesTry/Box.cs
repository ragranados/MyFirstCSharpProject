using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.ClassesTry
{
    internal class Box
    {
        private double _length, _height, _depth;

        //propiedades
        public double Length { get => _length; set => _length = ValMin(value); }

        public double Height
        {
            get => _height;
            set
            {
                _height = ValMin(value);
            }
        }

        public double Depth
        {
            get => _depth;
            set
            {
                _depth = ValMin(value);
            }
        }

        //Para que tambien se aplique el "filtro" de las propiedades, se debe usar adentro del contructor, tambien las propiedades
        public Box(double length, double height, double depth)
        {
            Length = length;
            Height = height;
            Depth = depth;
        }

        public override string ToString()
        {
            return $"Largo: {_length}, Ancho: {_height}, Profundidad: {_depth}";
        }

        private double ValMin(double num)
        {
            return num < 1 ? 1 : num;
        }
    }
}
