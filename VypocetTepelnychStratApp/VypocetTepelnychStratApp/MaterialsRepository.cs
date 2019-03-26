using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VypocetTepelnychStratApp
{
    class MaterialsRepository : IMaterialsRepository
    {
        public List<Material> GetMaterials()
        {
            List<Material> materials = new List<Material>();
            materials.Add(new Material("betón", 1.3));
            materials.Add(new Material("omietka", 0.15));
            materials.Add(new Material("sadrokartón", 0.22));
            materials.Add(new Material("ytong", 0.9));

            return materials;
        }
    }
}
