using PokemonBattle.PokemonLists;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace PokemonBattle
{
    public partial class Form1 : Form
    {

        SoundPlayer selectedSound = new SoundPlayer(@"E:\docs\c#\PokemonBattle\Resources\sound\selectedpokemon.wav");
        SoundPlayer evolutionSound = new SoundPlayer(@"E:\docs\c#\PokemonBattle\Resources\sound\power-down-7103.wav");
        SoundPlayer attckSound = new SoundPlayer(@"E:\docs\c#\PokemonBattle\Resources\sound\swinging-staff-whoosh-strong-08-44658.wav");
        
        List<PokemonBase> PokemonList;
        PokemonBase selectedPokemon;
        PokemonBase selectedMonster;

        bool State = false;

        int heart = 4;

        bool monsterEvolution = false;
        public Form1()
        {
            InitializeComponent();
            //MXP.URL = @"E:\docs\c#\PokemonBattle\Resources\sound\backgroundmusic.wav";
            //MXP.settings.playCount = 9999;
            //MXP.Ctlcontrols.play();
            MXP.Visible = false;

            PokemonList = new List<PokemonBase>();

            PokemonList.Add(new Aggron());
            PokemonList.Add(new Mewtwo());
            PokemonList.Add(new Machop());
            PokemonList.Add(new Arcanine());

            this.selectedMonster = new Eternatus();
            this.pictureBox2.Image = selectedMonster.getImage();
            this.label4.Text = "Name: " + selectedMonster.getName();
            this.label3.Text = "Hp: " + selectedMonster.getHp();
            this.label2.Text = "Attack: " + selectedMonster.getAttack();
            this.label1.Text = "Defense: " + selectedMonster.getdDefense();

            this.label6.Hide();
            this.button1.Enabled = false;
            this.buttonEvolution.Enabled = false;

            this.buttonMonsterAttack.Enabled = false;
            this.buttonMonsterEvolution.Enabled = false;

            this.pictureAggron.Image = PokemonList[0].getImage();
            this.pictureMewtwo.Image = PokemonList[1].getImage();
            this.pictureMachop.Image = PokemonList[2].getImage();
            this.pictureArcanine.Image = PokemonList[3].getImage();

            this.buttonEvolution.Hide();
        }

    
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureAggron_Click(object sender, EventArgs e)
        {
            selectedSound.Play();
            this.selectedPokemon = PokemonList[0];
            if(selectedPokemon.getHp() < 0)
            {
                return;
            }
            this.labelChooseYourPokemon.Hide();
            this.pictureBox1.Image = selectedPokemon.getImage();
            this.labelnameStat.Text = "Name: " + selectedPokemon.getName();
            this.labelhpStat.Text = "Hp: " + selectedPokemon.getHp();
            this.labelattackStat.Text = "Attack: " + selectedPokemon.getAttack();
            this.labeldefenseStat.Text = "Defense: " + selectedPokemon.getdDefense();
            this.label7.Text = "Acton: " + selectedPokemon.getName();
            this.labelSkills.Text ="Skill:  " + selectedPokemon.getName();
            this.label6.Show();
            if (this.State)
            {
                this.button1.Enabled = false;
                this.buttonEvolution.Enabled = false;
            }
            else
            {
                this.button1.Enabled = true;
                this.buttonEvolution.Enabled = true;
            }
            int milliseconds = 60;
            Thread.Sleep(milliseconds);

        }

        private void pictureMewtwo_Click(object sender, EventArgs e)
        {
            selectedSound.Play();
            this.selectedPokemon = PokemonList[1];
            this.labelChooseYourPokemon.Hide();
            this.pictureBox1.Image = selectedPokemon.getImage();
            this.labelnameStat.Text = "Name: " + selectedPokemon.getName();
            this.labelhpStat.Text = "Hp: " + selectedPokemon.getHp();
            this.labelattackStat.Text = "Attack: " + selectedPokemon.getAttack();
            this.labeldefenseStat.Text = "Defense: " + selectedPokemon.getdDefense();
            this.label7.Text = "Acton: " + selectedPokemon.getName();
            this.labelSkills.Text = "Skill:  " + selectedPokemon.getName();
            this.label6.Show();
            if (this.State)
            {
                this.button1.Enabled = false;
                this.buttonEvolution.Enabled = false;
            }
            else
            {
                this.button1.Enabled = true;
                this.buttonEvolution.Enabled = true;
            }
            int milliseconds = 60;
            Thread.Sleep(milliseconds);
        }

        private void pictureMachop_Click(object sender, EventArgs e)
        {
            selectedSound.Play();
            this.selectedPokemon = PokemonList[2];
            this.labelChooseYourPokemon.Hide();
            this.pictureBox1.Image = selectedPokemon.getImage();
            this.labelnameStat.Text = "Name: " + selectedPokemon.getName();
            this.labelhpStat.Text = "Hp: " + selectedPokemon.getHp();
            this.labelattackStat.Text = "Attack: " + selectedPokemon.getAttack();
            this.labeldefenseStat.Text = "Defense: " + selectedPokemon.getdDefense();
            this.label7.Text = "Acton: " + selectedPokemon.getName();
            this.labelSkills.Text = "Skill:  " + selectedPokemon.getName();
            this.label6.Show();
            if (this.State)
            {
                this.button1.Enabled = false;
                this.buttonEvolution.Enabled = false;
            }
            else
            {
                this.button1.Enabled = true;
                this.buttonEvolution.Enabled = true;
            }

            this.buttonEvolution.Enabled = false;
            int milliseconds = 60;
            Thread.Sleep(milliseconds);
        }

        private void pictureArcanine_Click(object sender, EventArgs e)
        {
            selectedSound.Play();
            this.selectedPokemon = PokemonList[3];
            this.labelChooseYourPokemon.Hide();
            this.pictureBox1.Image = selectedPokemon.getImage();
            this.labelnameStat.Text = "Name: " + selectedPokemon.getName();
            this.labelhpStat.Text = "Hp: " + selectedPokemon.getHp();
            this.labelattackStat.Text = "Attack: " + selectedPokemon.getAttack();
            this.labeldefenseStat.Text = "Defense: " + selectedPokemon.getdDefense();
            this.label7.Text = "Acton: " + selectedPokemon.getName();
            this.labelSkills.Text = "Skill:  " + selectedPokemon.getName();
            this.label6.Show();
       
            if (this.State)
            {
                this.button1.Enabled = false;
                this.buttonEvolution.Enabled = false;
            }
            else
            {
                this.button1.Enabled = true;
                this.buttonEvolution.Enabled = true;
            }
            int milliseconds = 60;
            Thread.Sleep(milliseconds);
        }

        private void buttonEvolution_Click(object sender, EventArgs e)
        {
            evolutionSound.Play();
            
            this.button1.Enabled = false;
            this.buttonEvolution.Enabled = false;
            this.buttonMonsterAttack.Enabled = true;
            this.buttonMonsterEvolution.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            attckSound.Play();
            selectedMonster.takeDamage(selectedPokemon.getAttack());
            this.label3.Text = "Hp: " + selectedMonster.getHp();
            this.label6.Text = "      You:Attack";
            this.State = true;
            this.button1.Enabled = false;
            this.buttonEvolution.Enabled = false;
            this.buttonMonsterAttack.Enabled = true;
            this.buttonMonsterEvolution.Enabled = true;
        }

        private void buttonMonsterAttack_Click(object sender, EventArgs e)
        {
            attckSound.Play();
            selectedPokemon.takeDamage(selectedMonster.getAttack());
            if (selectedPokemon.getHp() < 0)
            {
                if (this.selectedPokemon.getName() == "Aggron")
                {
                    this.pictureAggron.Image = null;

                }else if (this.selectedPokemon.getName() == "Mewtwo")
                {
                    this.pictureMewtwo.Image = null;

                }
                else if (this.selectedPokemon.getName() == "Arcanine")
                {
                    this.pictureArcanine.Image = null;

                }
                else
                {
                    this.pictureMachop.Image = null;
                }
                this.pictureBox1.Image = null;
                this.labelnameStat.Text = "";
                this.labelhpStat.Text = "";
                this.labelattackStat.Text = "";
                this.labeldefenseStat.Text = "";
                this.label7.Text = "";
                this.labelSkills.Text = "";
                this.button1.Enabled = false;
                this.buttonEvolution.Enabled = false;
                this.heart -= 1;

                if (this.heart == 0)
                {
                    MessageBox.Show("You Lose !");
                }
            }
            else
            {
                this.labelhpStat.Text = "Hp: " + selectedPokemon.getHp();
                this.button1.Enabled = true;
                this.buttonEvolution.Enabled = true;
            }
            this.label6.ForeColor = Color.Red;
            this.label6.Text = "   Opposite:Attack";
            this.State = false; 
            this.buttonMonsterAttack.Enabled = false;
            this.buttonMonsterEvolution.Enabled = false;

        }

        private void buttonMonsterEvolution_Click(object sender, EventArgs e)
        {
            if (this.monsterEvolution)
            {
                return;
            }
            evolutionSound.Play();
            this.pictureBox2.Image = Properties.Resources.eternatus_eternamax_removebg_preview;
            this.label3.Text = "HP: "+(selectedMonster.getHp() * 4).ToString();
            this.label2.Text = "Attack: " + (selectedMonster.getAttack() * 4).ToString();
            this.label1.Text = "Defense: " + (selectedMonster.getdDefense() * 4).ToString();
            this.State = false; 
            this.monsterEvolution = true;
            this.button1.Enabled = true;
            this.buttonEvolution.Enabled = true;
            this.buttonMonsterAttack.Enabled = false;
            this.buttonMonsterEvolution.Enabled = false;
        }
    }
}
