using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PokemonBattle.PokemonLists
{
    internal class Eternatus:PokemonBase
    {
        public Eternatus() 
        {
            Random random = new Random();
            this.name = "Eternatus";
            this.hp = random.Next(322, 416) * 50;
            this.attack = random.Next(202, 350) ;
            this.defense = random.Next(166, 306) * 50;
            this.image = Properties.Resources.eternatus_removebg_preview;
        }
        
    }
}
