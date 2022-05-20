using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuantumWorldPrototype1
{
    public class BuildingModel
    {
        public string Name;
        public string Description;
        public int Level = 0;
        public int upgradeCost;
        public int costMultiplier = 2;

        public static int IncreaseCost(int upgradeCost, int costMultiplier, out int nextCost)
        {
            nextCost = upgradeCost * costMultiplier;
            return nextCost;


        }

        public static int IncreaseLevel(int level, out int nextLevel)
        {
            nextLevel = level + 1;
            return nextLevel;
        }

    }
}
