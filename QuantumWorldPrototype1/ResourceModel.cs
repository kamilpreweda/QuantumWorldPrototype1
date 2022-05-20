using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace QuantumWorldPrototype1
{
    public class ResourceModel
    {
        public string Name;
        public int StartingValue;
        public static int Value;

        public static int ResourceCalculate(int upgradeCost, int availibleResource, out int resourceValueCalculated)
        {
            resourceValueCalculated = 0;

            if (upgradeCost > availibleResource)
            {
                MessageBox.Show("Not enough resources!");
                return 0;
            }
            else
            {
                resourceValueCalculated = availibleResource - upgradeCost;
                return resourceValueCalculated;
            }
        }

        
    }
}
