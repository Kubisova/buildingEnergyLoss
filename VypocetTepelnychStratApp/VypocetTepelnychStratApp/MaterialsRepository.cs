using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VypocetTepelnychStratApp
{
    public class MaterialsRepository : IMaterialsRepository
    {
        private List<Material> _materials = new List<Material>()
            {
                new Material("betón", 1.3),
                new Material("omietka", 0.15),
                new Material("sadrokartón", 0.22),
                new Material("ytong", 0.09)
            };

        public List<Material> GetMaterials()
        {
            return _materials;
        }

        public Material CreateMaterial(string name, double thickness )
        {
            Material material = null;
            foreach (var mat in _materials)
            {
                if( name == mat.Name)
                {
                    material = new Material(mat.Name, mat.Lambda, thickness);
                    break;
                }
                
            }
            return material;
        }
    }
}
