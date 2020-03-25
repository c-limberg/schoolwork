using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LimbergProjekt
{
    public partial class MainMenu : Form
    {
        List<GameData> gameData = new List<GameData>();
        Database db = new Database();
        static SoundPlayer sp;
        public static bool music = true;

        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            //ReadFromTxt();            //Einmal ausgeführt, um die Datenbank zu füllen.
            gameVerLb.Text = "Game Version 1.0\t\t Last Update: "+DateTime.Now;
            musicOn.Checked = true;
            LoadMusic(music);
        }

        private void scoreBt_Click(object sender, EventArgs e)
        {
            ScoreWindow swin = new ScoreWindow();
            swin.ShowDialog();
        }

        private void creditBt_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bilder: Google\nCode: Christopher Limberg\nGPB 2020");
        }

        private void startGameBt_Click(object sender, EventArgs e)
        {
            sp.Stop();
            GameUI.playerName = "";
            GameUI gui = new GameUI();
            gui.ShowDialog();
        }

        public static void LoadMusic(bool on)
        {
            sp = new SoundPlayer(Properties.Resources.mainmenu);
            if (on)
                sp.PlayLooping();
            else
                sp.Stop();
        }

        private void musicOn_CheckedChanged(object sender, EventArgs e)
        {
            if (musicOn.Checked)
                music = true;
            else
                music = false;

            LoadMusic(music);
        }

        private void ReadFromTxt()
        {
            gameData.Clear();

            List<string> countries = new List<string>();
            List<string> capitals = new List<string>();

            StreamReader sr = new StreamReader("countries.txt");

            while (!sr.EndOfStream)
            {
                countries.Add(sr.ReadLine());
            }

            sr.Close();

            sr = new StreamReader("capitals.txt");

            while (!sr.EndOfStream)
            {
                capitals.Add(sr.ReadLine());
            }

            sr.Close();

            for (int i = 0; i < countries.Count(); i++)
            {
                gameData.Add(new GameData(-1, countries[i], capitals[i]));
            }

            foreach (GameData g in gameData)
                db.WriteGamedata(g);
        }
    }
}
