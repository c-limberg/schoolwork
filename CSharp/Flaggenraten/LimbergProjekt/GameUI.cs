using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LimbergProjekt
{
    public partial class GameUI : Form
    {
        Database db;
        ModeDg mdg;
        NameDg n;

        public static string playerName = "";
        int currentMode = -1;
        int right = -1;
        int gameCounter = 0;
        int correctCounter = 0;
        Stopwatch sw = new Stopwatch();                                     //Enthält die Spielzeit der momentanen Session

        List<int> answers = new List<int>();                                //Liste für zufällig generierte Indizes
        List<bool> answerTracker = new List<bool>();                        //Speichert die Antworthistorie (korrekt/inkorrekt) der Runde
        List<GameData> gameData = new List<GameData>();                     //Spieldaten aus der Datenbank

        PictureBox[] pbx = new PictureBox[4];                               //PictureBoxes für die Anzeige von Antwort-Flaggen
        Label[] answerLbs = new Label[4];                                   //Labels für die Anzeige von Antwort-Texten
        RadioButton[] answerBts = new RadioButton[4];                       //Radiobuttons für die Auswahl der Antwort
        PictureBox[] answerMarkers = new PictureBox[4];                     //Umrandungen für die Antwort, um korrekt/inkorrekt zu untermalen

        public GameUI()
        {
            InitializeComponent();
        }

        private void GameUI_Load(object sender, EventArgs e)
        {
            db = new Database();
            gameData = db.GetData();
            LoadEverything();
        }
       
        private void LoadEverything()                                       //Initialisiert alle Spielelemente bei Spielstart und beim Laden einer neuen Frage
        {
            if (playerName == "")                                        //Spielername-Dialog, solange Spielernamenvariable leer
            {
                n = new NameDg();
                n.ShowDialog();
                nameLb.Text = playerName;
            }

            if (currentMode < 0)                                            //Modus-Dialog, wenn Modusvariable leer (bei erstem Spielstart)
            {
                mdg = new ModeDg();
                mdg.ShowDialog();
            }

            if (!sw.IsRunning)                                              //Starten des Spielzeittrackers
            {
                sw.Start();
                swUpdater.Start();
            }

            currentMode = ModeDg.gamemode;                                  //Setzen des Spielmodus
            right = GetRightAnswer();                                       //Wahl einer korrekten Antwort für die momentane Runde

            pbx = new PictureBox[] { pbx1, pbx2, pbx3, pbx4 };              //Zuweisungen der Control-Arrays
            answerLbs = new Label[] { answerTextA, answerTextB, answerTextC, answerTextD };
            answerBts = new RadioButton[] { answerA, answerB, answerC, answerD };
            answerMarkers = new PictureBox[] { lightupA, lightupB, lightupC, lightupD };

            foreach (PictureBox p in pbx)                                   //Controls verstecken
                p.Hide();

            foreach (Label l in answerLbs)
                l.Hide();

            foreach (PictureBox p in answerMarkers)
                p.Hide();

            foreach (RadioButton rb in answerBts)
                    rb.Checked = false;
            

            qFlag.Hide();

            if(answerTracker.Count<1)                                       //Wenn erste Runde, Antwortliste generieren
                GenerateAnswers();
            LoadLabels();                                                   //Nicht-Antwortlabels anzeigen
            LoadAnswers();                                                  //Antworten anzeigen
        }

        private void LoadLabels()                                           //Weist allen nicht-Antwortlabels Texte zu
        {
            givenName.Hide();
            gameCountShow.Text = "Spiele: " + gameCounter.ToString();
            correctAnswerShow.Text = "Richtig: " + correctCounter.ToString() + " (" + (gameCounter > 0 ? ((double)correctCounter / gameCounter * 10).ToString() + "%" : "-") + ")";
            questNoLb.Text = "Frage " + (answerTracker.Count + 1).ToString() + " von 10";
            gameCorAn.Text = "Richtig: " + (answerTracker.Count(x => x == true) > 0 ? answerTracker.Count(x => x == true).ToString() : "0");
            gameWroAn.Text = "Falsch: " + (answerTracker.Count(x => x == false) > 0 ? answerTracker.Count(x => x == false).ToString() : "0");
            gamePoints.Text = "Punkte: " + (answerTracker.Count(x => x == true) > 0 ? (answerTracker.Count(x => x == true)*50).ToString() : "0");

            switch (currentMode)
            {
                case 1:
                    questTextLb.Text = "Welche dieser Hauptstädte gehört zum Land ";
                    gameBox.Text = "Hauptstadtraten";
                    break;
                case 2:
                    questTextLb.Text = "Welche dieser Flaggen gehört zum Land ";
                    gameBox.Text = "Flaggenraten";
                    break;
                case 3:
                    questTextLb.Text = "Welches dieser Länder gehört zur Hauptstadt ";
                    gameBox.Text = "Länderraten";
                    break;
                case 4:
                    questTextLb.Text = "Welche dieser Flaggen gehört zur Hauptstadt ";
                    gameBox.Text = "Flaggenraten";
                    break;
                case 5:
                    questTextLb.Text = "Welches dieser Länder gehört zur Flagge";
                    qFlag.Show();
                    gameBox.Text = "Länderraten";
                    break;
                case 6:
                    questTextLb.Text = "Welche dieser Hauptstädte gehört zur Flagge";
                    qFlag.Show();
                    gameBox.Text = "Hauptstadtraten";
                    break;
            }
        }                                       

        private void LoadAnswers()                                          //Generiert und aktiviert die Antwortmöglichkeiten unter
        {                                                                   //Berücksichtigung des Spielmodus
            int i = 0;

            if (currentMode >= 5)
            {
                qFlag.Image = (Image)Properties.Resources.ResourceManager.GetObject(gameData[answers[right]].Country);
                qFlag.Show();
            }

            else if (currentMode >= 3)
            {
                givenName.Text = gameData[answers[right]].Capital.Replace("_"," ");
                givenName.Show();
            }

            else
            {
                givenName.Text = gameData[answers[right]].Country.Replace("_"," ");
                givenName.Show();
            }

            if (currentMode == 2 || currentMode == 4)
            {
                foreach (PictureBox p in pbx)
                {
                    p.Image = (Image)Properties.Resources.ResourceManager.GetObject(gameData[answers[i]].Country);
                    i++;
                    p.Show();
                }
            }

            else if(currentMode == 1 || currentMode == 6)
            {
                foreach(Label l in answerLbs)
                {
                    l.Text = gameData[answers[i]].Capital;
                    i++;
                    l.Show();
                }
            }

            else if(currentMode == 3 || currentMode == 5)
            {
                foreach(Label l in answerLbs)
                {
                    l.Text = gameData[answers[i]].Country.Replace("_"," ");
                    i++;
                    l.Show();
                }
            }
        }

        private int GetRightAnswer()                                        //Generiert eine zufällige Zahl von 0 bis 3, die den Index der 
        {                                                                   //korrekten Antwort darstellt und gibt diese zurück.
            Random rng = new Random();
            return rng.Next(0, 4);
        }                                      

        private void GenerateAnswers()                                      //Füllt die answers-Liste mit 40 zufällig generierten, einzigartigen Indizes
        {                                                                   //von 0 bis zur Gesamtanzahl der Elemente in der Spieldaten-Liste.
            answers.Clear();                                

            Random rng = new Random();

            for (int i = 0; i < 40; i++)
            {
                int tmp = rng.Next(0, gameData.Count());
                if (!answers.Contains(tmp))
                    answers.Add(tmp);

                else i--;
            }
        }

        private void newGameBt_Click(object sender, EventArgs e)            //Startet die Funktion für ein neues Spiel bei Betätigung des Buttons
        {
            NewGame();
        }

        private void submitAnswerBt_Click(object sender, EventArgs e)       //Überprüft nach betätigen des Button, ob eine Antwort ausgewählt wurde
        {                                                                   //und wenn ja, deren Korrektheit.
            foreach (RadioButton rb in answerBts)                           //Löst respektive visuelle Effekte und Sound aus.
            {                                                               //Startet den Timer, dessen Tick die nächste Runde startet.
                if (rb.Checked)
                {
                    resultTextTimer.Start();
                    if (Array.IndexOf(answerBts, rb)==right)
                    {
                        answerMarkers[Array.IndexOf(answerBts, rb)].BackColor = Color.Green;
                        answerMarkers[Array.IndexOf(answerBts, rb)].Show();
                        PlaySound("correct");
                        answerTracker.Add(true);
                        return;
                    }

                    else
                    {
                        answerMarkers[Array.IndexOf(answerBts, rb)].BackColor = Color.Red;
                        answerMarkers[right].BackColor = Color.Green;
                        answerMarkers[Array.IndexOf(answerBts, rb)].Show();
                        answerMarkers[right].Show();
                        PlaySound("incorrect");
                        answerTracker.Add(false);
                        return;
                    }
                }
            }

            MessageBox.Show("Keine Antwort ausgewählt!");
        }

        private void PlaySound(string name)                                 //Spielt entweder den Sound für eine korrekte oder eine inkorrekte Antwort ab.
        {
            string path = "C:\\Flaggen\\"+name+".wav";
            SoundPlayer sp = new SoundPlayer(path);
            sp.Play();
        }

        private void NewGame()                                              //Startet ein neues Spiel. Wenn nach Beendigung eines Spiels aufgerufen,
        {                                                                   //speichert erst dessen Highscore in der Datenbank. Ansonsten wird ein
            if (answerTracker.Count < 10)                                   //Bestätigungsdialog angezeigt.
            {

                if (ConfirmNewGame())
                {
                    answerTracker.Clear();
                    LoadEverything();
                }

                else
                    return;
            }

            else
            {
                int matchCorrect = answerTracker.Count(x => x == true);
                answerTracker.Clear();
                correctCounter += matchCorrect;
                gameCounter++;
                SaveScore(matchCorrect * 50);

                DialogResult res = MessageBox.Show("Spiel zu Ende! Du hast " + matchCorrect.ToString() + " von 10 Fragen richtig beantwortet." +
                   "\nDas entspricht " + (matchCorrect * 50).ToString() + " Punkten.\n\nNochmal spielen?", "Spielende", MessageBoxButtons.YesNo);

                if (res == DialogResult.Yes)
                {
                    LoadEverything();
                }

                else if (res == DialogResult.No)
                {
                    Close();
                }
            }
        }                               

        private void NextQuestion()                                         //Geht zur nächsten Frage/Runde über.
        {
            if (answerTracker.Count < 10)
            {
                answers.RemoveRange(0, 4);
                LoadEverything();
            }

            else
                NewGame();
        }

        private void SaveScore(int pts)                                     //Speichert die letzte Highscore in der Datenbank
        {
            db = new Database();
            db.WriteScores(new Score(playerName, currentMode, pts, DateTime.Now));
        }

        private void swUpdater_Tick(object sender, EventArgs e)
        {
            TimeSpan ts = sw.Elapsed;
            timeLb.Text = "Zeit: "+ts.Hours.ToString("00")+":"+ts.Minutes.ToString("00")+":"+ts.Seconds.ToString("00");
        }           //Synchronisiert im Timerintervall die Zeitanzeige mit der Stopwatch

        private void changeModeBt_Click(object sender, EventArgs e)          //Zeigt das Moduswechsel-Fenster an, wenn der Button getätigt wurde.
        {
            if (ConfirmNewGame())
            {
                mdg = new ModeDg();
                mdg.ShowDialog();
                answerTracker.Clear();
                LoadEverything();
            }
        }

        private bool ConfirmNewGame()                                       //Bestätigungsfenster, wenn laufendes Spiel beendet werden soll.
        {
            DialogResult res = MessageBox.Show("Das laufende Spiel geht verloren. Bist du sicher?", "Modus wechseln", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes) return true;
            else return false;
        }

        private void resultTextTimer_Tick(object sender, EventArgs e)       //Tick = wie lange die Antworten inkl. korrekt/inkorrekt-Indikator nach
        {                                                                   //der Auswahl und Bewertung einer Antwort noch angezeigt wird, bevor
            resultTextTimer.Stop();                                         //die nächste Frage/Runde geladen wird
            NextQuestion();
        }

        private void GameUI_FormClosed(object sender, FormClosedEventArgs e)    //Lädt die Musik im Hauptmenü, wenn Spiel geschlossen wird
        {
            sw.Stop();
            swUpdater.Stop();
            MainMenu.LoadMusic(MainMenu.music);
        }

        private void SelectAnswerA(object sender, EventArgs e)
        {
            answerBts[0].Checked = true;
        }

        private void SelectAnswerB(object sender, EventArgs e)
        {
            answerBts[1].Checked = true;
        }

        private void SelectAnswerC(object sender, EventArgs e)
        {
            answerBts[2].Checked = true;
        }

        private void SelectAnswerD(object sender, EventArgs e)
        {
            answerBts[3].Checked = true;
        }
    }
}
