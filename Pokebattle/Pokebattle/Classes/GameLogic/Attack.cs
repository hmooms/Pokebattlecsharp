using System;
using System.Collections.Generic;
using System.Text;

namespace Pokebattle.Classes.GameLogic
{
    class Attack
    {
        public string name;
        public EnergyType energyType;
        public float damage;

        // Constructor
        public Attack(string name, EnergyType energyType, float damage)
        {
            this.name = name;
            this.energyType = energyType;
            this.damage = damage;
        }
    }
}
