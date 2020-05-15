using System;
using System.Collections.Generic;
using System.Text;

namespace Pokebattle.Classes.GameLogic
{
    class Attack
    {
        private string name;
        public EnergyType energyType;
        public float damage;

        public string Name { get => name; }

        // Constructor
        public Attack(string name, EnergyType energyType, float damage)
        {
            this.name = name;
            this.energyType = energyType;
            this.damage = damage;
        }
    }
}
