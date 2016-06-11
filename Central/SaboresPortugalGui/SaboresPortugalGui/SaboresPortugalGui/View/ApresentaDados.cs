using SaboresPortugalGui.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SaboresPortugalGui.View;
using System.Data.SqlClient;
using SaboresPortugalGui.DataAccess;

namespace SaboresPortugalGui.View
{
    public partial class ApresentaDados : Form
    {
        Tarefa a;
        private int tarefa;
        private Inicial mp;
        int idRestaurante = -1;
        public ApresentaDados()
        {
           
            InitializeComponent();
           
        }

        public ApresentaDados(int tarefa)
        {
            this.tarefa = tarefa;
            InitializeComponent();
            ApresentaInfo();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void ApresentaDados_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        private void ApresentaInfo()
        {
            try
            {
                SqlConnection UGIcon = new SqlConnection("Database=SaboresPortugalDB;Server=DESKTOP-2T9S0Q5;Integrated Security = True; connect timeout = 30");

                if (UGIcon.State == ConnectionState.Closed)
                {
                    UGIcon.Open();
                }


                SqlCommand command = new SqlCommand("SELECT * FROM Tarefa where idTarefa = " + this.tarefa + "", UGIcon);





                SqlDataReader reader = command.ExecuteReader();

                

                while (reader.Read())
                {
                    label8.Text = reader["idTarefa"].ToString();
                    label9.Text = reader["datainicial"].ToString();
                    label10.Text = reader["datafim"].ToString();
                    idRestaurante =int.Parse( reader["idRestaurante"].ToString());
                }
                reader.Close();

                SqlCommand com = new SqlCommand("SELECT * FROM Restaurante where idRestaurante = " + idRestaurante + "", UGIcon);

                SqlDataReader read = com.ExecuteReader();


                    while (read.Read())
                    {
                        label11.Text = read["nome"].ToString();
                        textBox1.Text = read["descricao"].ToString();
                        textBox3.Text = read["email"].ToString();
                    
                        label14.Text = read["rua"].ToString() + " " + read["codigopostal"].ToString() + " " + read["localidade"].ToString();
                        label22.Text = read["longitude"].ToString();
                        label23.Text = read["latitude"].ToString();


                }
                read.Close();

                SqlCommand c = new SqlCommand("SELECT * FROM TelefoneRestaurante where idRestaurante = " + idRestaurante + "", UGIcon);

                SqlDataReader r = c.ExecuteReader();
                


                while (r.Read())
                {
                    textBox4.Text = r["numero"].ToString();
                  
                }

            }
            catch (SqlException ex) { MessageBox.Show("erro"); }



        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            mp = new Inicial();
            mp.Show();
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String t1 = textBox1.Text;
            String t3 = textBox3.Text;
            String t4 = textBox4.Text;
            int res=  RestauranteDAO.updates(idRestaurante,t1,t3,t4);
            if(res==0) MessageBox.Show("Actualizações efectuadas");
            else MessageBox.Show("Ocorreu algum erro");
            mp = new Inicial();
            mp.Show();
            this.Dispose();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
