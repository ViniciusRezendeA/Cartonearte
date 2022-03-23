
namespace Cartonearte.Apresentação
{
    partial class frmvendas
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
            this.dt_entrega = new System.Windows.Forms.DateTimePicker();
            this.dt_venda = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_codigo_cliente = new System.Windows.Forms.TextBox();
            this.txt_nome_cliente = new System.Windows.Forms.TextBox();
            this.txt_numero_venda = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dtg_listar = new System.Windows.Forms.DataGridView();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_alterar = new System.Windows.Forms.Button();
            this.btn_sair = new System.Windows.Forms.Button();
            this.btn_vender = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_descricao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_valor_compra = new System.Windows.Forms.TextBox();
            this.lbl_codigo = new System.Windows.Forms.Label();
            this.lbl_valor_unitario = new System.Windows.Forms.Label();
            this.txt_codigo_pedido = new System.Windows.Forms.TextBox();
            this.txt_valor_unitario = new System.Windows.Forms.TextBox();
            this.cbx_tipo = new System.Windows.Forms.ComboBox();
            this.lbl_quantidade = new System.Windows.Forms.Label();
            this.txt_quantidade = new System.Windows.Forms.TextBox();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.lbl_codigo_produto = new System.Windows.Forms.Label();
            this.txt_codigo_produto = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_listar)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dt_entrega
            // 
            this.dt_entrega.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_entrega.Location = new System.Drawing.Point(252, 85);
            this.dt_entrega.Name = "dt_entrega";
            this.dt_entrega.Size = new System.Drawing.Size(212, 20);
            this.dt_entrega.TabIndex = 3;
            // 
            // dt_venda
            // 
            this.dt_venda.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_venda.Location = new System.Drawing.Point(22, 85);
            this.dt_venda.Name = "dt_venda";
            this.dt_venda.Size = new System.Drawing.Size(216, 20);
            this.dt_venda.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Data de Venda";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(249, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Data de Entrega";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Codigo do Cliente";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(129, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Nome do Cliente";
            // 
            // txt_codigo_cliente
            // 
            this.txt_codigo_cliente.Location = new System.Drawing.Point(22, 41);
            this.txt_codigo_cliente.Name = "txt_codigo_cliente";
            this.txt_codigo_cliente.Size = new System.Drawing.Size(100, 20);
            this.txt_codigo_cliente.TabIndex = 9;
            this.txt_codigo_cliente.TextChanged += new System.EventHandler(this.txt_codigo_cliente_TextChanged);
            // 
            // txt_nome_cliente
            // 
            this.txt_nome_cliente.Location = new System.Drawing.Point(132, 41);
            this.txt_nome_cliente.Name = "txt_nome_cliente";
            this.txt_nome_cliente.Size = new System.Drawing.Size(106, 20);
            this.txt_nome_cliente.TabIndex = 10;
            this.txt_nome_cliente.LostFocus += new System.EventHandler(this.txt_nome_cliente_TextChanged);
            // 
            // txt_numero_venda
            // 
            this.txt_numero_venda.Location = new System.Drawing.Point(252, 41);
            this.txt_numero_venda.Name = "txt_numero_venda";
            this.txt_numero_venda.Size = new System.Drawing.Size(100, 20);
            this.txt_numero_venda.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(249, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Numero da venda";
            // 
            // dtg_listar
            // 
            this.dtg_listar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_listar.Location = new System.Drawing.Point(15, 253);
            this.dtg_listar.Name = "dtg_listar";
            this.dtg_listar.Size = new System.Drawing.Size(479, 141);
            this.dtg_listar.TabIndex = 29;
            this.dtg_listar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_listar_CellContentClick);
            // 
            // btn_buscar
            // 
            this.btn_buscar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_buscar.Location = new System.Drawing.Point(208, 400);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(79, 34);
            this.btn_buscar.TabIndex = 63;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = false;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.Brown;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_delete.ForeColor = System.Drawing.Color.White;
            this.btn_delete.Location = new System.Drawing.Point(293, 400);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(116, 34);
            this.btn_delete.TabIndex = 62;
            this.btn_delete.Text = "Cancelar Venda";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_alterar
            // 
            this.btn_alterar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_alterar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_alterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_alterar.Location = new System.Drawing.Point(15, 401);
            this.btn_alterar.Name = "btn_alterar";
            this.btn_alterar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_alterar.Size = new System.Drawing.Size(79, 33);
            this.btn_alterar.TabIndex = 61;
            this.btn_alterar.Text = "Alterar";
            this.btn_alterar.UseVisualStyleBackColor = false;
            this.btn_alterar.Click += new System.EventHandler(this.btn_alterar_Click);
            // 
            // btn_sair
            // 
            this.btn_sair.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_sair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_sair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sair.Location = new System.Drawing.Point(415, 400);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_sair.Size = new System.Drawing.Size(79, 34);
            this.btn_sair.TabIndex = 60;
            this.btn_sair.Text = "Sair";
            this.btn_sair.UseVisualStyleBackColor = false;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // btn_vender
            // 
            this.btn_vender.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btn_vender.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_vender.ForeColor = System.Drawing.Color.White;
            this.btn_vender.Location = new System.Drawing.Point(100, 401);
            this.btn_vender.Name = "btn_vender";
            this.btn_vender.Size = new System.Drawing.Size(102, 34);
            this.btn_vender.TabIndex = 64;
            this.btn_vender.Text = "Confirmar Venda";
            this.btn_vender.UseVisualStyleBackColor = false;
            this.btn_vender.Click += new System.EventHandler(this.btn_vender_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_codigo_cliente);
            this.groupBox1.Controls.Add(this.dt_entrega);
            this.groupBox1.Controls.Add(this.dt_venda);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt_nome_cliente);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txt_numero_venda);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(15, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(479, 111);
            this.groupBox1.TabIndex = 65;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informações do Cliente";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_descricao);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txt_valor_compra);
            this.groupBox2.Controls.Add(this.lbl_codigo);
            this.groupBox2.Controls.Add(this.lbl_valor_unitario);
            this.groupBox2.Controls.Add(this.txt_codigo_pedido);
            this.groupBox2.Controls.Add(this.txt_valor_unitario);
            this.groupBox2.Controls.Add(this.cbx_tipo);
            this.groupBox2.Controls.Add(this.lbl_quantidade);
            this.groupBox2.Controls.Add(this.txt_quantidade);
            this.groupBox2.Controls.Add(this.lbl_nome);
            this.groupBox2.Controls.Add(this.lbl_codigo_produto);
            this.groupBox2.Controls.Add(this.txt_codigo_produto);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(15, 129);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(479, 118);
            this.groupBox2.TabIndex = 66;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informações do Pedido";
            // 
            // txt_descricao
            // 
            this.txt_descricao.Location = new System.Drawing.Point(251, 41);
            this.txt_descricao.Name = "txt_descricao";
            this.txt_descricao.Size = new System.Drawing.Size(212, 20);
            this.txt_descricao.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Forma de Pagamento";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(357, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Valor da Compra";
            // 
            // txt_valor_compra
            // 
            this.txt_valor_compra.Location = new System.Drawing.Point(360, 89);
            this.txt_valor_compra.Name = "txt_valor_compra";
            this.txt_valor_compra.Size = new System.Drawing.Size(100, 20);
            this.txt_valor_compra.TabIndex = 12;
            // 
            // lbl_codigo
            // 
            this.lbl_codigo.AutoSize = true;
            this.lbl_codigo.Location = new System.Drawing.Point(18, 25);
            this.lbl_codigo.Name = "lbl_codigo";
            this.lbl_codigo.Size = new System.Drawing.Size(50, 13);
            this.lbl_codigo.TabIndex = 15;
            this.lbl_codigo.Text = "Codigo ";
            // 
            // lbl_valor_unitario
            // 
            this.lbl_valor_unitario.AutoSize = true;
            this.lbl_valor_unitario.Location = new System.Drawing.Point(129, 73);
            this.lbl_valor_unitario.Name = "lbl_valor_unitario";
            this.lbl_valor_unitario.Size = new System.Drawing.Size(84, 13);
            this.lbl_valor_unitario.TabIndex = 16;
            this.lbl_valor_unitario.Text = "Valor Unitario";
            // 
            // txt_codigo_pedido
            // 
            this.txt_codigo_pedido.Location = new System.Drawing.Point(21, 41);
            this.txt_codigo_pedido.Name = "txt_codigo_pedido";
            this.txt_codigo_pedido.Size = new System.Drawing.Size(100, 20);
            this.txt_codigo_pedido.TabIndex = 17;
            // 
            // txt_valor_unitario
            // 
            this.txt_valor_unitario.Location = new System.Drawing.Point(131, 89);
            this.txt_valor_unitario.Name = "txt_valor_unitario";
            this.txt_valor_unitario.Size = new System.Drawing.Size(100, 20);
            this.txt_valor_unitario.TabIndex = 18;
            // 
            // cbx_tipo
            // 
            this.cbx_tipo.AutoCompleteCustomSource.AddRange(new string[] {
            "Credito ",
            "Debito",
            "Pix",
            "Dinheiro vivo"});
            this.cbx_tipo.FormattingEnabled = true;
            this.cbx_tipo.Items.AddRange(new object[] {
            "A vista",
            "Cartão Debito",
            "Cartão Credito",
            "PIX"});
            this.cbx_tipo.Location = new System.Drawing.Point(18, 89);
            this.cbx_tipo.Name = "cbx_tipo";
            this.cbx_tipo.Size = new System.Drawing.Size(99, 21);
            this.cbx_tipo.TabIndex = 28;
            // 
            // lbl_quantidade
            // 
            this.lbl_quantidade.AutoSize = true;
            this.lbl_quantidade.Location = new System.Drawing.Point(248, 73);
            this.lbl_quantidade.Name = "lbl_quantidade";
            this.lbl_quantidade.Size = new System.Drawing.Size(72, 13);
            this.lbl_quantidade.TabIndex = 19;
            this.lbl_quantidade.Text = "Quantidade";
            // 
            // txt_quantidade
            // 
            this.txt_quantidade.Location = new System.Drawing.Point(251, 89);
            this.txt_quantidade.Name = "txt_quantidade";
            this.txt_quantidade.Size = new System.Drawing.Size(59, 20);
            this.txt_quantidade.TabIndex = 20;
            this.txt_quantidade.LostFocus += new System.EventHandler(this.txt_quantidade_TextClose);
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(248, 25);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(125, 13);
            this.lbl_nome.TabIndex = 24;
            this.lbl_nome.Text = "Descrição do Pedido";
            // 
            // lbl_codigo_produto
            // 
            this.lbl_codigo_produto.AutoSize = true;
            this.lbl_codigo_produto.Location = new System.Drawing.Point(128, 25);
            this.lbl_codigo_produto.Name = "lbl_codigo_produto";
            this.lbl_codigo_produto.Size = new System.Drawing.Size(112, 13);
            this.lbl_codigo_produto.TabIndex = 21;
            this.lbl_codigo_produto.Text = "Codigo do Produto";
            // 
            // txt_codigo_produto
            // 
            this.txt_codigo_produto.Location = new System.Drawing.Point(131, 41);
            this.txt_codigo_produto.Name = "txt_codigo_produto";
            this.txt_codigo_produto.Size = new System.Drawing.Size(106, 20);
            this.txt_codigo_produto.TabIndex = 22;
       
            this.txt_codigo_produto.LostFocus += new System.EventHandler(this.txt_codigo_produto_TextClose);
            // 
            // frmvendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 446);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_vender);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_alterar);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.dtg_listar);
            this.Name = "frmvendas";
            this.Text = "frmvendas";
            this.Load += new System.EventHandler(this.frmvendas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_listar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dt_entrega;
        private System.Windows.Forms.DateTimePicker dt_venda;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_codigo_cliente;
        private System.Windows.Forms.TextBox txt_nome_cliente;
        private System.Windows.Forms.TextBox txt_numero_venda;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dtg_listar;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_alterar;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.Button btn_vender;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_descricao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_valor_compra;
        private System.Windows.Forms.Label lbl_codigo;
        private System.Windows.Forms.Label lbl_valor_unitario;
        private System.Windows.Forms.TextBox txt_codigo_pedido;
        private System.Windows.Forms.TextBox txt_valor_unitario;
        private System.Windows.Forms.ComboBox cbx_tipo;
        private System.Windows.Forms.Label lbl_quantidade;
        private System.Windows.Forms.TextBox txt_quantidade;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Label lbl_codigo_produto;
        private System.Windows.Forms.TextBox txt_codigo_produto;
    }
}