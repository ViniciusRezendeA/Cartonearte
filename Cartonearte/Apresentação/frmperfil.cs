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
    public partial class frmperfil : Form
    {
        public frmperfil()
        {
            InitializeComponent();
        }

       ConexaoBD con = new ConexaoBD();
        string sql;
        private void btn_alterar_Click(object sender, EventArgs e)
        {

        }

        private void perfil_Load(object sender, EventArgs e)
        {
            listar();
            
        }
        public void listar()
        {
            sql = "select*from usuarios";
            dtg_listar.DataSource = con.ConsultarTabelas(sql);
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_codigo.Text = dtg_listar.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_email.Text = dtg_listar.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_senha.Text = dtg_listar.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_nome.Text = dtg_listar.Rows[e.RowIndex].Cells[3].Value.ToString();
            txt_cpf.Text = dtg_listar.Rows[e.RowIndex].Cells[4].Value.ToString();
            cbx_tipo.Text = dtg_listar.Rows[e.RowIndex].Cells[5].Value.ToString();
            txt_cidade.Text = dtg_listar.Rows[e.RowIndex].Cells[6].Value.ToString();
            txt_estado.Text = dtg_listar.Rows[e.RowIndex].Cells[7].Value.ToString();
            txt_bairro.Text = dtg_listar.Rows[e.RowIndex].Cells[8].Value.ToString();
            txt_rua.Text = dtg_listar.Rows[e.RowIndex].Cells[9].Value.ToString();
            txt_numero.Text = dtg_listar.Rows[e.RowIndex].Cells[10].Value.ToString();
            txt_cep.Text = dtg_listar.Rows[e.RowIndex].Cells[11].Value.ToString();
        
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_alterar_Click_1(object sender, EventArgs e)
        { Controle controle = new Controle();
            string gmail = txt_email.Text;
            if (controle.validarEmail(gmail))
            {
                sql = string.Format("update usuarios set  email = '{1}',senha ='{2}', nome = '{3}', cpf = '{4}', tipo = '{5}',cidade = '{6}',estado= '{7}',bairro= '{8}',rua= '{9}',numero= '{10}',cep= '{11}' where codigo = '{0}';", txt_codigo.Text, txt_email.Text, txt_senha.Text, txt_nome.Text, txt_cpf.Text, cbx_tipo.Text, txt_cidade.Text, txt_estado.Text, txt_bairro.Text, txt_rua.Text, txt_numero.Text, txt_cep.Text);
                con.AlterarTabelas(sql);
                MessageBox.Show("Usuario' alterado com sucesso!!", "Alterar", MessageBoxButtons.OK, MessageBoxIcon.Information);

                listar();
            }
            else
            {
                MessageBox.Show("Email Invalido!", "Alterar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            sql = string.Format("delete from usuarios where codigo='{0}';", txt_codigo.Text);
            con.AlterarTabelas(sql);
            MessageBox.Show("Usuario' Deletado com sucesso!!", "Deletar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listar();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            sql = string.Format("select * from usuarios where codigo='{0}';", txt_codigo.Text);
            con.AlterarTabelas(sql);
            DataTable buscar = new DataTable();
            buscar = con.ConsultarTabelas(sql);
            if (buscar.Rows.Count >0)
            {
                MessageBox.Show("Usuario encontrado com sucesso!!", "Buscar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_codigo.Text = buscar.Rows[0]["codigo"].ToString();
                txt_email.Text = buscar.Rows[0]["email"].ToString();
                txt_senha.Text = buscar.Rows[0]["senha"].ToString();
                txt_nome.Text = buscar.Rows[0]["nome"].ToString();
                txt_cpf.Text = buscar.Rows[0]["cpf"].ToString();
                cbx_tipo.Text = buscar.Rows[0]["tipo"].ToString();
                txt_cidade.Text = buscar.Rows[0]["cidade"].ToString();
                txt_estado.Text = buscar.Rows[0]["estado"].ToString();
                txt_bairro.Text = buscar.Rows[0]["bairro"].ToString();
                txt_rua.Text = buscar.Rows[0]["rua"].ToString();
                txt_numero.Text = buscar.Rows[0]["numero"].ToString();
                txt_cep.Text = buscar.Rows[0]["cep"].ToString();
            }
             else
             {
                    MessageBox.Show("Usuario não esta cadastrado no sistema!!!", "Buscar", MessageBoxButtons.OK, MessageBoxIcon.Information);
             }
            
        }
    }

}
