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
    
    public partial class frmvendas : Form
    {
        string descricao = "";
        string codigo_user;
        public frmvendas(string codigo)
        {
            InitializeComponent();
            codigo_user = codigo;
        }
        ConexaoBD con = new ConexaoBD();
        Controle Controle = new Controle();
        string sql;
      
        int quantidade_total = 0;
        // metodo para limpar todos os campos
        public void limpar()
        {
            txt_nome_cliente.Clear();
            txt_codigo_pedido.Clear();
            txt_codigo_produto.Clear();
            txt_codigo_cliente.Clear();
            txt_descricao.Clear();
            txt_numero_venda.Clear();
            txt_quantidade.Clear();
            txt_valor_compra.Clear();
            descricao = "";
            valor_total = 0;
            txt_valor_unitario.Clear();
            dt_venda.Text = DateTime.Now.ToString();
            dt_entrega.Text = DateTime.Now.ToString();
        }
        // variaveis de conexão com Banco de dados
        public void listar()
        {
            sql = "select*from vendas,itens_vendas where numero = Vendas_numero;";
            dtg_listar.DataSource = con.ConsultarTabelas(sql);
        }


        private void frmvendas_Load(object sender, EventArgs e)
        {
            limpar();
            listar();
        }

        
       

        private void btn_sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            sql = string.Format("delete  from itens_vendas where Vendas_numero = '{0}'; ", txt_numero_venda.Text);
            con.AlterarTabelas(sql); 
            sql = string.Format("delete  from vendas where numero = '{0}'; ", txt_numero_venda.Text);
            con.AlterarTabelas(sql);
            MessageBox.Show("Venda Cancelada com Sucesso!!", "Cancelamento", MessageBoxButtons.OK, MessageBoxIcon.Information);
            limpar();
            listar();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            sql = string.Format("select*from vendas,itens_vendas where numero= '{0}'and Vendas_numero = '{0}';", txt_numero_venda.Text);
          
            DataTable buscar = new DataTable();
            buscar = con.ConsultarTabelas(sql);
            if (buscar.Rows.Count > 0)
            {
                MessageBox.Show("Pedido encontrado com sucesso!!", "Buscar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_numero_venda.Text = buscar.Rows[0]["numero"].ToString();
                dt_entrega.Text = buscar.Rows[0]["data_entrega"].ToString();
                dt_venda.Text = buscar.Rows[0]["data_venda"].ToString();
                txt_valor_compra.Text = buscar.Rows[0]["valor"].ToString();
                txt_codigo_cliente.Text = buscar.Rows[0]["Clientes_codigo"].ToString();
                cbx_tipo.Text = buscar.Rows[0]["tipo"].ToString();
                txt_codigo_pedido.Text = buscar.Rows[0]["codigo"].ToString();
                txt_quantidade.Text = buscar.Rows[0]["quantidade"].ToString();
                txt_valor_unitario.Text = buscar.Rows[0]["valor_unitario"].ToString();
                txt_numero_venda.Text = buscar.Rows[0]["Vendas_numero"].ToString();
                txt_codigo_produto.Text = buscar.Rows[0]["Produtos_codigo"].ToString();
                txt_descricao.Text = buscar.Rows[0]["nome"].ToString();
            
           


            }
            else
            {
                MessageBox.Show("Pedido não esta cadastrado no sistema!!!", "Buscar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        
        private void btn_vender_Click(object sender, EventArgs e)
        {
            if (txt_codigo_cliente.Text != ""  && txt_codigo_produto.Text != "" && txt_descricao.Text != "" && txt_nome_cliente.Text != "" && txt_numero_venda.Text != "" && txt_quantidade.Text != "" && txt_valor_compra.Text != "" && txt_valor_unitario.Text != "")
            {
                sql = string.Format("select quantidade from produtos where codigo='{0}';", txt_codigo_produto.Text);
                con.ConsultarTabelas(sql);
                DataTable results = con.ConsultarTabelas(sql);
                string Qnosistema = string.Join(Environment.NewLine,
                  results.Rows.OfType<DataRow>().Select(x => string.Join(" ; ", x.ItemArray))); ;
                int QnoSistema = Convert.ToInt32(Qnosistema);

                if (QnoSistema - quantidade_total >= 0)
                {
                    if (QnoSistema - quantidade_total == 0)
                    {
                        MessageBox.Show("Reabastecer o estoque do produto " + txt_codigo_produto.Text + "!!", "Vender", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    sql = string.Format("update produtos set quantidade='{0}' where codigo='{1}';", QnoSistema - quantidade_total, txt_codigo_produto.Text);
                    con.AlterarTabelas(sql);
                    DateTime data_entrega = DateTime.Parse(dt_entrega.Text);
                    DateTime data_venda = DateTime.Parse(dt_venda.Text);
                    string msg = Controle.vendas(data_entrega.ToString("yyyy-MM-dd"), data_venda.ToString("yyyy-MM-dd"), valor_total, txt_codigo_cliente.Text, codigo_user, cbx_tipo.Text);
                    if (Controle.tem)
                    {

                        MessageBox.Show(msg, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Controle.tem = false;


                        sql = string.Format("insert into itens_vendas value(null,'{0}','{1}','{2}','{3}','{4}')", quantidade_total, txt_valor_unitario.Text.Replace(",", "."), txt_numero_venda.Text, txt_codigo_produto.Text, txt_descricao.Text);
                        con.AlterarTabelas(sql);
                    }
                    else
                    {
                        MessageBox.Show(Controle.msg);
                    }
                    limpar();
                    listar();
                }
                else
                {
                    MessageBox.Show("quantidade indisponivel", "Vender", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else
            {
                MessageBox.Show("Complete todos os campos", "Vender", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
           
        

        private void dtg_listar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_numero_venda.Text = dtg_listar.Rows[e.RowIndex].Cells[0].Value.ToString();
            dt_entrega.Text = dtg_listar.Rows[e.RowIndex].Cells[1].Value.ToString();
            dt_venda.Text = dtg_listar.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_valor_compra.Text = dtg_listar.Rows[e.RowIndex].Cells[3].Value.ToString();
            txt_codigo_cliente.Text = dtg_listar.Rows[e.RowIndex].Cells[4].Value.ToString();
            cbx_tipo.Text = dtg_listar.Rows[e.RowIndex].Cells[6].Value.ToString();
            txt_codigo_pedido.Text = dtg_listar.Rows[e.RowIndex].Cells[7].Value.ToString();
            txt_quantidade.Text = dtg_listar.Rows[e.RowIndex].Cells[8].Value.ToString();
            txt_valor_unitario.Text = dtg_listar.Rows[e.RowIndex].Cells[9].Value.ToString();
            txt_numero_venda.Text = dtg_listar.Rows[e.RowIndex].Cells[10].Value.ToString();
            txt_codigo_produto.Text = dtg_listar.Rows[e.RowIndex].Cells[11].Value.ToString();
            txt_descricao.Text = dtg_listar.Rows[e.RowIndex].Cells[12].Value.ToString();
        }
        string nome;
     
        private void txt_codigo_produto_TextClose(object sender, EventArgs e)
        {
            sql = sql = string.Format("select nome from produtos where codigo='{0}'", txt_codigo_produto.Text);
            con.ConsultarTabelas(sql);
            DataTable results = con.ConsultarTabelas(sql);
            nome = string.Join(Environment.NewLine,
           results.Rows.OfType<DataRow>().Select(x => string.Join(" ; ", x.ItemArray))); ;
            txt_descricao.Text = descricao + nome;
            sql = sql = string.Format("select preco from produtos where codigo='{0}'", txt_codigo_produto.Text);
            con.ConsultarTabelas(sql);
            results = con.ConsultarTabelas(sql);
            txt_valor_unitario.Text = string.Join(Environment.NewLine,
             results.Rows.OfType<DataRow>().Select(x => string.Join(" ; ", x.ItemArray)));
        }
        Double valor_total = 0;
      
        private void txt_codigo_cliente_TextChanged(object sender, EventArgs e)
        {
            sql = sql = string.Format("select nome from clientes where codigo='{0}'", txt_codigo_cliente.Text);
            con.ConsultarTabelas(sql);
            DataTable results = con.ConsultarTabelas(sql);
            string nome = string.Join(Environment.NewLine,
              results.Rows.OfType<DataRow>().Select(x => string.Join(" ; ", x.ItemArray))); ;
            txt_nome_cliente.Text = nome;
        }

        private void txt_nome_cliente_TextChanged(object sender, EventArgs e)
        {
            sql = sql = string.Format("select codigo from clientes where nome ='{0}'", txt_nome_cliente.Text);
            con.ConsultarTabelas(sql);
            DataTable results = con.ConsultarTabelas(sql);
            string codigo = string.Join(Environment.NewLine,
              results.Rows.OfType<DataRow>().Select(x => string.Join(" ; ", x.ItemArray))); ;
            txt_codigo_cliente.Text = codigo;
        }
        Double valor_uni;
        private void txt_quantidade_TextClose(object sender, EventArgs e)
        {
            if (txt_quantidade.Text != "")
            {


                int quantidade = Int32.Parse(txt_quantidade.Text);
                string valor = txt_valor_unitario.Text;
                 valor_uni = Convert.ToDouble(valor);

                valor_total = valor_total + (quantidade * valor_uni);
                txt_valor_compra.Text = "" + valor_total;

                quantidade_total = quantidade_total + quantidade;
               
                descricao = nome + " " + txt_quantidade.Text + descricao + ",";
                txt_descricao.Text = descricao;
            }
            else
            {
                txt_valor_compra.Text = "";
            }
        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            
            
            DateTime data_entrega = DateTime.Parse(dt_entrega.Text);
            DateTime data_venda = DateTime.Parse(dt_venda.Text);
            if (txt_codigo_cliente.Text != "" && txt_codigo_pedido.Text != "" && txt_codigo_produto.Text != "" && txt_descricao.Text != "" && txt_nome_cliente.Text != "" && txt_numero_venda.Text != "" && txt_quantidade.Text != "" && txt_valor_compra.Text != "" && txt_valor_unitario.Text != "")
            {
                sql = string.Format("select quantidade from produtos where codigo='{0}';", txt_codigo_produto.Text);
                con.ConsultarTabelas(sql);
                DataTable results = con.ConsultarTabelas(sql);
                string Qnosistema = string.Join(Environment.NewLine,
                  results.Rows.OfType<DataRow>().Select(x => string.Join(" ; ", x.ItemArray))); ;
                int QnoSistema = Convert.ToInt32(Qnosistema);

                if (QnoSistema - quantidade_total >= 0)
                {
                    if(QnoSistema - quantidade_total == 0)
                    {
                        MessageBox.Show("Reabastecer o estoque do produto "+txt_codigo_produto.Text +"!!", "Alterar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    sql = string.Format("update vendas,itens_vendas set data_entrega ='{1}',data_venda ='{2}',valor='{3}',Clientes_codigo ='{4}',Usuarios_codigo ='{5}',tipo ='{6}',quantidade ='{7}',valor_unitario ='{8}',Produtos_codigo ='{9}',nome ='{10}' where numero='{0}' and Vendas_numero = '{0}'",
                    txt_numero_venda.Text, data_entrega.ToString("yyyy-MM-dd"), data_venda.ToString("yyyy-MM-dd"), txt_valor_compra.Text.Replace(",", "."), txt_codigo_cliente.Text, codigo_user, cbx_tipo.Text, txt_quantidade.Text, txt_valor_unitario.Text.Replace(",", "."), txt_codigo_produto.Text, txt_descricao.Text);
                    con.AlterarTabelas(sql);
                    MessageBox.Show("Pedido Alterado com sucesso!!", "Alterar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpar();
                    listar();
                }
                else
                {
                    
                    MessageBox.Show("quantidade indisponivel", "Vender", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Complete todos os campos", "Alterar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

      
    }
    }


