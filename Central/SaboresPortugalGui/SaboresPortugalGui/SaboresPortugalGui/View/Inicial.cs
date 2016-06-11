using SaboresPortugalGui.View;
using System;
using System.Windows.Forms;

namespace SaboresPortugalGui
{
    public partial class Inicial : Form
    {
        public Inicial()
        {

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DefinePlano a = new DefinePlano();
            a.Show();
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            EnviaDados ed = new EnviaDados();
            ed.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
        private void ConsultarDados_Click(object sender, EventArgs e)
        {
            DadosRecolhidos a = new DadosRecolhidos();
            a.Show();
            this.Hide();
        }
    }
}
