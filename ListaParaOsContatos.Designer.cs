namespace ListaContatos
{
    partial class ListaParaOsContatos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListaParaOsContatos));
            this.BtnSair = new System.Windows.Forms.PictureBox();
            this.DgvContatos = new System.Windows.Forms.DataGridView();
            this.GrbAdicionarContatos = new System.Windows.Forms.GroupBox();
            this.BtnAdicionar = new System.Windows.Forms.Button();
            this.DtpAdicionar = new System.Windows.Forms.DateTimePicker();
            this.LblAniversario = new System.Windows.Forms.Label();
            this.LblTelefone = new System.Windows.Forms.Label();
            this.TxbTelefone = new System.Windows.Forms.TextBox();
            this.LblEmail = new System.Windows.Forms.Label();
            this.TxbEmail = new System.Windows.Forms.TextBox();
            this.lblApresentacao = new System.Windows.Forms.Label();
            this.TxbNome = new System.Windows.Forms.TextBox();
            this.LblNome = new System.Windows.Forms.Label();
            this.GrbEditarContatos = new System.Windows.Forms.GroupBox();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.DtpEditar = new System.Windows.Forms.DateTimePicker();
            this.LblAniversarioEdit = new System.Windows.Forms.Label();
            this.LblTelefoneEdit = new System.Windows.Forms.Label();
            this.TxbTelefoneEdit = new System.Windows.Forms.TextBox();
            this.LblEmailEdit = new System.Windows.Forms.Label();
            this.TxbEmailEdit = new System.Windows.Forms.TextBox();
            this.LblApresentarDoEditar = new System.Windows.Forms.Label();
            this.TxbNomeEdit = new System.Windows.Forms.TextBox();
            this.LblNomeEdit = new System.Windows.Forms.Label();
            this.GrbApagar = new System.Windows.Forms.GroupBox();
            this.BtnApagar = new System.Windows.Forms.Button();
            this.LblApagar = new System.Windows.Forms.Label();
            this.LblDescricao = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BtnSair)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvContatos)).BeginInit();
            this.GrbAdicionarContatos.SuspendLayout();
            this.GrbEditarContatos.SuspendLayout();
            this.GrbApagar.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnSair
            // 
            this.BtnSair.Image = ((System.Drawing.Image)(resources.GetObject("BtnSair.Image")));
            this.BtnSair.Location = new System.Drawing.Point(1140, 2);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(57, 57);
            this.BtnSair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnSair.TabIndex = 0;
            this.BtnSair.TabStop = false;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // DgvContatos
            // 
            this.DgvContatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvContatos.Location = new System.Drawing.Point(12, 2);
            this.DgvContatos.Name = "DgvContatos";
            this.DgvContatos.Size = new System.Drawing.Size(547, 375);
            this.DgvContatos.TabIndex = 1;
            this.DgvContatos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvContatos_CellClick);
            // 
            // GrbAdicionarContatos
            // 
            this.GrbAdicionarContatos.Controls.Add(this.BtnAdicionar);
            this.GrbAdicionarContatos.Controls.Add(this.DtpAdicionar);
            this.GrbAdicionarContatos.Controls.Add(this.LblAniversario);
            this.GrbAdicionarContatos.Controls.Add(this.LblTelefone);
            this.GrbAdicionarContatos.Controls.Add(this.TxbTelefone);
            this.GrbAdicionarContatos.Controls.Add(this.LblEmail);
            this.GrbAdicionarContatos.Controls.Add(this.TxbEmail);
            this.GrbAdicionarContatos.Controls.Add(this.lblApresentacao);
            this.GrbAdicionarContatos.Controls.Add(this.TxbNome);
            this.GrbAdicionarContatos.Controls.Add(this.LblNome);
            this.GrbAdicionarContatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrbAdicionarContatos.ForeColor = System.Drawing.Color.White;
            this.GrbAdicionarContatos.Location = new System.Drawing.Point(22, 383);
            this.GrbAdicionarContatos.Name = "GrbAdicionarContatos";
            this.GrbAdicionarContatos.Size = new System.Drawing.Size(349, 288);
            this.GrbAdicionarContatos.TabIndex = 2;
            this.GrbAdicionarContatos.TabStop = false;
            this.GrbAdicionarContatos.Text = "Adicionar Contatos";
            // 
            // BtnAdicionar
            // 
            this.BtnAdicionar.BackColor = System.Drawing.Color.ForestGreen;
            this.BtnAdicionar.Location = new System.Drawing.Point(82, 239);
            this.BtnAdicionar.Name = "BtnAdicionar";
            this.BtnAdicionar.Size = new System.Drawing.Size(191, 39);
            this.BtnAdicionar.TabIndex = 9;
            this.BtnAdicionar.Text = "ADICIONAR";
            this.BtnAdicionar.UseVisualStyleBackColor = false;
            this.BtnAdicionar.Click += new System.EventHandler(this.BtnAdicionar_Click);
            // 
            // DtpAdicionar
            // 
            this.DtpAdicionar.Location = new System.Drawing.Point(142, 177);
            this.DtpAdicionar.Name = "DtpAdicionar";
            this.DtpAdicionar.Size = new System.Drawing.Size(166, 24);
            this.DtpAdicionar.TabIndex = 8;
            // 
            // LblAniversario
            // 
            this.LblAniversario.AutoSize = true;
            this.LblAniversario.Location = new System.Drawing.Point(30, 180);
            this.LblAniversario.Name = "LblAniversario";
            this.LblAniversario.Size = new System.Drawing.Size(92, 18);
            this.LblAniversario.TabIndex = 7;
            this.LblAniversario.Text = "Aniversario";
            // 
            // LblTelefone
            // 
            this.LblTelefone.AutoSize = true;
            this.LblTelefone.Location = new System.Drawing.Point(44, 141);
            this.LblTelefone.Name = "LblTelefone";
            this.LblTelefone.Size = new System.Drawing.Size(78, 18);
            this.LblTelefone.TabIndex = 6;
            this.LblTelefone.Text = "Telefone:";
            // 
            // TxbTelefone
            // 
            this.TxbTelefone.Location = new System.Drawing.Point(142, 138);
            this.TxbTelefone.Name = "TxbTelefone";
            this.TxbTelefone.Size = new System.Drawing.Size(166, 24);
            this.TxbTelefone.TabIndex = 5;
            // 
            // LblEmail
            // 
            this.LblEmail.AutoSize = true;
            this.LblEmail.Location = new System.Drawing.Point(67, 108);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(55, 18);
            this.LblEmail.TabIndex = 4;
            this.LblEmail.Text = "Email:";
            // 
            // TxbEmail
            // 
            this.TxbEmail.Location = new System.Drawing.Point(142, 105);
            this.TxbEmail.Name = "TxbEmail";
            this.TxbEmail.Size = new System.Drawing.Size(166, 24);
            this.TxbEmail.TabIndex = 3;
            // 
            // lblApresentacao
            // 
            this.lblApresentacao.AutoSize = true;
            this.lblApresentacao.ForeColor = System.Drawing.Color.White;
            this.lblApresentacao.Location = new System.Drawing.Point(44, 34);
            this.lblApresentacao.Name = "lblApresentacao";
            this.lblApresentacao.Size = new System.Drawing.Size(276, 18);
            this.lblApresentacao.TabIndex = 2;
            this.lblApresentacao.Text = "Por favor adicione aqui seu contato";
            // 
            // TxbNome
            // 
            this.TxbNome.Location = new System.Drawing.Point(142, 67);
            this.TxbNome.Name = "TxbNome";
            this.TxbNome.Size = new System.Drawing.Size(166, 24);
            this.TxbNome.TabIndex = 1;
            // 
            // LblNome
            // 
            this.LblNome.AutoSize = true;
            this.LblNome.Location = new System.Drawing.Point(64, 70);
            this.LblNome.Name = "LblNome";
            this.LblNome.Size = new System.Drawing.Size(58, 18);
            this.LblNome.TabIndex = 0;
            this.LblNome.Text = "Nome:";
            // 
            // GrbEditarContatos
            // 
            this.GrbEditarContatos.Controls.Add(this.BtnEditar);
            this.GrbEditarContatos.Controls.Add(this.DtpEditar);
            this.GrbEditarContatos.Controls.Add(this.LblAniversarioEdit);
            this.GrbEditarContatos.Controls.Add(this.LblTelefoneEdit);
            this.GrbEditarContatos.Controls.Add(this.TxbTelefoneEdit);
            this.GrbEditarContatos.Controls.Add(this.LblEmailEdit);
            this.GrbEditarContatos.Controls.Add(this.TxbEmailEdit);
            this.GrbEditarContatos.Controls.Add(this.LblApresentarDoEditar);
            this.GrbEditarContatos.Controls.Add(this.TxbNomeEdit);
            this.GrbEditarContatos.Controls.Add(this.LblNomeEdit);
            this.GrbEditarContatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrbEditarContatos.ForeColor = System.Drawing.Color.White;
            this.GrbEditarContatos.Location = new System.Drawing.Point(392, 383);
            this.GrbEditarContatos.Name = "GrbEditarContatos";
            this.GrbEditarContatos.Size = new System.Drawing.Size(349, 288);
            this.GrbEditarContatos.TabIndex = 10;
            this.GrbEditarContatos.TabStop = false;
            this.GrbEditarContatos.Text = "Editar Contatos";
            // 
            // BtnEditar
            // 
            this.BtnEditar.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtnEditar.Location = new System.Drawing.Point(82, 239);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(191, 39);
            this.BtnEditar.TabIndex = 9;
            this.BtnEditar.Text = "EDITAR";
            this.BtnEditar.UseVisualStyleBackColor = false;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // DtpEditar
            // 
            this.DtpEditar.Location = new System.Drawing.Point(142, 177);
            this.DtpEditar.Name = "DtpEditar";
            this.DtpEditar.Size = new System.Drawing.Size(166, 24);
            this.DtpEditar.TabIndex = 8;
            // 
            // LblAniversarioEdit
            // 
            this.LblAniversarioEdit.AutoSize = true;
            this.LblAniversarioEdit.Location = new System.Drawing.Point(30, 180);
            this.LblAniversarioEdit.Name = "LblAniversarioEdit";
            this.LblAniversarioEdit.Size = new System.Drawing.Size(92, 18);
            this.LblAniversarioEdit.TabIndex = 7;
            this.LblAniversarioEdit.Text = "Aniversario";
            // 
            // LblTelefoneEdit
            // 
            this.LblTelefoneEdit.AutoSize = true;
            this.LblTelefoneEdit.Location = new System.Drawing.Point(10, 141);
            this.LblTelefoneEdit.Name = "LblTelefoneEdit";
            this.LblTelefoneEdit.Size = new System.Drawing.Size(123, 18);
            this.LblTelefoneEdit.TabIndex = 6;
            this.LblTelefoneEdit.Text = "Novo Telefone:";
            // 
            // TxbTelefoneEdit
            // 
            this.TxbTelefoneEdit.Location = new System.Drawing.Point(142, 138);
            this.TxbTelefoneEdit.Name = "TxbTelefoneEdit";
            this.TxbTelefoneEdit.Size = new System.Drawing.Size(166, 24);
            this.TxbTelefoneEdit.TabIndex = 5;
            // 
            // LblEmailEdit
            // 
            this.LblEmailEdit.AutoSize = true;
            this.LblEmailEdit.Location = new System.Drawing.Point(33, 108);
            this.LblEmailEdit.Name = "LblEmailEdit";
            this.LblEmailEdit.Size = new System.Drawing.Size(100, 18);
            this.LblEmailEdit.TabIndex = 4;
            this.LblEmailEdit.Text = "Novo Email:";
            // 
            // TxbEmailEdit
            // 
            this.TxbEmailEdit.Location = new System.Drawing.Point(142, 105);
            this.TxbEmailEdit.Name = "TxbEmailEdit";
            this.TxbEmailEdit.Size = new System.Drawing.Size(166, 24);
            this.TxbEmailEdit.TabIndex = 3;
            // 
            // LblApresentarDoEditar
            // 
            this.LblApresentarDoEditar.AutoSize = true;
            this.LblApresentarDoEditar.ForeColor = System.Drawing.Color.White;
            this.LblApresentarDoEditar.Location = new System.Drawing.Point(88, 34);
            this.LblApresentarDoEditar.Name = "LblApresentarDoEditar";
            this.LblApresentarDoEditar.Size = new System.Drawing.Size(176, 18);
            this.LblApresentarDoEditar.TabIndex = 2;
            this.LblApresentarDoEditar.Text = "Edite seu contato aqui";
            // 
            // TxbNomeEdit
            // 
            this.TxbNomeEdit.Location = new System.Drawing.Point(142, 67);
            this.TxbNomeEdit.Name = "TxbNomeEdit";
            this.TxbNomeEdit.Size = new System.Drawing.Size(166, 24);
            this.TxbNomeEdit.TabIndex = 1;
            // 
            // LblNomeEdit
            // 
            this.LblNomeEdit.AutoSize = true;
            this.LblNomeEdit.Location = new System.Drawing.Point(30, 70);
            this.LblNomeEdit.Name = "LblNomeEdit";
            this.LblNomeEdit.Size = new System.Drawing.Size(103, 18);
            this.LblNomeEdit.TabIndex = 0;
            this.LblNomeEdit.Text = "Novo Nome:";
            // 
            // GrbApagar
            // 
            this.GrbApagar.Controls.Add(this.LblDescricao);
            this.GrbApagar.Controls.Add(this.BtnApagar);
            this.GrbApagar.Controls.Add(this.LblApagar);
            this.GrbApagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrbApagar.ForeColor = System.Drawing.Color.White;
            this.GrbApagar.Location = new System.Drawing.Point(761, 491);
            this.GrbApagar.Name = "GrbApagar";
            this.GrbApagar.Size = new System.Drawing.Size(349, 180);
            this.GrbApagar.TabIndex = 11;
            this.GrbApagar.TabStop = false;
            this.GrbApagar.Text = "Apagar Contatos";
            // 
            // BtnApagar
            // 
            this.BtnApagar.BackColor = System.Drawing.Color.Red;
            this.BtnApagar.Location = new System.Drawing.Point(77, 131);
            this.BtnApagar.Name = "BtnApagar";
            this.BtnApagar.Size = new System.Drawing.Size(197, 39);
            this.BtnApagar.TabIndex = 9;
            this.BtnApagar.Text = "APAGAR";
            this.BtnApagar.UseVisualStyleBackColor = false;
            this.BtnApagar.Click += new System.EventHandler(this.BtnApagar_Click);
            // 
            // LblApagar
            // 
            this.LblApagar.AutoSize = true;
            this.LblApagar.ForeColor = System.Drawing.Color.White;
            this.LblApagar.Location = new System.Drawing.Point(34, 47);
            this.LblApagar.Name = "LblApagar";
            this.LblApagar.Size = new System.Drawing.Size(269, 18);
            this.LblApagar.TabIndex = 2;
            this.LblApagar.Text = "Voce desejas apagar este contato:";
            // 
            // LblDescricao
            // 
            this.LblDescricao.AutoSize = true;
            this.LblDescricao.Location = new System.Drawing.Point(34, 87);
            this.LblDescricao.Name = "LblDescricao";
            this.LblDescricao.Size = new System.Drawing.Size(273, 18);
            this.LblDescricao.TabIndex = 10;
            this.LblDescricao.Text = "Voce desejas apagar este contato?";
            // 
            // ListaParaOsContatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.ClientSize = new System.Drawing.Size(1199, 725);
            this.Controls.Add(this.GrbApagar);
            this.Controls.Add(this.GrbEditarContatos);
            this.Controls.Add(this.GrbAdicionarContatos);
            this.Controls.Add(this.DgvContatos);
            this.Controls.Add(this.BtnSair);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListaParaOsContatos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListaParaOsContatos";
            this.Load += new System.EventHandler(this.ListaParaOsContatos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BtnSair)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvContatos)).EndInit();
            this.GrbAdicionarContatos.ResumeLayout(false);
            this.GrbAdicionarContatos.PerformLayout();
            this.GrbEditarContatos.ResumeLayout(false);
            this.GrbEditarContatos.PerformLayout();
            this.GrbApagar.ResumeLayout(false);
            this.GrbApagar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox BtnSair;
        private System.Windows.Forms.DataGridView DgvContatos;
        private System.Windows.Forms.GroupBox GrbAdicionarContatos;
        private System.Windows.Forms.Label LblNome;
        private System.Windows.Forms.Label LblTelefone;
        private System.Windows.Forms.TextBox TxbTelefone;
        private System.Windows.Forms.Label LblEmail;
        private System.Windows.Forms.TextBox TxbEmail;
        private System.Windows.Forms.Label lblApresentacao;
        private System.Windows.Forms.TextBox TxbNome;
        private System.Windows.Forms.DateTimePicker DtpAdicionar;
        private System.Windows.Forms.Label LblAniversario;
        private System.Windows.Forms.Button BtnAdicionar;
        private System.Windows.Forms.GroupBox GrbEditarContatos;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.DateTimePicker DtpEditar;
        private System.Windows.Forms.Label LblAniversarioEdit;
        private System.Windows.Forms.Label LblTelefoneEdit;
        private System.Windows.Forms.TextBox TxbTelefoneEdit;
        private System.Windows.Forms.Label LblEmailEdit;
        private System.Windows.Forms.TextBox TxbEmailEdit;
        private System.Windows.Forms.Label LblApresentarDoEditar;
        private System.Windows.Forms.TextBox TxbNomeEdit;
        private System.Windows.Forms.Label LblNomeEdit;
        private System.Windows.Forms.GroupBox GrbApagar;
        private System.Windows.Forms.Button BtnApagar;
        private System.Windows.Forms.Label LblApagar;
        private System.Windows.Forms.Label LblDescricao;
    }
}