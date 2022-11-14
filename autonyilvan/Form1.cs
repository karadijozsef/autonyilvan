using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace autonyilvan
{
    public partial class Form_Nyito : Form
    {
        MySqlConnection conn = null;
        MySqlCommand cmd = null;
        public Form_Nyito()
        {
            InitializeComponent();
        }

        private void Form_Nyito_Load(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.UserID = "root";
            builder.Password = "";
            builder.Database = "autok";
            conn = new MySqlConnection(builder.ConnectionString);
            try
            {
                //-- terv szerint
                conn.Open();
                cmd = conn.CreateCommand();
            }
            catch (MySqlException ex)
            {
                //-- váratlan hiba!
                MessageBox.Show(ex.Message + Environment.NewLine + "A program leáll!!");
                Environment.Exit(0);
                
            }
            finally
            {
                //-- Hiba és terv szerinti esetén is lefut
                conn.Close();
            }
            Autok_lista_update();
        }
        /**
         * public void Autok_lista_update
          Autók listájának frissítése az adatbázisból
        */
        private void Autok_lista_update()
        {
            listBox_Autok.Items.Clear();
            cmd.CommandText = "SELECT `id`,`rendszam`,`uzembehelyezve`,`szin` FROM `autok` WHERE 1";
            conn.Open();
            using (MySqlDataReader dr = cmd.ExecuteReader())
            {
                while (dr.Read())
                {
                    Auto uj = new Auto(dr.GetInt32("id"), dr.GetString("rendszam"), dr.GetInt32("uzembehelyezve"), dr.GetString("szin"));
                    listBox_Autok.Items.Add(uj);
                }
            }
            conn.Close();
        }

        private void insert_Click(object sender, EventArgs e)
        {
            //-- szükséges adatok ellenőrzése
            if (string.IsNullOrEmpty(textBox_rendszam.Text))
            {
                MessageBox.Show("Adjon meg rendszámot!");
                textBox_rendszam.Focus();
                return;
            }
            if (numericUpDown_evjarat.Value > DateTime.Now.Year)
            {
                MessageBox.Show("Érvénytelen évjárat!!!");
                numericUpDown_evjarat.Value = DateTime.Now.Year;
                numericUpDown_evjarat.Focus();
                return;
            }
            if (string.IsNullOrEmpty(textBox_szin.Text))
            {
                MessageBox.Show("Nem adott meg színt!!");
                textBox_szin.Focus();
                return;
            }
            //-- Kiírjuk az adatbázisba --------
            cmd.CommandText = "INSERT INTO `autok` (`id`, `rendszam`, `uzembehelyezve`, `szin`) VALUES (NULL, @rendszam, @ev, @szin)";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@rendszam",textBox_rendszam.Text);
            cmd.Parameters.AddWithValue("@ev", numericUpDown_evjarat.Value.ToString());
            cmd.Parameters.AddWithValue("@szin", textBox_szin.Text);
            conn.Open();
            try
            {
                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Sikeresen rögzítve!");
                    textBox_id.Text = "";
                    textBox_rendszam.Text = "";
                    numericUpDown_evjarat.Value = numericUpDown_evjarat.Minimum;
                    textBox_szin.Text = "";
                }
                else
                {
                    MessageBox.Show("Sikertelen rögzítés!");
                }

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
            Autok_lista_update();
        }
    }
}
