using System;
using System.Collections.Generic;
using System.Text;
using Pokebattle.Classes.GameLogic;

namespace Pokebattle.Classes.Pokemons
{
    class Charmeleon:Pokemon
    {
        // Construct Charmeleon
        public Charmeleon(string name = "Charmeleon")
        {
            this.name = name;
            this.energyType = new EnergyType(EnergyType.energyName.Fire);
            this.hitpoints = 60f;
            this.attacks = CreateAttackList();
            this.weakness = new Weakness(new EnergyType(EnergyType.energyName.Water), 2f);
            this.resistance = new Resistance(new EnergyType(EnergyType.energyName.Lightning), 10f);
            this.health = hitpoints;
        }

        // Add attacks to the list
        private List<Attack> CreateAttackList()
        {
            // create list
            List<Attack> Alist = new List<Attack>();

            // add the attacks with their name, energytype and damage
            Alist.Add(new Attack("Flare", this.energyType, 30f));
            Alist.Add(new Attack("Head Butt", new EnergyType(EnergyType.energyName.Fighting), 10f));

            return Alist;
        }
    }
}
