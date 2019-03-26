using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VypocetTepelnychStratApp
{
    class Material
    {
        public string Name { get; set; }
        public double Lambda { get; set; }
        public int Size { get; set; }

        public Material (string name, double lambda)
        {
            Name = name;
            Lambda = lambda;
        }
    }
}
