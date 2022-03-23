using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
namespace Cartonearte
{
    class ConexaoBD
    {
        MySqlConnection con = new MySqlConnection();
       public  ConexaoBD()
        {
            con.ConnectionString = @"persist security info = false; " +
                                         "server=localhost;" +
                                         "database=cartonearte;" +
                                         "uid=root;" +
                                         "pwd=;" +
                                         "SslMode=none";

        }
        
        public MySqlConnection conectar()
        {
            if(con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }
        public void desconectar()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }
        public void AlterarTabelas(string sql)
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }

            MySqlCommand comandos = new MySqlCommand(sql, con);
            comandos.ExecuteNonQuery();
            con.Close();
        }
        public DataTable ConsultarTabelas(string sql)
        {

            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            MySqlDataAdapter consulta = new MySqlDataAdapter(sql, con);
            DataTable resultado = new DataTable();
            consulta.Fill(resultado);
            con.Close();
            return resultado;
        }
    }
}
