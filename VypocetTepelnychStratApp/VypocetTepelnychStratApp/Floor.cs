using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VypocetTepelnychStratApp
{
    public class Floor : Surface
    {
        public Floor (double dimension1, double dimension2, List<Material> sandwichConstruction) : base (dimension1,dimension2, sandwichConstruction)
        {
            Dimension1 = dimension1;
            Dimension2 = dimension2;
            SandwichConstruction = sandwichConstruction;
        }
    }
}
