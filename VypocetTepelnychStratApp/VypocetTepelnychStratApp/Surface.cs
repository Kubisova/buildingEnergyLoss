using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VypocetTepelnychStratApp
{
    class Surface : ISurface
    {
        public double Dimension1 { get; set; }
        public double Dimension2 { get; set; }

        public List<Material> SandwichConstruction { get; set; }

        public double Area()
        {
            return Dimension1 * Dimension2;
        }
            
    }
}
