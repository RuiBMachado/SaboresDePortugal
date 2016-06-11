using SaboresPortugalGui.DataAccess;
using SaboresPortugalGui.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaboresPortugalGui.View
{
    public partial class DefinePlano : Form
    {
        private Inicial mp;
        public DefinePlano()
        {
            mp = new Inicial();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            String NomeRestaurante = textBox1.Text;
            float longitude = Convert.ToSingle((textBox2.Text));
            float latitude = Convert.ToSingle((textBox3.Text));
          
            String Descricao = textBox4.Text;
            String Localidade = textBox5.Text;
            String Rua = textBox6.Text;
            String CodPostal = textBox7.Text;
            int Telefone;
            int.TryParse(textBox8.Text, out Telefone);
            String email = textBox9.Text;
            String datai = dateTimePicker1.Text;
            String dataf = dateTimePicker2.Text;
            int idRestaurante;
            if ( (idRestaurante =Restaurante.calculaCodigo(NomeRestaurante)) != -1)
            {
                Tarefa tar = new Tarefa(idRestaurante, longitude, latitude, Descricao, Localidade, Rua, CodPostal, Telefone, email, datai, dataf);
                if (TarefaDAO.putTarefa(tar) != -1)
                {
                    MessageBox.Show("Tarefa adicionada");
                    mp.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Ocorreu algum erro");
                    mp.Show();
                    this.Hide();
                }

            }
            else
            {
                Restaurante rest = new Restaurante(NomeRestaurante, longitude, latitude, Descricao, Localidade, Rua, CodPostal, Telefone, email);
                RestauranteDAO.putRestaurante(rest);
                idRestaurante = Restaurante.calculaCodigo(NomeRestaurante);
                Tarefa tar = new Tarefa(idRestaurante, longitude, latitude, Descricao, Localidade, Rua, CodPostal, Telefone, email, datai, dataf);
                if (TarefaDAO.putTarefa(tar) != -1)
                {
                    MessageBox.Show("Tarefa adicionada");
                    mp.Show();
                    this.Hide();
                }
                else {
                    MessageBox.Show("Ocorreu algum erro");
                    mp.Show();
                    this.Hide();
                }


            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            mp.Show();
            this.Hide();
        }

        private void DefinePlano_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
