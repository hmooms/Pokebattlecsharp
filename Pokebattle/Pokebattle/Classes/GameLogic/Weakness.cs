using System;
using System.Collections.Generic;
using System.Text;

namespace Pokebattle.Classes.GameLogic
{
    class Weakness
    {
        public EnergyType energyType;
        private float mulitplier;

        // Constructor
        public Weakness(EnergyType energyType, float mulitplier)
        {
            this.energyType = energyType;
            this.mulitplier = mulitplier;
        }

        // Take the damage of the attack and multiply by the multiplier
        public float CalculateDamage(float attack)
        {
            return attack * mulitplier;
        }
    }
}
