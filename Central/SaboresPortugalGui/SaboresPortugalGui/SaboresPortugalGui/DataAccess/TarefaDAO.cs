using System;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;
using System.Globalization;
using SaboresPortugalGui.Logic;
using SaboresPortugalGui.View;

namespace SaboresPortugalGui.DataAccess
{
   public class TarefaDAO
    {
        private static String dataconn = "Database=SaboresPortugalDB;Server=DESKTOP-2T9S0Q5;Integrated Security = True; connect timeout = 30";
        public static int getNrTarefas()
        {
            string stmt = "SELECT COUNT(*) FROM Tarefa";
            int count = 0;
           

            using (SqlConnection thisConnection = new SqlConnection(dataconn))
            {
                using (SqlCommand cmdCount = new SqlCommand(stmt, thisConnection))
                {
                    thisConnection.Open();
                    count = (int)cmdCount.ExecuteScalar();
                }
            }
            return count;
        }


        public static int putTarefa(Tarefa a)
        {
            int id = getNrTarefas()+1;
            Console.WriteLine("TAREFAS:" + id);

            using (SqlConnection connection = new SqlConnection(dataconn))
            {
                try
                {
                    if (TarefaDAO.TarefaExiste(a.id))
                    {
                        return 0;
                    }
                    else
                    {
                        connection.Open();
                        string alunoquery = "INSERT Tarefa (idTarefa,datainicial,datafim,relatorio,voz,idRestaurante) OUTPUT INSERTED.idTarefa ";
                        alunoquery += "VALUES (\'" + id + "\','"  + a.dataInicio + "\','" + a.dataFim  + "\','" + a.relatorio  + "\','" + a.voz 
                            + "\','" +a.idRestaurante + "\'" + ")";
                        using (SqlCommand command = connection.CreateCommand())
                        {
                            command.CommandText = alunoquery;
                            
                            return (int)command.ExecuteScalar();
                        }

                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "Erro SQL!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return 0;
                }
            }
        }


        public static bool TarefaExiste(int id)
        {
            using (SqlConnection connection = new SqlConnection(dataconn))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(
                "SELECT * FROM Tarefa where idTarefa='" + id + "'", connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        reader.Read();
                        if (reader.HasRows)
                            return true;
                        else
                            return false;
                    }
                }
            }
        }
    }


}
