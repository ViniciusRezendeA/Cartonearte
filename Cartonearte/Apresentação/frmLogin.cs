using Cartonearte.Apresentação;
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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
    

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmCadastro cad = new frmCadastro();
            cad.ShowDialog();
            this.Visible = true;

        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_login_Click(object sender, EventArgs e)
        { 
            Controle controle = new Controle();
            if (txt_email.Text != "" && txt_senha.Text != "")
            {
                controle.acessar(txt_email.Text, txt_senha.Text);
                if (controle.msg.Equals(""))
                {
                    if (controle.tem)
                    {
                        ConexaoBD con = new ConexaoBD();
                        string sql;
                        sql =string.Format("select tipo from usuarios where email ='{0}' and  senha ='{1}';",txt_email.Text, txt_senha.Text);
                        
                        DataTable results = con.ConsultarTabelas(sql);
                        string tipo = String.Join(Environment.NewLine,results.Rows.OfType<DataRow>().Select(x => string.Join(" ; ", x.ItemArray)));
                       
                        sql = string.Format("select codigo from usuarios where email ='{0}' and  senha ='{1}';", txt_email.Text, txt_senha.Text);

                        results = con.ConsultarTabelas(sql);
                        string codigo = String.Join(Environment.NewLine, results.Rows.OfType<DataRow>().Select(x => string.Join(" ; ", x.ItemArray)));

                        MessageBox.Show("Logado com Sucesso", "Entrando", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Visible = false;
                        frmMenu cad = new frmMenu(tipo,codigo);
                        cad.ShowDialog();
                        
                    }
                    else 
                    {
                        MessageBox.Show("login não encontrado, verique login e senha", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show(controle.msg);
                }
            }
            else
            {
                MessageBox.Show("Preencha os campos", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }

        
    } 
}
