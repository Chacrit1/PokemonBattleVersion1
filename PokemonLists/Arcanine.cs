using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBattle.PokemonLists
{
    internal class Arcanine:PokemonBase
    {
        public Arcanine() {
            Random random = new Random();
            this.name = "Arcanine";
            this.hp = random.Next(290, 384);
            this.attack = random.Next(202, 350);
            this.defense = random.Next(148, 284);
            this.image = Properties.Resources.arcanine_removebg_preview;
        }
    }
}
