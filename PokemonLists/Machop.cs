using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBattle.PokemonLists
{
    internal class Machop:PokemonBase
    {
        public Machop() 
        {
            Random random = new Random();
            this.name = "Machop";
            this.hp = random.Next(250, 344);
            this.attack = random.Next(148, 284);
            this.defense = random.Next(94, 218);
            this.image = Properties.Resources.machop_removebg_preview;
        }
    }
}
