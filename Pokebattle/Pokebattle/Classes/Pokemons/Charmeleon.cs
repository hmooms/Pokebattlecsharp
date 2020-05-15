using System;
using System.Collections.Generic;
using System.Text;
using Pokebattle.Classes.GameLogic;

namespace Pokebattle.Classes.Pokemons
{
    class Charmeleon:Pokemon
    {
        // Construct Charmeleon
        public Charmeleon(string name = "Charmeleon") : base(name, new EnergyType(EnergyType.energyName.Fire), 60f, new Weakness(new EnergyType(EnergyType.energyName.Water), 2f), new Resistance(new EnergyType(EnergyType.energyName.Lightning), 10f))
        {
            this.attacks = CreateAttackList();
        }

        // Add attacks to the list
        protected override List<Attack> CreateAttackList()
        {
            // create list
            List<Attack> Alist = new List<Attack>();

            // add the attacks with their name, energytype and damage
            Alist.Add(new Attack("Flare", new EnergyType(EnergyType.energyName.Fire), 30f));
            Alist.Add(new Attack("Head Butt", new EnergyType(EnergyType.energyName.Fighting), 10f));

            return Alist;
        }
    }
}
