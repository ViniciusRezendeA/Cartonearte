using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Cartonearte
{
    public partial class frmprodutos : Form
    {
        public frmprodutos()
        {
            InitializeComponent();
        }
        ConexaoBD con = new ConexaoBD();
        string sql;
        string foto;
      public void limpar()
        {
            txt_codigo.Clear();
            txt_nome.Clear();
            txt_tamanho.Clear();
            txt_quantidade.Clear();
            txt_descricao.Clear();
            txt_preco.Clear();
            img_Foto.Load("F:/Imagens/semfoto.png");
            foto = ("F:/Imagens/semfoto.png");

        }
        public void listar()
        {
            sql = "select*from produtos";
            dtg_listar.DataSource = con.ConsultarTabelas(sql);
        }

        private void btn_foto_Click(object sender, EventArgs e)
        {
            foto = "";
            if(ofd_foto.ShowDialog()==System.Windows.Forms.DialogResult.OK)
            {
                img_Foto.Load(ofd_foto.FileName);
                foto = ofd_foto.FileName;
            }
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            if (txt_nome.Text != "" && txt_tamanho.Text != "" && txt_quantidade.Text != ""  && txt_descricao.Text != "" && txt_preco.Text != "")
            {
                foto = foto.Replace(@"\", @"\\");
                sql = string.Format("insert into produtos values(null,'{0}','{1}','{2}','{3}','{4}','{5}')", txt_nome.Text, txt_tamanho.Text, txt_quantidade.Text, txt_descricao.Text, txt_preco.Text, foto);
                con.AlterarTabelas(sql);
                MessageBox.Show("Produto inseridos com sucesso!!", "Produto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpar();
                listar();
                   

            }
            else
            {
                MessageBox.Show("Complete todos os campos", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmprodutos_Load(object sender, EventArgs e)
        {
            limpar();
            listar();
        }

        private void dtg_listar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_codigo.Text = dtg_listar.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_nome.Text = dtg_listar.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_tamanho.Text = dtg_listar.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_quantidade.Text = dtg_listar.Rows[e.RowIndex].Cells[3].Value.ToString();
            txt_descricao.Text = dtg_listar.Rows[e.RowIndex].Cells[4].Value.ToString();
            txt_preco.Text = dtg_listar.Rows[e.RowIndex].Cells[5].Value.ToString();
            img_Foto.Load(dtg_listar.Rows[e.RowIndex].Cells[6].Value.ToString());
            foto= dtg_listar.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

        private void btn_deletar_Click(object sender, EventArgs e)
        {
            sql = string.Format("delete from produtos where codigo='{0}';", txt_codigo.Text);
            con.AlterarTabelas(sql);
            MessageBox.Show("Produto Deletado com sucesso!!", "Deletar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            limpar();
            listar();
        }
        
        private void btn_alterar_Click(object sender, EventArgs e)
        {
          
         
            if (txt_nome.Text != "" && txt_tamanho.Text != "" && txt_quantidade.Text != "" && txt_descricao.Text != "" && txt_preco.Text != "")
            {
                foto = foto.Replace(@"\", @"\\");
                sql = string.Format("update  produtos set nome='{0}',tamanho='{1}',quantidade='{2}',descricao='{3}',preco='{4}',foto='{5}' where codigo='{6}';", txt_nome.Text, txt_tamanho.Text, txt_quantidade.Text, txt_descricao.Text, txt_preco.Text.Replace(",","."), foto,txt_codigo.Text);
                con.AlterarTabelas(sql);
                MessageBox.Show("Produto Alterado com sucesso!!", "Alterar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpar();
                listar();


            }
            else
            {
                MessageBox.Show("Complete todos os campos", "Alterar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            limpar();
            listar();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            sql = string.Format("select * from produtos where codigo='{0}';", txt_codigo.Text);
            con.AlterarTabelas(sql);
            DataTable buscar = new DataTable();
            buscar = con.ConsultarTabelas(sql);
            if (buscar.Rows.Count > 0)
            {
                MessageBox.Show("Produto encontrado com sucesso!!", "Buscar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_codigo.Text = buscar.Rows[0]["codigo"].ToString();
                txt_nome.Text = buscar.Rows[0]["nome"].ToString();
                txt_tamanho.Text = buscar.Rows[0]["tamanho"].ToString();
                txt_quantidade.Text = buscar.Rows[0]["quantidade"].ToString();
                txt_descricao.Text = buscar.Rows[0]["descricao"].ToString();
                txt_preco.Text = buscar.Rows[0]["preco"].ToString();
                img_Foto.Load(buscar.Rows[0]["foto"].ToString());
               
               
            }
            else
            {
                MessageBox.Show("Produto não esta cadastrado no sistema!!!", "Buscar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
