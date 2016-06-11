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

namespace SaboresPortugalGui.View
{
    public partial class DadosRecolhidos : Form
    {
        private Inicial mp;
        private ApresentaDados ad;

        public DadosRecolhidos()
        {
            mp = new Inicial();

            InitializeComponent();
            
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            mp.Show();
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int tarefa=ListView1_SelectedIndexChanged_UsingItems();

            ad = new ApresentaDados(tarefa);
            ad.Show();
            this.Dispose();
        }

        

        private void DadosRecolhidos_Load(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {

                SqlConnection UGIcon = new SqlConnection("Database=SaboresPortugalDB;Server=DESKTOP-2T9S0Q5;Integrated Security = True; connect timeout = 30");

                if (UGIcon.State == ConnectionState.Closed)
                {
                    UGIcon.Open();
                }
                SqlCommand command = new SqlCommand("SELECT * FROM Tarefa", UGIcon);

             



                SqlDataReader reader = command.ExecuteReader();
                    
                       
                        while (reader.Read())
                        {
                            ListViewItem item = new ListViewItem(reader["IdTarefa"].ToString());
                            item.SubItems.Add(reader["datainicial"].ToString());
                            item.SubItems.Add(reader["datafim"].ToString());

                            listView1.Items.Add(item);
                        }

              }
            catch (SqlException ex) { MessageBox.Show("erro"); }



        }

        public int ListView1_SelectedIndexChanged_UsingItems()
        {

            int idtarefa=-1 ;

            
            if (listView1.SelectedItems.Count > 0)
            {
                if (listView1.SelectedItems[0] != null)
                {
                    string curItem = listView1.SelectedItems[0].Text;
                    var parts = curItem.Split(' ');
                    idtarefa = int.Parse(parts[0]);
                }
                else
                
           {
                        MessageBox.Show("Seleccione uma tarefa");
                    
                }
            }
            return idtarefa;
        }



    }


}

