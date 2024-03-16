namespace SkiParksis
{
    partial class TelaUsuarios
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
            this.lblEmpresa = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnExtrato = new System.Windows.Forms.Button();
            this.btnVeiculos = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btnCadastro = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.lblUsuarios = new System.Windows.Forms.Label();
            this.lblCheckUsuario = new System.Windows.Forms.Label();
            this.dtgListaUsuarios = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataCadastro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBuscaUsuarios = new System.Windows.Forms.TextBox();
            this.lblBuscaUsuarios = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgListaUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.AccessibleDescription = "lblEmpresa";
            this.lblEmpresa.AccessibleName = "lblEmpresa";
            this.lblEmpresa.AutoSize = true;
            this.lblEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblEmpresa.Location = new System.Drawing.Point(41, 21);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(154, 36);
            this.lblEmpresa.TabIndex = 29;
            this.lblEmpresa.Text = "SKI PARK";
            // 
            // btnLogout
            // 
            this.btnLogout.AccessibleDescription = "btnLogout";
            this.btnLogout.AccessibleName = "btnLogout";
            this.btnLogout.Location = new System.Drawing.Point(14, 368);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(192, 46);
            this.btnLogout.TabIndex = 28;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnExtrato
            // 
            this.btnExtrato.AccessibleDescription = "btnExtrato";
            this.btnExtrato.AccessibleName = "btnExtrato";
            this.btnExtrato.Location = new System.Drawing.Point(14, 294);
            this.btnExtrato.Name = "btnExtrato";
            this.btnExtrato.Size = new System.Drawing.Size(192, 46);
            this.btnExtrato.TabIndex = 27;
            this.btnExtrato.Text = "Extrato";
            this.btnExtrato.UseVisualStyleBackColor = true;
            this.btnExtrato.Click += new System.EventHandler(this.btnExtrato_Click);
            // 
            // btnVeiculos
            // 
            this.btnVeiculos.AccessibleDescription = "btnVeiculos";
            this.btnVeiculos.AccessibleName = "btnVeiculos";
            this.btnVeiculos.Location = new System.Drawing.Point(14, 223);
            this.btnVeiculos.Name = "btnVeiculos";
            this.btnVeiculos.Size = new System.Drawing.Size(192, 46);
            this.btnVeiculos.TabIndex = 26;
            this.btnVeiculos.Text = "Veiculos";
            this.btnVeiculos.UseVisualStyleBackColor = true;
            this.btnVeiculos.Click += new System.EventHandler(this.btnVeiculos_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.AccessibleDescription = "btnUsuarios";
            this.btnUsuarios.AccessibleName = "btnUsuarios";
            this.btnUsuarios.Location = new System.Drawing.Point(14, 154);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(192, 46);
            this.btnUsuarios.TabIndex = 25;
            this.btnUsuarios.Text = "Usuários";
            this.btnUsuarios.UseVisualStyleBackColor = true;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // btnCadastro
            // 
            this.btnCadastro.AccessibleDescription = "btnCadastro";
            this.btnCadastro.AccessibleName = "btnCadastro";
            this.btnCadastro.Location = new System.Drawing.Point(14, 92);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Size = new System.Drawing.Size(192, 46);
            this.btnCadastro.TabIndex = 24;
            this.btnCadastro.Text = "Cadastro";
            this.btnCadastro.UseVisualStyleBackColor = true;
            this.btnCadastro.Click += new System.EventHandler(this.btnCadastro_Click);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(225, 450);
            this.splitter1.TabIndex = 23;
            this.splitter1.TabStop = false;
            // 
            // lblUsuarios
            // 
            this.lblUsuarios.AccessibleDescription = "lblUsuarios";
            this.lblUsuarios.AccessibleName = "lblUsuarios";
            this.lblUsuarios.AutoSize = true;
            this.lblUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarios.Location = new System.Drawing.Point(403, 21);
            this.lblUsuarios.Name = "lblUsuarios";
            this.lblUsuarios.Size = new System.Drawing.Size(195, 52);
            this.lblUsuarios.TabIndex = 30;
            this.lblUsuarios.Text = "Usuários";
            // 
            // lblCheckUsuario
            // 
            this.lblCheckUsuario.AccessibleDescription = "lblCheckUsuario";
            this.lblCheckUsuario.AccessibleName = "lblCheckUsuario";
            this.lblCheckUsuario.AutoSize = true;
            this.lblCheckUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckUsuario.Location = new System.Drawing.Point(263, 92);
            this.lblCheckUsuario.Name = "lblCheckUsuario";
            this.lblCheckUsuario.Size = new System.Drawing.Size(479, 36);
            this.lblCheckUsuario.TabIndex = 31;
            this.lblCheckUsuario.Text = "Qual usuário você deseja verificar?";
            // 
            // dtgListaUsuarios
            // 
            this.dtgListaUsuarios.AccessibleDescription = "dtgListaUsuarios";
            this.dtgListaUsuarios.AccessibleName = "dtgListaUsuarios";
            this.dtgListaUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgListaUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nome,
            this.DataCadastro});
            this.dtgListaUsuarios.Location = new System.Drawing.Point(231, 260);
            this.dtgListaUsuarios.Name = "dtgListaUsuarios";
            this.dtgListaUsuarios.RowHeadersWidth = 62;
            this.dtgListaUsuarios.RowTemplate.Height = 28;
            this.dtgListaUsuarios.Size = new System.Drawing.Size(515, 53);
            this.dtgListaUsuarios.TabIndex = 32;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 8;
            this.ID.Name = "ID";
            this.ID.Width = 150;
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.MinimumWidth = 8;
            this.Nome.Name = "Nome";
            this.Nome.Width = 150;
            // 
            // DataCadastro
            // 
            this.DataCadastro.HeaderText = "DataCadastro";
            this.DataCadastro.MinimumWidth = 8;
            this.DataCadastro.Name = "DataCadastro";
            this.DataCadastro.Width = 150;
            // 
            // txtBuscaUsuarios
            // 
            this.txtBuscaUsuarios.AccessibleDescription = "txtBuscaUsuarios";
            this.txtBuscaUsuarios.AccessibleName = "txtBuscaUsuarios";
            this.txtBuscaUsuarios.Location = new System.Drawing.Point(292, 187);
            this.txtBuscaUsuarios.Multiline = true;
            this.txtBuscaUsuarios.Name = "txtBuscaUsuarios";
            this.txtBuscaUsuarios.Size = new System.Drawing.Size(418, 30);
            this.txtBuscaUsuarios.TabIndex = 33;
            // 
            // lblBuscaUsuarios
            // 
            this.lblBuscaUsuarios.AccessibleDescription = "lblBuscaUsuarios";
            this.lblBuscaUsuarios.AccessibleName = "lblBuscaUsuarios";
            this.lblBuscaUsuarios.AutoSize = true;
            this.lblBuscaUsuarios.BackColor = System.Drawing.SystemColors.Window;
            this.lblBuscaUsuarios.Location = new System.Drawing.Point(298, 197);
            this.lblBuscaUsuarios.Name = "lblBuscaUsuarios";
            this.lblBuscaUsuarios.Size = new System.Drawing.Size(240, 20);
            this.lblBuscaUsuarios.TabIndex = 34;
            this.lblBuscaUsuarios.Text = "Digite o nome ou ID do usuário...";
            // 
            // TelaUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblBuscaUsuarios);
            this.Controls.Add(this.txtBuscaUsuarios);
            this.Controls.Add(this.dtgListaUsuarios);
            this.Controls.Add(this.lblCheckUsuario);
            this.Controls.Add(this.lblUsuarios);
            this.Controls.Add(this.lblEmpresa);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnExtrato);
            this.Controls.Add(this.btnVeiculos);
            this.Controls.Add(this.btnUsuarios);
            this.Controls.Add(this.btnCadastro);
            this.Controls.Add(this.splitter1);
            this.Name = "TelaUsuarios";
            this.Text = "TelaUsuarios";
            ((System.ComponentModel.ISupportInitialize)(this.dtgListaUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmpresa;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnExtrato;
        private System.Windows.Forms.Button btnVeiculos;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Button btnCadastro;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Label lblUsuarios;
        private System.Windows.Forms.Label lblCheckUsuario;
        private System.Windows.Forms.DataGridView dtgListaUsuarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataCadastro;
        private System.Windows.Forms.TextBox txtBuscaUsuarios;
        private System.Windows.Forms.Label lblBuscaUsuarios;
    }
}