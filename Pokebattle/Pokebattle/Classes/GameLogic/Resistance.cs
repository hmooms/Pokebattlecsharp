using System;
using System.Collections.Generic;
using System.Text;

namespace Pokebattle.Classes.GameLogic
{
    class Resistance
    {
        public EnergyType energyType;
        private float value;

        // Constructor
        public Resistance(EnergyType energyType, float value)
        {
            this.energyType = energyType;
            this.value = value;
        }

        // Take damage of the attack and take off the value
        public float CalculateDamage(float attack)
        {
            return attack - value;
        }
    }
}
