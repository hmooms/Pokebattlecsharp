using System;
using System.Collections.Generic;
using System.Text;
using Pokebattle.Classes.GameLogic;

namespace Pokebattle.Classes.Pokemons
{
    class Pikachu:Pokemon
    {
        // Construct the Pikachu
        public Pikachu(string name = "Pikachu")
        {
            this.name = name;
            this.energyType = new EnergyType(EnergyType.energyName.Lightning);
            this.hitpoints = 60f;
            this.attacks = CreateAttackList();
            this.weakness = new Weakness(new EnergyType(EnergyType.energyName.Fire), 1.5f);
            this.resistance = new Resistance(new EnergyType(EnergyType.energyName.Fighting), 20f);
            this.health = hitpoints;
        }


        // Add attacks to the list
        private List<Attack> CreateAttackList()
        {
            // create list
            List<Attack> Alist = new List<Attack>();

            // add the attacks with their name, energytype and damage
            Alist.Add(new Attack("Electric Ring", this.energyType, 50f));
            Alist.Add(new Attack("Pika Punch", new EnergyType(EnergyType.energyName.Fighting), 20f));

            return Alist;
        }
    }
}
