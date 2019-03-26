using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VypocetTepelnychStratApp
{
    class Calculator
    {
        int _deltaT;
        int _deltaTForFloor;

        public double CalculateLosses(Building building)
        {
            _deltaT = CalculateDeltaT(building);
            _deltaTForFloor = CalculateDeltaTForFloor(building);
            double lossFloor = CalculateLossForSurface(building.Floor);
            double lossWalls = CalculateLossForSurface(building.Walls);
            double lossRoof = CalculateLossForSurface(building.Roof);
            double loss = lossFloor + lossRoof + 4 * lossWalls;
            return loss;
        }

        public double CalculateLossForSurface(Surface surface)
        {
            double u = CalculateUForSandwichConstruction(surface);
            double surfaceLoss = u * surface.Area() *_deltaT;
            return surfaceLoss;
        }

        public double CalculateLossForFloor(Floor floor)
        {
            double u = CalculateUForSandwichConstruction(floor);
            double floorLoss = u * floor.Area() * _deltaTForFloor;
            return floorLoss;
        }

        public double CalculateUForSandwichConstruction(Surface surface)
        {
            double r = 0;
            for (int i = 0; i < surface.SandwichConstruction.Count; i++)
            {
                r += surface.SandwichConstruction[i].Size / surface.SandwichConstruction[i].Lambda;
            }
            double u = 1 / r;
            return u;
        }

        public int CalculateDeltaT(Building building)
        {
            return building.InnerTemperature - building.MinOuterTemperature;
        }

        public int CalculateDeltaTForFloor(Building building)
        {
            return building.InnerTemperature - Building.OuterTemperatureForFloor;
        }
    }
}
