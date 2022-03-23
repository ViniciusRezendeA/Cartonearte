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
    public partial class frmCadastro : Form
    {
        public frmCadastro()
        {
            InitializeComponent();
        }


        public void Limpar()
        {
            txt_cep.Clear();
            txt_estado.Clear();
            txt_cidade.Clear();
            txt_bairro.Clear();
            txt_rua.Clear();
            txt_numero.Clear();
            txt_nome.Clear();
            txt_email.Clear();
            txt_senha.Clear();
            txt_codigo.Clear();
            txt_cpf.Clear();

            cbx_tipo.SelectedIndex = -1;
        }


        private void frmCadastro_Load(object sender, EventArgs e)
        {
            Limpar();
        }

        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            if (txt_email.Text != "" & txt_senha.Text != "" && txt_nome.Text != "" && txt_cpf.Text != "" && cbx_tipo.Text != "" && txt_cidade.Text != "" && txt_estado.Text != "" && txt_bairro.Text != "" && txt_rua.Text != "" && txt_numero.Text != "" && txt_cep.Text != "")
            {
                Controle controle = new Controle();
               
              
                string gmail = txt_email.Text;
                string mensagem;
                string cpf = txt_cpf.Text;
               
                if (controle.validarEmail(gmail) == true)//validação do email
                {
                    if (controle.IsCpf(cpf))//validação do cpf
                    {
                        //conferir se ja existe no banco de dados
                        controle.conferiremail(txt_email.Text,"usuarios");
                        if (controle.msg.Equals(""))
                        {
                            if (controle.tem == true)
                            {
                                MessageBox.Show("Email ja cadastrado!!","Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                            else
                            {
                                mensagem = "O número é um CPF Válido !";
                                string msg = controle.cadastrar(txt_email.Text, txt_senha.Text, txt_nome.Text, txt_cpf.Text, cbx_tipo.Text, txt_cidade.Text, txt_estado.Text, txt_bairro.Text, txt_rua.Text, txt_numero.Text, txt_cep.Text);
                                if (controle.tem)
                                {
                                    
                                    MessageBox.Show(msg, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.Visible = false;
                                    login cad = new login();
                                    cad.ShowDialog();
                                    this.Visible = true;
                                }
                                else
                                {
                                    MessageBox.Show(msg, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }

                            }
                        }
                        else
                        {
                            MessageBox.Show(controle.msg);
                        }
                    }
                    else
                    {
                        mensagem = "O número é um CPF Inválido !";
                        MessageBox.Show(mensagem);
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
    }
}
    

