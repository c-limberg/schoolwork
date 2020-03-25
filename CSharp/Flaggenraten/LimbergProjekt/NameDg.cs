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
    public partial class NameDg : Form
    {
        public NameDg()
        {
            InitializeComponent();
        }

        private void submitNameBt_Click(object sender, EventArgs e)             //Speichert bei betätigen des Buttons den ins Textfeld eingegeben
        {                                                                       //Text als Spielernamen und schließt das Fenster.
            if (nameInput.Text != "")                                           //Wenn das Textfeld leer ist, wird stattdessen ein Dialog angezeigt.
            {
                if (nameInput.Text.Length <= 50)
                {
                    GameUI.playerName = nameInput.Text;
                    Close();
                }
                else
                    MessageBox.Show("Maximal 50 Zeichen!");
            }

            else
                MessageBox.Show("Kein Name eingegeben!");
        }

        private void NameDg_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(nameInput.Text == "")
                GameUI.playerName = "Anonym";
        }
    }
}
