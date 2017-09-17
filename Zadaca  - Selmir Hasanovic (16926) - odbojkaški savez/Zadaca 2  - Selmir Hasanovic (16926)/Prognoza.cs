using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadaca_2___Selmir_Hasanovic__16926_
{
    public partial class Prognoza : Form
    {
        List<string> prognoza = new List<string>();
        public Prognoza(List<String> lista)
        {
            InitializeComponent();
            prognoza = lista;
        }
        System.Media.SoundPlayer player;
        private void Prikaži1_Click(object sender, EventArgs e)
        {
            Vrijeme1.Text = prognoza[0];
            Vrijeme1.Visible = true;
            if(prognoza[0] == "Fog")
            {
                Jedan.Image = Image.FromFile("fog.gif");
                Jedan.Visible = true;
                player = new System.Media.SoundPlayer("Fog.wav");
                player.Play();
            }
            else if(prognoza[0] == "Mainly sunny")
            {
                Jedan.Image = Image.FromFile("MostlySunny.gif");
                Jedan.Visible = true;
                player = new System.Media.SoundPlayer("Sun.wav");
                player.Play();
            }
            else if(prognoza[0] == "Variable cloudiness")
            {
                Jedan.Image = Image.FromFile("Clouds.gif");
                Jedan.Visible = true;
                player = new System.Media.SoundPlayer("Clouds.wav");
                player.Play();
            }
            else if(prognoza[0] == "Rain")
            {
                Jedan.Image = Image.FromFile("Rain.gif");
                Jedan.Visible = true;
                player = new System.Media.SoundPlayer("Rain.wav");
                player.Play();
            }
            else if (prognoza[0] == "Snow")
            {
                Jedan.Image = Image.FromFile("Snow.gif");
                Jedan.Visible = true;
                player = new System.Media.SoundPlayer("Snow.wav");
                player.Play();
            }
        }

        private void Sakrij1_Click(object sender, EventArgs e)
        {
            if (player != null)
                player.Stop();
        }
        System.Media.SoundPlayer player1;
        private void Prikaži2_Click(object sender, EventArgs e)
        {
            Vrijeme2.Text = prognoza[1];
            Vrijeme2.Visible = true;
            if (prognoza[1] == "Fog")
            {
                Dva.Image = Image.FromFile("fog.gif");
                Dva.Visible = true;
                player1 = new System.Media.SoundPlayer("Fog.wav");
                player1.Play();
            }
            else if (prognoza[1] == "Mainly sunny")
            {
                Dva.Image = Image.FromFile("MostlySunny.gif");
                Dva.Visible = true;
                player1 = new System.Media.SoundPlayer("Sun.wav");
                player1.Play();
            }
            else if (prognoza[1] == "Variable cloudiness")
            {
                Dva.Image = Image.FromFile("Clouds.gif");
                Dva.Visible = true;
                player1 = new System.Media.SoundPlayer("Clouds.wav");
                player1.Play();
            }
            else if (prognoza[1] == "Rain")
            {
                Dva.Image = Image.FromFile("Rain.gif");
                Dva.Visible = true;
                player1 = new System.Media.SoundPlayer("Rain.wav");
                player1.Play();
            }
            else if (prognoza[1] == "Snow")
            {
                Dva.Image = Image.FromFile("Snow.gif");
                Dva.Visible = true;
                player1 = new System.Media.SoundPlayer("Snow.wav");
                player1.Play();
            }
        }

        private void Sakrij2_Click(object sender, EventArgs e)
        {
            if (player1 != null)
                player1.Stop();
        }
        System.Media.SoundPlayer player2;
        private void Prikaži3_Click(object sender, EventArgs e)
        {
            Vrijeme3.Text = prognoza[2];
            Vrijeme3.Visible = true;
            if (prognoza[2] == "Fog")
            {
                Tri.Image = Image.FromFile("fog.gif");
                Tri.Visible = true;
                player2 = new System.Media.SoundPlayer("Fog.wav");
                player2.Play();
            }
            else if (prognoza[2] == "Mainly sunny")
            {
                Tri.Image = Image.FromFile("MostlySunny.gif");
                Tri.Visible = true;
                player2 = new System.Media.SoundPlayer("Sun.wav");
                player2.Play();
            }
            else if (prognoza[2] == "Variable cloudiness")
            {
                Tri.Image = Image.FromFile("Clouds.gif");
                Tri.Visible = true;
                player2 = new System.Media.SoundPlayer("Clouds.wav");
                player2.Play();
            }
            else if (prognoza[2] == "Rain")
            {
                Tri.Image = Image.FromFile("Rain.gif");
                Tri.Visible = true;
                player2 = new System.Media.SoundPlayer("Rain.wav");
                player2.Play();
            }
            else if (prognoza[2] == "Snow")
            {
                Tri.Image = Image.FromFile("Snow.gif");
                Tri.Visible = true;
                player2 = new System.Media.SoundPlayer("Snow.wav");
                player2.Play();
            }
        }

        private void Sakrij3_Click(object sender, EventArgs e)
        {
            if(player2 != null)
                player2.Stop();
        }
    }
}
