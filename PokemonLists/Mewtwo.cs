using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBattle.PokemonLists
{
    internal class Mewtwo:PokemonBase
    {
        public Mewtwo() 
        {
            Random random = new Random();
            this.name = "Mewtwo";
            this.hp = random.Next(322, 416);
            this.attack = random.Next(202, 350);
            this.defense = random.Next(166, 306);
            this.image = Properties.Resources.mewtwo_removebg_preview;
        }

    }
}
