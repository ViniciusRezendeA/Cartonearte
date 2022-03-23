using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cartonearte.Apresentação
{
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }
        string sql;
        ConexaoBD con = new ConexaoBD();

        private void btn_sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public  void limpar()
        {
            txt_cidade.Clear();
            txt_codigo.Clear();
            txt_email.Clear();
            txt_endereço.Clear();
            txt_idade.Clear();
            txt_nome.Clear();
        }
        public void listar()
        {
            sql = "select*from clientes";
            dtg_listar.DataSource = con.ConsultarTabelas(sql);
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            limpar();
            listar();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            sql = string.Format("delete from clientes where codigo='{0}'", txt_codigo.Text);
            con.AlterarTabelas(sql);
            MessageBox.Show("Cliente Deletado com sucesso!!", "Deletar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            limpar();
            listar();
        }

        private void btn_cadastro_Click(object sender, EventArgs e)
        {
             if (txt_codigo.Text != "" && txt_cidade.Text != "" && txt_email.Text != "" && txt_endereço.Text != "" && txt_idade.Text != "" && txt_nome.Text != "")
            {
                string gmail = txt_email.Text;
                Controle controle = new Controle();
           
                if (controle.validarEmail(gmail) == true)//validação do email
                {
                    controle.conferiremail(txt_email.Text, "clientes");
                    if (controle.msg.Equals(""))
                    {
                        if (controle.tem == true)
                        {
                            MessageBox.Show("Email ja cadastrado!!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        else
                        {
                            sql = string.Format("insert into clientes values(null,'{0}','{1}','{2}','{3}','{4}')", txt_nome.Text, txt_endereço.Text, txt_cidade.Text, txt_email.Text, txt_idade.Text);
                            con.AlterarTabelas(sql);
                            MessageBox.Show("Cliente inseridos com sucesso!!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            limpar();
                            listar();
                        }
                    }
                    else
                    {
                        MessageBox.Show(controle.msg);
                    }
                }
                else
                {
                    MessageBox.Show("Email Invalido!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Complete todos os campos", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            sql = string.Format("update  clientes set  nome='{0}',endereco='{1}',cidade='{2}',email='{3}',idade='{4}' where codigo='{5}';", txt_nome.Text, txt_endereço.Text, txt_cidade.Text, txt_email.Text, txt_idade.Text,txt_codigo.Text);
            con.AlterarTabelas(sql);
            MessageBox.Show("Cliente alterado com sucesso!!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
            limpar();
            listar();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            sql = string.Format("select * from clientes where codigo='{0}';", txt_codigo.Text);
            con.AlterarTabelas(sql);
            DataTable buscar = new DataTable();
            buscar = con.ConsultarTabelas(sql);
            if (buscar.Rows.Count > 0)
            {
                MessageBox.Show("Cliente encontrado com sucesso!!", "Buscar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_codigo.Text = buscar.Rows[0]["codigo"].ToString();
                txt_nome.Text = buscar.Rows[0]["nome"].ToString();
                txt_email.Text = buscar.Rows[0]["email"].ToString();
                txt_endereço.Text = buscar.Rows[0]["endereco"].ToString();
                txt_idade.Text = buscar.Rows[0]["idade"].ToString();
                txt_cidade.Text = buscar.Rows[0]["cidade"].ToString();
            }
            else
            {
                MessageBox.Show("Cliente não esta cadastrado no sistema!!!", "Buscar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dtg_listar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_codigo.Text = dtg_listar.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_nome.Text = dtg_listar.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_endereço.Text = dtg_listar.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_cidade.Text = dtg_listar.Rows[e.RowIndex].Cells[3].Value.ToString();
            txt_email.Text = dtg_listar.Rows[e.RowIndex].Cells[4].Value.ToString();
            txt_idade.Text = dtg_listar.Rows[e.RowIndex].Cells[5].Value.ToString();
         
        }
    }
}
