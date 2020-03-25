using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LimbergProjekt
{
    public partial class ModeDg : Form
    {
        public static int gamemode = -1;                                            //Variable für den Spielmodus

        public ModeDg()
        {
            InitializeComponent();
        }

        private void countryToCapBt_Click(object sender, EventArgs e)               //Jeder Button setzt entsprechend die Spielmodusvariable neu
        {                                                                           //und schließt im Anschluss das Fenster
            gamemode = 1;
            Close();
        }

        private void capToCountryBt_Click(object sender, EventArgs e)
        {
            gamemode = 3;
            Close();
        }

        private void flagToCountryBt_Click(object sender, EventArgs e)
        {
            gamemode = 5;
            Close();
        }


        private void countryToFlagBt_Click(object sender, EventArgs e)
        {
            gamemode = 2;
            Close();
        }

        private void capToFlagBt_Click(object sender, EventArgs e)
        {
            gamemode = 4;
            Close();
        }

        private void flagToCapBt_Click(object sender, EventArgs e)
        {
            gamemode = 6;
            Close();
        }
    }
}
