using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace LimbergProjekt
{
    class Database
    {
        MySqlConnection Con;
        MySqlCommand Com;

        public Database()
        {
            Con = new MySqlConnection("server=localhost;uid=root;pwd=root;database=game;");
        }

        private void OpenDB()
        {
            Con.Open();
        }

        private void CloseDB()
        {
            Con.Close();
        }

        public List<GameData> GetData()
        {
            List<GameData> GD = new List<GameData>();

            OpenDB();

            Com = Con.CreateCommand();
            Com.CommandText = "SELECT * FROM gamedata;";
            MySqlDataReader rd = Com.ExecuteReader();

            while (rd.Read())
            {
                GD.Add(new GameData(rd.GetInt32(0), rd.IsDBNull(1) ? "NoCountry" : rd.GetString(1), rd.IsDBNull(2) ? "NoCapital" : rd.GetString(2).Replace("_", " ")));
            }

            CloseDB();

            return GD;
        }

        public List<string> GetGamemodes()
        {
            List<string> GM = new List<string>();

            OpenDB();

            Com = Con.CreateCommand();
            Com.CommandText = "SELECT name FROM gamemode;";
            MySqlDataReader rd = Com.ExecuteReader();

            while (rd.Read())
            {
                GM.Add(rd.IsDBNull(0)?"":rd.GetString(0));
            }

            CloseDB();

            return GM;
        }

        public List<Score> GetScores()
        {
            List<Score> SList = new List<Score>();

            OpenDB();

            Com = Con.CreateCommand();
            Com.CommandText = "SELECT * FROM highscore ORDER BY score DESC;";
            MySqlDataReader rd = Com.ExecuteReader();

            while (rd.Read())
            {
                SList.Add(new Score(rd.IsDBNull(1) ? "Anon" : rd.GetString(1), rd.IsDBNull(2) ? -1 : rd.GetInt32(2), rd.IsDBNull(3) ? 0 : rd.GetInt32(3), rd.IsDBNull(4) ? DateTime.MinValue:rd.GetDateTime(4)));
            }

            CloseDB();

            return SList;
        }

        public void WriteScores(Score s)
        {
            try
            {
                OpenDB();

                Com = Con.CreateCommand();
                Com.CommandText = string.Format("INSERT INTO highscore VALUES(null, \"{0}\", {1}, {2}, \"{3}\");",
                                                s.Player, s.Gamemode, s.Hscore, s.Date.ToString("yyyy-MM-dd hh:mm:ss"));
                Com.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Add/Upd Score " + ex.Message);
            }
            finally
            {
                CloseDB();
            }
        }

        public void WriteGamedata(GameData GD)
        {
            try
            {
                OpenDB();

                Com = Con.CreateCommand();
                Com.CommandText = string.Format("INSERT INTO gamedata VALUES(null, \"{0}\", \"{1}\");", GD.Country, GD.Capital);
                Com.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Add/Upd GD " + ex.Message);
            }
            finally
            {
                CloseDB();
            }
        }
    }
}
