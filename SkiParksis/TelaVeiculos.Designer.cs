namespace SkiParksis
{
    partial class TelaVeiculos
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
            this.lblVeiculos = new System.Windows.Forms.Label();
            this.lblCheckVeiculos = new System.Windows.Forms.Label();
            this.txtBuscaVeiculos = new System.Windows.Forms.TextBox();
            this.lblBuscaVeiculos = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Placa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataCadastro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.AccessibleDescription = "lblEmpresa";
            this.lblEmpresa.AccessibleName = "lblEmpresa";
            this.lblEmpresa.AutoSize = true;
            this.lblEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblEmpresa.Location = new System.Drawing.Point(39, 19);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(154, 36);
            this.lblEmpresa.TabIndex = 29;
            this.lblEmpresa.Text = "SKI PARK";
            // 
            // btnLogout
            // 
            this.btnLogout.AccessibleDescription = "btnLogout";
            this.btnLogout.AccessibleName = "btnLogout";
            this.btnLogout.Location = new System.Drawing.Point(17, 356);
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
            this.btnExtrato.Location = new System.Drawing.Point(17, 282);
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
            this.btnVeiculos.Location = new System.Drawing.Point(17, 211);
            this.btnVeiculos.Name = "btnVeiculos";
            this.btnVeiculos.Size = new System.Drawing.Size(192, 46);
            this.btnVeiculos.TabIndex = 26;
            this.btnVeiculos.Text = "Veiculos";
            this.btnVeiculos.UseVisualStyleBackColor = true;
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.AccessibleDescription = "btnUsuarios";
            this.btnUsuarios.AccessibleName = "btnUsuarios";
            this.btnUsuarios.Location = new System.Drawing.Point(17, 142);
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
            this.btnCadastro.Location = new System.Drawing.Point(17, 80);
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
            // lblVeiculos
            // 
            this.lblVeiculos.AccessibleDescription = "lblVeiculos";
            this.lblVeiculos.AccessibleName = "lblVeiculos";
            this.lblVeiculos.AutoSize = true;
            this.lblVeiculos.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVeiculos.Location = new System.Drawing.Point(405, 28);
            this.lblVeiculos.Name = "lblVeiculos";
            this.lblVeiculos.Size = new System.Drawing.Size(187, 52);
            this.lblVeiculos.TabIndex = 31;
            this.lblVeiculos.Text = "Veiculos";
            // 
            // lblCheckVeiculos
            // 
            this.lblCheckVeiculos.AccessibleDescription = "lblCheckVeiculos";
            this.lblCheckVeiculos.AccessibleName = "lblCheckVeiculos";
            this.lblCheckVeiculos.AutoSize = true;
            this.lblCheckVeiculos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckVeiculos.Location = new System.Drawing.Point(259, 90);
            this.lblCheckVeiculos.Name = "lblCheckVeiculos";
            this.lblCheckVeiculos.Size = new System.Drawing.Size(492, 36);
            this.lblCheckVeiculos.TabIndex = 32;
            this.lblCheckVeiculos.Text = "Qual veiculo você deseja consultar?";
            // 
            // txtBuscaVeiculos
            // 
            this.txtBuscaVeiculos.AccessibleDescription = "txtBuscaVeiculos";
            this.txtBuscaVeiculos.AccessibleName = "txtBuscaVeiculos";
            this.txtBuscaVeiculos.Location = new System.Drawing.Point(332, 162);
            this.txtBuscaVeiculos.Name = "txtBuscaVeiculos";
            this.txtBuscaVeiculos.Size = new System.Drawing.Size(351, 26);
            this.txtBuscaVeiculos.TabIndex = 33;
            // 
            // lblBuscaVeiculos
            // 
            this.lblBuscaVeiculos.AccessibleDescription = "lblBuscaVeiculos";
            this.lblBuscaVeiculos.AccessibleName = "lblBuscaVeiculos";
            this.lblBuscaVeiculos.AutoSize = true;
            this.lblBuscaVeiculos.BackColor = System.Drawing.SystemColors.Window;
            this.lblBuscaVeiculos.Location = new System.Drawing.Point(338, 168);
            this.lblBuscaVeiculos.Name = "lblBuscaVeiculos";
            this.lblBuscaVeiculos.Size = new System.Drawing.Size(191, 20);
            this.lblBuscaVeiculos.TabIndex = 34;
            this.lblBuscaVeiculos.Text = "Digite a placa do veiculo...";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Placa,
            this.Modelo,
            this.DataCadastro});
            this.dataGridView1.Location = new System.Drawing.Point(231, 242);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(514, 55);
            this.dataGridView1.TabIndex = 35;
            // 
            // Placa
            // 
            this.Placa.HeaderText = "Placa";
            this.Placa.MinimumWidth = 8;
            this.Placa.Name = "Placa";
            this.Placa.Width = 150;
            // 
            // Modelo
            // 
            this.Modelo.HeaderText = "Modelo";
            this.Modelo.MinimumWidth = 8;
            this.Modelo.Name = "Modelo";
            this.Modelo.Width = 150;
            // 
            // DataCadastro
            // 
            this.DataCadastro.HeaderText = "DataCadastro";
            this.DataCadastro.MinimumWidth = 8;
            this.DataCadastro.Name = "DataCadastro";
            this.DataCadastro.Width = 150;
            // 
            // TelaVeiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblBuscaVeiculos);
            this.Controls.Add(this.txtBuscaVeiculos);
            this.Controls.Add(this.lblCheckVeiculos);
            this.Controls.Add(this.lblVeiculos);
            this.Controls.Add(this.lblEmpresa);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnExtrato);
            this.Controls.Add(this.btnVeiculos);
            this.Controls.Add(this.btnUsuarios);
            this.Controls.Add(this.btnCadastro);
            this.Controls.Add(this.splitter1);
            this.Name = "TelaVeiculos";
            this.Text = "TelaVeiculos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.Label lblVeiculos;
        private System.Windows.Forms.Label lblCheckVeiculos;
        private System.Windows.Forms.TextBox txtBuscaVeiculos;
        private System.Windows.Forms.Label lblBuscaVeiculos;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Placa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataCadastro;
    }
}