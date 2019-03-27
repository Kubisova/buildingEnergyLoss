using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VypocetTepelnychStratApp
{
    public class FrmMainModel
    {
        public string Name { get; set; }
        public string NameAndSurname { get; set; }

        public double Width { get; set; }
        public double Length { get; set; }
        public double Height { get; set; }

        public int MinOuterTemperature { get; set; }
        public int InnerTemperature { get; set; }

        public List<string> Surface { get; set; }
        public List<string> MaterialNames { get; set; }
        public List<double> MaterialThickness { get; set; }

        public FrmMainModel()
        {
            Surface = new List<string>();
            MaterialNames = new List<string>();
            MaterialThickness = new List<double>();
        }

        public double Calculate()
        {
            Floor floor = new Floor(Width, Length, CreateSandwichConstructionForFloor(Surface, MaterialNames, MaterialThickness));
            Walls walls = new Walls(Length, Height, CreateSandwichConstructionForWall(Surface, MaterialNames, MaterialThickness));
            Roof roof = new Roof(Length, Width, CreateSandwichConstructionForRoof(Surface, MaterialNames, MaterialThickness));

            Building building = new Building(floor, walls, roof, MinOuterTemperature, InnerTemperature);

            Calculator calculator = new Calculator();
            return calculator.CalculateLosses(building);
        }

        private List<Material> CreateSandwichConstructionForFloor(List<string> surface, List<string> materialNames, List<double> materialThickness)
        {
            List < Material> SandwichConstructionForFloor = new List<Material>();
            IMaterialsRepository materials = new MaterialsRepository();
            for (int i = 0; i < surface.Count; i++)
            {
                if (surface[i]== "Floor")
                {
                    SandwichConstructionForFloor.Add(materials.CreateMaterial(materialNames[i], materialThickness[i]));
                }
            }
            return SandwichConstructionForFloor;
        }

        private List<Material> CreateSandwichConstructionForWall(List<string> surface, List<string> materialNames, List<double> materialThickness)
        {
            List<Material> SandwichConstructionForWall = new List<Material>();
            IMaterialsRepository materials = new MaterialsRepository();
            for (int i = 0; i < surface.Count; i++)
            {
                if (surface[i] == "Wall")
                {
                    SandwichConstructionForWall.Add(materials.CreateMaterial(materialNames[i], materialThickness[i]));
                }
            }
            return SandwichConstructionForWall;
        }

        private List<Material> CreateSandwichConstructionForRoof(List<string> surface, List<string> materialNames, List<double> materialThickness)
        {
            List<Material> SandwichConstructionForRoof = new List<Material>();
            IMaterialsRepository materials = new MaterialsRepository();
            for (int i = 0; i < surface.Count; i++)
            {
                if (surface[i] == "Roof")
                {
                    SandwichConstructionForRoof.Add(materials.CreateMaterial(materialNames[i], materialThickness[i]));
                }
            }
            return SandwichConstructionForRoof;
        }
    }
}
