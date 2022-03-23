
namespace Cartonearte
{
    partial class frmprodutos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmprodutos));
            this.img_Foto = new System.Windows.Forms.PictureBox();
            this.lbl_codigo = new System.Windows.Forms.Label();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.txt_preco = new System.Windows.Forms.TextBox();
            this.txt_descricao = new System.Windows.Forms.TextBox();
            this.lbl_preco = new System.Windows.Forms.Label();
            this.lbl_descricao = new System.Windows.Forms.Label();
            this.txt_quantidade = new System.Windows.Forms.TextBox();
            this.txt_tamanho = new System.Windows.Forms.TextBox();
            this.lbl_quantidade = new System.Windows.Forms.Label();
            this.lbl_tamanho = new System.Windows.Forms.Label();
            this.dtg_listar = new System.Windows.Forms.DataGridView();
            this.btn_cadastrar = new System.Windows.Forms.Button();
            this.btn_sair = new System.Windows.Forms.Button();
            this.ofd_foto = new System.Windows.Forms.OpenFileDialog();
            this.btn_foto = new System.Windows.Forms.Button();
            this.btn_alterar = new System.Windows.Forms.Button();
            this.btn_deletar = new System.Windows.Forms.Button();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.btn_buscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.img_Foto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_listar)).BeginInit();
            this.SuspendLayout();
            // 
            // img_Foto
            // 
            this.img_Foto.Location = new System.Drawing.Point(423, 17);
            this.img_Foto.Margin = new System.Windows.Forms.Padding(4);
            this.img_Foto.Name = "img_Foto";
            this.img_Foto.Size = new System.Drawing.Size(278, 160);
            this.img_Foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_Foto.TabIndex = 0;
            this.img_Foto.TabStop = false;
            // 
            // lbl_codigo
            // 
            this.lbl_codigo.AutoSize = true;
            this.lbl_codigo.Location = new System.Drawing.Point(33, 29);
            this.lbl_codigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_codigo.Name = "lbl_codigo";
            this.lbl_codigo.Size = new System.Drawing.Size(56, 18);
            this.lbl_codigo.TabIndex = 1;
            this.lbl_codigo.Text = "Codigo";
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(237, 29);
            this.lbl_nome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(49, 18);
            this.lbl_nome.TabIndex = 2;
            this.lbl_nome.Text = "Nome";
            // 
            // txt_codigo
            // 
            this.txt_codigo.Location = new System.Drawing.Point(36, 51);
            this.txt_codigo.Margin = new System.Windows.Forms.Padding(4);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(174, 24);
            this.txt_codigo.TabIndex = 7;
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(240, 51);
            this.txt_nome.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(148, 24);
            this.txt_nome.TabIndex = 8;
            // 
            // txt_preco
            // 
            this.txt_preco.Location = new System.Drawing.Point(240, 153);
            this.txt_preco.Margin = new System.Windows.Forms.Padding(4);
            this.txt_preco.Name = "txt_preco";
            this.txt_preco.Size = new System.Drawing.Size(148, 24);
            this.txt_preco.TabIndex = 12;
            // 
            // txt_descricao
            // 
            this.txt_descricao.Location = new System.Drawing.Point(36, 153);
            this.txt_descricao.Margin = new System.Windows.Forms.Padding(4);
            this.txt_descricao.Multiline = true;
            this.txt_descricao.Name = "txt_descricao";
            this.txt_descricao.Size = new System.Drawing.Size(174, 237);
            this.txt_descricao.TabIndex = 11;
            // 
            // lbl_preco
            // 
            this.lbl_preco.AutoSize = true;
            this.lbl_preco.Location = new System.Drawing.Point(237, 131);
            this.lbl_preco.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_preco.Name = "lbl_preco";
            this.lbl_preco.Size = new System.Drawing.Size(103, 18);
            this.lbl_preco.TabIndex = 10;
            this.lbl_preco.Text = "Preço Unitario";
            // 
            // lbl_descricao
            // 
            this.lbl_descricao.AutoSize = true;
            this.lbl_descricao.Location = new System.Drawing.Point(33, 129);
            this.lbl_descricao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_descricao.Name = "lbl_descricao";
            this.lbl_descricao.Size = new System.Drawing.Size(76, 18);
            this.lbl_descricao.TabIndex = 9;
            this.lbl_descricao.Text = "Descrição";
            // 
            // txt_quantidade
            // 
            this.txt_quantidade.Location = new System.Drawing.Point(240, 101);
            this.txt_quantidade.Margin = new System.Windows.Forms.Padding(4);
            this.txt_quantidade.Name = "txt_quantidade";
            this.txt_quantidade.Size = new System.Drawing.Size(148, 24);
            this.txt_quantidade.TabIndex = 16;
            // 
            // txt_tamanho
            // 
            this.txt_tamanho.Location = new System.Drawing.Point(36, 101);
            this.txt_tamanho.Margin = new System.Windows.Forms.Padding(4);
            this.txt_tamanho.Name = "txt_tamanho";
            this.txt_tamanho.Size = new System.Drawing.Size(174, 24);
            this.txt_tamanho.TabIndex = 15;
            // 
            // lbl_quantidade
            // 
            this.lbl_quantidade.AutoSize = true;
            this.lbl_quantidade.Location = new System.Drawing.Point(237, 79);
            this.lbl_quantidade.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_quantidade.Name = "lbl_quantidade";
            this.lbl_quantidade.Size = new System.Drawing.Size(83, 18);
            this.lbl_quantidade.TabIndex = 14;
            this.lbl_quantidade.Text = "Quantidade";
            this.lbl_quantidade.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_tamanho
            // 
            this.lbl_tamanho.AutoSize = true;
            this.lbl_tamanho.Location = new System.Drawing.Point(33, 79);
            this.lbl_tamanho.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_tamanho.Name = "lbl_tamanho";
            this.lbl_tamanho.Size = new System.Drawing.Size(71, 18);
            this.lbl_tamanho.TabIndex = 13;
            this.lbl_tamanho.Text = "Tamanho";
            // 
            // dtg_listar
            // 
            this.dtg_listar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_listar.Location = new System.Drawing.Point(240, 185);
            this.dtg_listar.Margin = new System.Windows.Forms.Padding(4);
            this.dtg_listar.Name = "dtg_listar";
            this.dtg_listar.Size = new System.Drawing.Size(460, 204);
            this.dtg_listar.TabIndex = 58;
            this.dtg_listar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_listar_CellContentClick);
            // 
            // btn_cadastrar
            // 
            this.btn_cadastrar.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btn_cadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cadastrar.Location = new System.Drawing.Point(36, 398);
            this.btn_cadastrar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_cadastrar.Size = new System.Drawing.Size(174, 40);
            this.btn_cadastrar.TabIndex = 60;
            this.btn_cadastrar.Text = "Cadastrar Produto";
            this.btn_cadastrar.UseVisualStyleBackColor = false;
            this.btn_cadastrar.Click += new System.EventHandler(this.btn_cadastrar_Click);
            // 
            // btn_sair
            // 
            this.btn_sair.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_sair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_sair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sair.Location = new System.Drawing.Point(660, 398);
            this.btn_sair.Margin = new System.Windows.Forms.Padding(4);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_sair.Size = new System.Drawing.Size(40, 40);
            this.btn_sair.TabIndex = 59;
            this.btn_sair.Text = "Sair";
            this.btn_sair.UseVisualStyleBackColor = false;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // ofd_foto
            // 
            this.ofd_foto.FileName = "openFileDialog1";
            // 
            // btn_foto
            // 
            this.btn_foto.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_foto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_foto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_foto.Image = ((System.Drawing.Image)(resources.GetObject("btn_foto.Image")));
            this.btn_foto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_foto.Location = new System.Drawing.Point(411, 398);
            this.btn_foto.Margin = new System.Windows.Forms.Padding(4);
            this.btn_foto.Name = "btn_foto";
            this.btn_foto.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_foto.Size = new System.Drawing.Size(116, 40);
            this.btn_foto.TabIndex = 61;
            this.btn_foto.Text = "Escolher foto..";
            this.btn_foto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_foto.UseVisualStyleBackColor = false;
            this.btn_foto.Click += new System.EventHandler(this.btn_foto_Click);
            // 
            // btn_alterar
            // 
            this.btn_alterar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_alterar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_alterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_alterar.Location = new System.Drawing.Point(240, 398);
            this.btn_alterar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_alterar.Name = "btn_alterar";
            this.btn_alterar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_alterar.Size = new System.Drawing.Size(88, 40);
            this.btn_alterar.TabIndex = 62;
            this.btn_alterar.Text = "Alterar Produto";
            this.btn_alterar.UseVisualStyleBackColor = false;
            this.btn_alterar.Click += new System.EventHandler(this.btn_alterar_Click);
            // 
            // btn_deletar
            // 
            this.btn_deletar.BackColor = System.Drawing.Color.Brown;
            this.btn_deletar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_deletar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_deletar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deletar.ForeColor = System.Drawing.Color.Transparent;
            this.btn_deletar.Location = new System.Drawing.Point(336, 398);
            this.btn_deletar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_deletar.Name = "btn_deletar";
            this.btn_deletar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_deletar.Size = new System.Drawing.Size(67, 40);
            this.btn_deletar.TabIndex = 63;
            this.btn_deletar.Text = "Deletar";
            this.btn_deletar.UseVisualStyleBackColor = false;
            this.btn_deletar.Click += new System.EventHandler(this.btn_deletar_Click);
            // 
            // btn_limpar
            // 
            this.btn_limpar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_limpar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_limpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpar.Location = new System.Drawing.Point(535, 398);
            this.btn_limpar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_limpar.Size = new System.Drawing.Size(47, 40);
            this.btn_limpar.TabIndex = 64;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.UseVisualStyleBackColor = false;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // btn_buscar
            // 
            this.btn_buscar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscar.Location = new System.Drawing.Point(590, 398);
            this.btn_buscar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_buscar.Size = new System.Drawing.Size(50, 40);
            this.btn_buscar.TabIndex = 65;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = false;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // frmprodutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 449);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.btn_deletar);
            this.Controls.Add(this.btn_alterar);
            this.Controls.Add(this.btn_foto);
            this.Controls.Add(this.btn_cadastrar);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.dtg_listar);
            this.Controls.Add(this.txt_quantidade);
            this.Controls.Add(this.txt_tamanho);
            this.Controls.Add(this.lbl_quantidade);
            this.Controls.Add(this.lbl_tamanho);
            this.Controls.Add(this.txt_preco);
            this.Controls.Add(this.txt_descricao);
            this.Controls.Add(this.lbl_preco);
            this.Controls.Add(this.lbl_descricao);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.txt_codigo);
            this.Controls.Add(this.lbl_nome);
            this.Controls.Add(this.lbl_codigo);
            this.Controls.Add(this.img_Foto);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmprodutos";
            this.Text = "Cadastro de Produtos";
            this.Load += new System.EventHandler(this.frmprodutos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.img_Foto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_listar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox img_Foto;
        private System.Windows.Forms.Label lbl_codigo;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.TextBox txt_preco;
        private System.Windows.Forms.TextBox txt_descricao;
        private System.Windows.Forms.Label lbl_preco;
        private System.Windows.Forms.Label lbl_descricao;
        private System.Windows.Forms.TextBox txt_quantidade;
        private System.Windows.Forms.TextBox txt_tamanho;
        private System.Windows.Forms.Label lbl_quantidade;
        private System.Windows.Forms.Label lbl_tamanho;
        private System.Windows.Forms.DataGridView dtg_listar;
        private System.Windows.Forms.Button btn_cadastrar;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.OpenFileDialog ofd_foto;
        private System.Windows.Forms.Button btn_foto;
        private System.Windows.Forms.Button btn_alterar;
        private System.Windows.Forms.Button btn_deletar;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.Button btn_buscar;
    }
}