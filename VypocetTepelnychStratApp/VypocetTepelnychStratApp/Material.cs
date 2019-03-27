using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VypocetTepelnychStratApp
{
    public class Material
    {
        public string Name { get; set; }
        public double Lambda { get; set; }
        public double Thickness { get; set; }

        public Material (string name, double lambda)
        {
            Name = name;
            Lambda = lambda;
        }

        public Material(string name, double lambda, double size)
        {
            Name = name;
            Lambda = lambda;
            Thickness = size;
        }
    }
}
