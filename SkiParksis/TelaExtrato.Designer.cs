namespace SkiParksis
{
    partial class TelaExtrato
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
            this.lblExtratoVeiculos = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Placa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TempoEstadia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.AccessibleDescription = "lblEmpresa";
            this.lblEmpresa.AccessibleName = "lblEmpresa";
            this.lblEmpresa.AutoSize = true;
            this.lblEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblEmpresa.Location = new System.Drawing.Point(39, 27);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(154, 36);
            this.lblEmpresa.TabIndex = 36;
            this.lblEmpresa.Text = "SKI PARK";
            // 
            // btnLogout
            // 
            this.btnLogout.AccessibleDescription = "btnLogout";
            this.btnLogout.AccessibleName = "btnLogout";
            this.btnLogout.Location = new System.Drawing.Point(17, 364);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(192, 46);
            this.btnLogout.TabIndex = 35;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnExtrato
            // 
            this.btnExtrato.AccessibleDescription = "btnExtrato";
            this.btnExtrato.AccessibleName = "btnExtrato";
            this.btnExtrato.Location = new System.Drawing.Point(17, 290);
            this.btnExtrato.Name = "btnExtrato";
            this.btnExtrato.Size = new System.Drawing.Size(192, 46);
            this.btnExtrato.TabIndex = 34;
            this.btnExtrato.Text = "Extrato";
            this.btnExtrato.UseVisualStyleBackColor = true;
            // 
            // btnVeiculos
            // 
            this.btnVeiculos.AccessibleDescription = "btnVeiculos";
            this.btnVeiculos.AccessibleName = "btnVeiculos";
            this.btnVeiculos.Location = new System.Drawing.Point(17, 219);
            this.btnVeiculos.Name = "btnVeiculos";
            this.btnVeiculos.Size = new System.Drawing.Size(192, 46);
            this.btnVeiculos.TabIndex = 33;
            this.btnVeiculos.Text = "Veiculos";
            this.btnVeiculos.UseVisualStyleBackColor = true;
            this.btnVeiculos.Click += new System.EventHandler(this.btnVeiculos_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.AccessibleDescription = "btnUsuarios";
            this.btnUsuarios.AccessibleName = "btnUsuarios";
            this.btnUsuarios.Location = new System.Drawing.Point(17, 150);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(192, 46);
            this.btnUsuarios.TabIndex = 32;
            this.btnUsuarios.Text = "Usuários";
            this.btnUsuarios.UseVisualStyleBackColor = true;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // btnCadastro
            // 
            this.btnCadastro.AccessibleDescription = "btnCadastro";
            this.btnCadastro.AccessibleName = "btnCadastro";
            this.btnCadastro.Location = new System.Drawing.Point(17, 88);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Size = new System.Drawing.Size(192, 46);
            this.btnCadastro.TabIndex = 31;
            this.btnCadastro.Text = "Cadastro";
            this.btnCadastro.UseVisualStyleBackColor = true;
            this.btnCadastro.Click += new System.EventHandler(this.btnCadastro_Click);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(225, 450);
            this.splitter1.TabIndex = 30;
            this.splitter1.TabStop = false;
            // 
            // lblExtratoVeiculos
            // 
            this.lblExtratoVeiculos.AccessibleDescription = "lblExtratoVeiculos";
            this.lblExtratoVeiculos.AccessibleName = "lblExtratoVeiculos";
            this.lblExtratoVeiculos.AutoSize = true;
            this.lblExtratoVeiculos.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExtratoVeiculos.Location = new System.Drawing.Point(328, 27);
            this.lblExtratoVeiculos.Name = "lblExtratoVeiculos";
            this.lblExtratoVeiculos.Size = new System.Drawing.Size(397, 52);
            this.lblExtratoVeiculos.TabIndex = 37;
            this.lblExtratoVeiculos.Text = "Extrato de Veículos";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Placa,
            this.Modelo,
            this.TempoEstadia});
            this.dataGridView1.Location = new System.Drawing.Point(254, 127);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(514, 55);
            this.dataGridView1.TabIndex = 38;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // TempoEstadia
            // 
            this.TempoEstadia.HeaderText = "TempoEstadia";
            this.TempoEstadia.MinimumWidth = 8;
            this.TempoEstadia.Name = "TempoEstadia";
            this.TempoEstadia.Width = 150;
            // 
            // TelaExtrato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblExtratoVeiculos);
            this.Controls.Add(this.lblEmpresa);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnExtrato);
            this.Controls.Add(this.btnVeiculos);
            this.Controls.Add(this.btnUsuarios);
            this.Controls.Add(this.btnCadastro);
            this.Controls.Add(this.splitter1);
            this.Name = "TelaExtrato";
            this.Text = "TelaExtrato";
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
        private System.Windows.Forms.Label lblExtratoVeiculos;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Placa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn TempoEstadia;
    }
}