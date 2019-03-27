using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VypocetTepelnychStratApp
{
    class Building
    {
        public Floor Floor { get; set; }
        public Walls Walls { get; set; }
        public Roof Roof { get; set; }

        public int MinOuterTemperature { get; set; }
        public int InnerTemperature { get; set; }
        public const int OuterTemperatureForFloor = 3;

        public Building(Floor floor, Walls walls, Roof roof, int minOuterTemp, int innerTemp)
        {
            Floor = floor;
            Walls = walls;
            Roof = roof;
            MinOuterTemperature = minOuterTemp;
            InnerTemperature = innerTemp;
        }
    }
}
