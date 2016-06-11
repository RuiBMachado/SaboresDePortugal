using SaboresPortugalGui.Logic;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SaboresPortugalGui.DataAccess
{
    class RestauranteDAO
    {
        private static String dataconn = "Database=SaboresPortugalDB;Server=DESKTOP-2T9S0Q5;Integrated Security = True; connect timeout = 30";
        public static int getNrRestaurantes()
        {
            string stmt = "SELECT COUNT(*) FROM Restaurante";
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
        

        public static int putRestaurante(Restaurante a)
        {
            int id = getNrRestaurantes()+1;
          

            using (SqlConnection connection = new SqlConnection(dataconn))
            {
                try
                {
                    if (RestauranteExiste(a.id))
                    {
                        return 0;
                    }
                    else
                    { 
                        connection.Open();
                        

                        using (SqlCommand command = connection.CreateCommand())
                        {
                            command.Parameters.Add("@longitude", System.Data.SqlDbType.Float);
                            command.Parameters["@longitude"].Value = a.longitude;
                            command.Parameters.Add("@latitude", System.Data.SqlDbType.Float);
                            command.Parameters["@latitude"].Value = a.latitude;
                            string alunoquery = "INSERT Restaurante (idRestaurante,descricao,nome,email,codigopostal,localidade,latitude,longitude,rua) OUTPUT INSERTED.idRestaurante ";
                            alunoquery += "VALUES (\'" + id + "\','" + a.descricao + "\','" + a.nome + "\','" + a.email + "\','" + a.codpostal + "\','" + a.localidade + "\',@latitude,@longitude,'" + a.rua + "\'" + ")";
                            string insereTelefone = "INSERT TelefoneRestaurante (numero,idRestaurante) OUTPUT INSERTED.numero ";
                            insereTelefone += "VALUES (\'" + a.telefone + "\','" + id + "\'" + ")";
                            command.CommandText = alunoquery;
                            
                            command.ExecuteScalar();
                            command.CommandText = insereTelefone;
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

        internal static int calculacodigo(String str)
        {
            int id;
            using (SqlConnection connection = new SqlConnection(dataconn))
            {
            
                connection.Open();
                using (SqlCommand command = new SqlCommand(
                "SELECT idRestaurante FROM Restaurante where nome='" +str  + "'", connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        reader.Read();
                        if (reader.HasRows)
                            return id = reader.GetInt32(0);
                        else
                            return -1;
                    }
                }
            }
        }

        public static bool RestauranteExiste(int id)
        {
            using (SqlConnection connection = new SqlConnection(dataconn))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(
                "SELECT * FROM Restaurante where idRestaurante='" + id + "'", connection))
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

        internal static int updates(int idrestaurante,String t1, String t3, String t4)
        {

            using (SqlConnection connection = new SqlConnection(dataconn))
            {
                try
                {
                    connection.Open();
                    string query = "UPDATE Restaurante SET";
                    query += " descricao=\'" + t1 + "\'," + " email =\'" + t3+ "\'"   ;
                    query += "WHERE idRestaurante=" + idrestaurante ;
                    string query1 = "UPDATE TelefoneRestaurante SET";
                    query1 += " numero=" + t4;
                    query1 += "WHERE idRestaurante=" + idrestaurante ;
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.CommandText = query;
                        command.ExecuteNonQuery();
                        command.CommandText = query1;
                        command.ExecuteNonQuery();
                        return 0;
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "Erro SQL!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return -1;
                }
            }
        }
    }
}

