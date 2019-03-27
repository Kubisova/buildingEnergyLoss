using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VypocetTepelnychStratApp
{
    class Calculator
    {
        private Building _building; 
        

        public double CalculateLosses(Building building)
        {
            _building = building;
            double lossFloor = CalculateLossForFloor(building.Floor);
            double lossWalls = CalculateLossForSurface(building.Walls);
            double lossRoof = CalculateLossForSurface(building.Roof);
            double loss = lossFloor + lossRoof + 4 * lossWalls;
            return loss;
        }

        public double CalculateLossForSurface(Surface surface)
        {
            int deltaT = _building.InnerTemperature - _building.MinOuterTemperature;
            double u = CalculateUForSandwichConstruction(surface);
            double surfaceLoss = u * surface.Area() * deltaT;
            return surfaceLoss;
        }

        public double CalculateLossForFloor(Floor floor)
        {
            int deltaTForFloor = _building.InnerTemperature - Building.OuterTemperatureForFloor;
            double u = CalculateUForSandwichConstruction(floor);
            double floorLoss = u * floor.Area() * deltaTForFloor;
            return floorLoss;
        }

        public double CalculateUForSandwichConstruction(Surface surface)
        {
            double r = 0;
            for (int i = 0; i < surface.SandwichConstruction.Count; i++)
            {
                r += surface.SandwichConstruction[i].Thickness / surface.SandwichConstruction[i].Lambda;
            }
            double u = 1 / r;
            return u;
        }


    }
}
