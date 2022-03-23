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
    public partial class frmMenu : Form
    {
        string codigo_user;
        public frmMenu()
        {
            InitializeComponent();
        }
        public frmMenu(string tipo,string codigo)
        {
            InitializeComponent();
            lbl_tipo.Text = tipo;
             codigo_user= codigo;
        }
        private void btn_sair_Click(object sender, EventArgs e)
        {

            this.Visible = false;
            login cad = new login();
            cad.ShowDialog();
            this.Visible = true;
        }

        

      

        private void btn_user_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmperfil cad = new frmperfil();
            cad.ShowDialog();
            this.Visible = true;
        }

        private void btn_produtos_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmprodutos cad = new frmprodutos();
            cad.ShowDialog();
            this.Visible = true;
        }

        private void btn_vendas_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmvendas cad = new frmvendas(codigo_user);
            cad.ShowDialog();
            this.Visible = true;

        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            string tipo = lbl_tipo.Text;
            if(tipo == "vendedor" || tipo =="Vendedor")
            {
                btn_user.Visible = false;
                btn_produtos.Visible = false;
            }
            else
            {
                btn_user.Visible = true;
                btn_produtos.Visible = true;
            }
        }

        private void btn_cadastro_clientes_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmClientes cad = new frmClientes();
            cad.ShowDialog();
            this.Visible = true;
        }
    }
}
