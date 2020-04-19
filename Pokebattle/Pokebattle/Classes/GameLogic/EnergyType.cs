using System;
using System.Collections.Generic;
using System.Text;

namespace Pokebattle.Classes.GameLogic
{
    class EnergyType
    {
        public enum energyName {Fire, Water, Lightning, Fighting};

        public energyName name;

        // Constructor
        public EnergyType(energyName _name)
        {
            this.name = _name;
        }
    }
}
