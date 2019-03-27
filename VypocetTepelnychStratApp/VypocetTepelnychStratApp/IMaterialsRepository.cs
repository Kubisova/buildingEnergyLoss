using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VypocetTepelnychStratApp
{
    interface IMaterialsRepository
    {
        List<Material> GetMaterials();
        Material CreateMaterial(string name, double thickness);
    }
}
