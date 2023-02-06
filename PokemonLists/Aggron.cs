using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBattle.PokemonLists
{
    internal class Aggron : PokemonBase
    {
        public Aggron()
        {
            Random random= new Random();
            this.name = "Aggron";
            this.hp = random.Next(250, 344);
            this.attack = random.Next(202, 350);
            this.defense = random.Next(328, 504);
            this.image = Properties.Resources.aggron_removebg_preview;
        }
    }
}
