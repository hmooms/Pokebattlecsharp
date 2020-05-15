using System;
using System.Collections.Generic;
using System.Text;
using Pokebattle.Classes.GameLogic;

namespace Pokebattle.Classes.Pokemons
{
    class Pikachu:Pokemon
    {
        // Construct the Pikachu
        public Pikachu(string name = "Pikachu") : base(name, new EnergyType(EnergyType.energyName.Lightning), 60f, new Weakness(new EnergyType(EnergyType.energyName.Fire), 1.5f), new Resistance(new EnergyType(EnergyType.energyName.Fighting), 20f))
        {
            this.attacks = CreateAttackList();
        }


        // Add attacks to the list
        protected override List<Attack> CreateAttackList()
        {
            // create list
            List<Attack> Alist = new List<Attack>();

            // add the attacks with their name, energytype and damage
            Alist.Add(new Attack("Electric Ring", new EnergyType(EnergyType.energyName.Lightning), 50f));
            Alist.Add(new Attack("Pika Punch", new EnergyType(EnergyType.energyName.Fighting), 20f));

            return Alist;
        }
    }
}
