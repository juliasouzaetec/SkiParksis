using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SkiParksis
{
    public partial class TelaExtrato : Form
    {
        public TelaExtrato()
        {
            InitializeComponent();
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            TelaCadastro telaCadastro = new TelaCadastro();
            telaCadastro.Show();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            TelaUsuarios telaUsuario = new TelaUsuarios();
            telaUsuario.Show();
        }

        private void btnVeiculos_Click(object sender, EventArgs e)
        {
            TelaVeiculos telaVeiculos = new TelaVeiculos();
            telaVeiculos.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Até logo!");
            Application.Exit();
            Form1 telaLogin = new Form1();
            telaLogin.Show();
        }
    }
}
