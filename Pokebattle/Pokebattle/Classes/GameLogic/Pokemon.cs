using System;
using System.Collections.Generic;
using System.Text;

namespace Pokebattle.Classes.GameLogic
{
    class Pokemon
    {
        private string name;
        private EnergyType energyType;
        private float hitpoints;
        private float health;
        public List<Attack> attacks;
        private Weakness weakness;
        private Resistance resistance;
        private bool hasFainted = false;

        public string Name { get => name; }
        public bool HasFainted { get => hasFainted; }

        public Pokemon(string name, EnergyType energyType, float hitpoints, Weakness weakness, Resistance resistance)
        {
            this.name = name;
            this.energyType = energyType;
            this.hitpoints = hitpoints;
            this.health = hitpoints;
            this.weakness = weakness;
            this.resistance = resistance;
        }



        /* when this pokemon uses an attack:
         * check if the attacking pokemon is fainted
         * if true print you cant use the attack
         * or if the enemy pokemon is fainted
         * print attack is useless
         * if both are not ture print
         * pokemon used .... !
         */
        public string Attack(Attack attack, Pokemon target)
        {
            if (this.hasFainted)
            {
                return this.name + " wants to use " + attack.Name + "...\r\n" + "But " + this.name + " is fainted...\r\n";
            }
            else if (target.HasFainted)
            {
                return this.name + " tries to use " + attack.Name + "...\r\n" + "But " + target.Name + " is already fainted...\r\n";
            }
            return this.name + " used " + attack.Name + " ! \r\n" + target.Attacked(attack);
        }

        /* When this pokemon gets attacked by pokemon
         * compare Energytype to weakness and resistance 
         * calculate damage
         * print either: it's very effective or it's not very effective or nothing
         * print: this pokemon took ... damage!
         * remove damage from health
         * check if health is equal or less than 0
         * if less than 0 the pokemon has fainted
         * else just print the remaining hp
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

            if (this.health <= 0)
            {
                text += this.name + " has 0hp remaining.\r\n" + this.name + " has fainted.\r\n";
                this.hasFainted = true;
            }
            else {
                text += this.name + " has " + this.health + "hp remaining.\r\n";
            }
            return text;
        }
    }
}
