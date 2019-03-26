using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VypocetTepelnychStratApp
{
    interface ISurface
    {
        double Dimension1 { get; set; }
        double Dimension2 { get; set; }

        List<Material> SandwichConstruction { get; set; }

        double Area();
    }
}
