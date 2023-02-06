using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBattle.PokemonLists
{
    public class PokemonBase
    {
        protected string name { get; set; }
        protected int hp { get; set; }
        protected int attack { get; set; }
        protected int defense { get; set; }
        protected Bitmap image { get; set; }

        public string getName() { return name; }
        public int getHp() { return hp; }
        public int getAttack() { return attack; }
        public int getdDefense() { return defense; }
        public Bitmap getImage() { return image; }

        public void takeDamage(int damage)
        {
            this.hp = this.hp - damage;
        }
    }
}
