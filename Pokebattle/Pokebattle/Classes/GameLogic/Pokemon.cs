using System;
using System.Collections.Generic;
using System.Text;

namespace Pokebattle.Classes.GameLogic
{
    class Pokemon
    {
        public string name;
        protected EnergyType energyType;
        protected float hitpoints;
        protected float health;
        public List<Attack> attacks;
        protected Weakness weakness;
        protected Resistance resistance;

        /* when this pokemon uses an attack print:
         * pokemon used .... !
         */
        public string Attack(Attack attack, Pokemon target)
        {
            return this.name + " used " + attack.name + " ! \r\n" + target.Attacked(attack);
        }

        /* When this pokemon gets attacked by pokemon
         * compare Energytype to weakness and resistance 
         * calculate damage
         * print either: it's very effective or it's not very effective or nothing
         * print: this pokemon took ... damage!
         * remove damage from health
         */
        public string Attacked(Attack attack)
        {
            string text = this.name + " has " + this.health + "hp.\r\n";
            float damage;

            if (attack.energyType.name == this.weakness.energyType.name)
            {
                damage = this.weakness.CalculateDamage(attack.damage);
                text += "It's very effective!\r\n";
            }
            else if (attack.energyType.name == this.resistance.energyType.name)
            {
                damage = this.resistance.CalculateDamage(attack.damage);
                text += "it's not very effective!\r\n";
            }
            else
            {
                damage = attack.damage;
            }

            text += this.name + " took " + damage + " damage!\r\n";

            this.health -= damage;

            text += this.name + " has " + this.health + "hp remaining.\r\n";
            return text;
        }
    }
}
