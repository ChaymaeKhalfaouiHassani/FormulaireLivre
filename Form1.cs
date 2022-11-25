using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient;

namespace Formulaire_Livre
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        } 
            private void Form1_Load(object sender, EventArgs e)
            {

            }

            private void label2_Click(object sender, EventArgs e)
            {

            }

            private void label3_Click(object sender, EventArgs e)
            {

            }

            private void button1_Click(object sender, EventArgs e)
            {
                SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Jaguar\\Documents\\SQLQuery1.sql.mdf;Integrated Security=True;Connect Timeout=30");
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into Livre (@ID,@NomLiv,@PrixLiv)", con);
                cmd.Parameters.AddWithValue("@ID", int.Parse(comboBox1.Text));
                cmd.Parameters.AddWithValue("@NomLiv", comboBox2.Text);
                cmd.Parameters.AddWithValue("@PrixLiv", int.Parse(comboBox3.Text));
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("sauvgarder");
            }
            private void label1_Click(object sender, EventArgs e)
            {

            }
            private void button2_Click(object sender, EventArgs e)
            {
                SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Jaguar\\Documents\\SQLQuery1.sql.mdf;Integrated Security=True;Connect Timeout=30");
                con.Open();
                SqlCommand cmd = new SqlCommand("Update Livre set NomLiv=@NomLiv,PrixLiv=@PrixLiv where ID=@ID  ", con);
                cmd.Parameters.AddWithValue("@ID", int.Parse(comboBox1.Text));
                cmd.Parameters.AddWithValue("@NomLiv", comboBox2.Text);
                cmd.Parameters.AddWithValue("@PrixLiv", int.Parse(comboBox3.Text));
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("sauvgarder");
            }

            private void button3_Click(object sender, EventArgs e)
            {
                SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Jaguar\\Documents\\SQLQuery1.sql.mdf;Integrated Security=True;Connect Timeout=30");
                con.Open();
                SqlCommand cmd = new SqlCommand("Delete Livre where ID=@ID", con);
                cmd.Parameters.AddWithValue("@ID", int.Parse(comboBox1.Text));
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("sauvgarder");
            }
        }
    }

