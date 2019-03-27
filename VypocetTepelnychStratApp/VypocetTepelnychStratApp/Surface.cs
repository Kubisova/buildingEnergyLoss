using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VypocetTepelnychStratApp
{
    public class Surface : ISurface
    {
        public double Dimension1 { get; set; }
        public double Dimension2 { get; set; }

        public List<Material> SandwichConstruction { get; set; }

        public Surface(double dimension1, double dimension2, List<Material> sandwichConstruction)
        {
            Dimension1 = dimension1;
            Dimension2 = dimension2;

            SandwichConstruction = sandwichConstruction;
        }

        public double Area()
        {
            return Dimension1 * Dimension2;
        }
            
    }
}
