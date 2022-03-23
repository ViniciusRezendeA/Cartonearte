using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace Cartonearte
{
    public class LoginDaoComandos
    {
        public bool tem = false;
        public string msg="";
        MySqlCommand cmd = new MySqlCommand();
        ConexaoBD con = new ConexaoBD();
        MySqlDataReader dr;
        public bool verificarLogin(string login, string senha)
        {

            cmd.CommandText = "select*from usuarios where email = @login and senha = @senha";
            cmd.Parameters.AddWithValue("@login", login);
            cmd.Parameters.AddWithValue("@senha", senha);
            try
            {
                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    tem = true;
                }
                con.desconectar();
                dr.Close();
            }
            catch (MySqlException)
            {
                this.msg ="Erro com Banco de dados!";
            }
            return tem;
        }
        public bool verificaremail(string login,string tabela)
        {
            if (tabela == "usuarios")
            {
                cmd.CommandText = "select*from usuarios where email = @login ";
            }
            else if(tabela =="clientes")
            {
                cmd.CommandText = "select*from clientes where email = @login ";
            }
           
            
            cmd.Parameters.AddWithValue("@login", login);
            try
            {
                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    tem = true;
                }
                con.desconectar();
                dr.Close();
            }
            catch (MySqlException)
            {
                this.msg = "Erro com Banco de dados!";
            }
            return tem;
        }


        public string cadastrar( string email, string senha, string nome, string cpf, string tipo, string cidade, string estado, string bairro, string rua,string numero, string cep)
        {
            tem = false;
            cmd.CommandText = "insert into usuarios values(null, @email, @senha, @nome, @cpf, @tipo, @cidade, @estado, @bairro, @rua,@numero,@cep);";

            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@senha", senha);
            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@cpf", cpf);
            cmd.Parameters.AddWithValue("@tipo", tipo);
            cmd.Parameters.AddWithValue("@cidade", cidade);
            cmd.Parameters.AddWithValue("@estado", estado);
            cmd.Parameters.AddWithValue("@bairro", bairro);
            cmd.Parameters.AddWithValue("@rua", rua);
            cmd.Parameters.AddWithValue("@numero", numero);
            cmd.Parameters.AddWithValue("@cep", cep);
         
            try
            {
                cmd.Connection = con.conectar();
                cmd.ExecuteNonQuery();
                con.desconectar();
                this.msg = ("Cadastrado com Suceso!");
                tem = true;
               
            }
            catch (MySqlException)
            {
                this.msg = "Erro com Banco de dados!";
            }
            return msg;
        }
        public string cadastroProduto(string nome, string tamanho, string quantidade, string descricao, string preco, string foto)
        {
            tem = false;
            cmd.CommandText = "insert into produtos values(null, @nome, @tamanho, @quantidade, @descricao, @preco, @foto);";

     
            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@tamanho", tamanho);
            cmd.Parameters.AddWithValue("@quantidade", quantidade);
            cmd.Parameters.AddWithValue("@descricao", descricao);
            cmd.Parameters.AddWithValue("@preco", preco);
            cmd.Parameters.AddWithValue("@foto", foto);
           

            try
            {
                cmd.Connection = con.conectar();
                cmd.ExecuteNonQuery();
                con.desconectar();
                this.msg = ("Cadastrado com Suceso!");
                tem = true;

            }
            catch (MySqlException)
            {
                this.msg = "Erro com Banco de dados!";
            }
            return msg;
        }
        public string vendas(string data_entrega, string data_venda,Double valor, string cliente_cod, string usuario_cod,string tipo)
        {
            tem = false;
            cmd.CommandText = "insert into vendas values(null, @data_entrega, @data_venda, @valor, @cliente_cod, @usuario_cod, @tipo);";


            cmd.Parameters.AddWithValue("@data_entrega", data_entrega);
            cmd.Parameters.AddWithValue("@data_venda", data_venda);
            cmd.Parameters.AddWithValue("@valor", valor);
            cmd.Parameters.AddWithValue("@cliente_cod", cliente_cod);
            cmd.Parameters.AddWithValue("@usuario_cod", usuario_cod);
            cmd.Parameters.AddWithValue("@tipo", tipo);


            try
            {
                cmd.Connection = con.conectar();
                cmd.ExecuteNonQuery();
                con.desconectar();
                this.msg = ("Venda feita com Suceso!");
                tem = true;

            }
            catch (MySqlException)
            {
                this.msg = "Erro com Banco de dados!";
            }
            return msg;
        }
       
    }
    }

