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
    public partial class TelaCadastro : Form
    {
        public TelaCadastro()
        {
            InitializeComponent();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            TelaUsuarios telaUsuario = new TelaUsuarios();
            telaUsuario.Show();
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {

        }

        private void btnVeiculos_Click(object sender, EventArgs e)
        {
            TelaVeiculos telaVeiculos = new TelaVeiculos();
            telaVeiculos.Show();
        }

        private void btnExtrato_Click(object sender, EventArgs e)
        {
            TelaExtrato telaExtrato = new TelaExtrato();
            telaExtrato.Show();
        }

        private void btnCadUsuarios_Click(object sender, EventArgs e)
        {
            CadUsuario telaCadUsuario = new CadUsuario();
            telaCadUsuario.Show();
        }

        private void btnCadVeiculos_Click(object sender, EventArgs e)
        {
            CadVeiculos telaCadVeiculo = new CadVeiculos();
            telaCadVeiculo.Show();
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
