using System;
using System.Windows.Forms;

namespace SkiParksis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAcessar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                MessageBox.Show("Usuário é obrigatório");
            }
            else if (txtSenha.Text == "")
            {
                MessageBox.Show("Senha é obrigatória");
            }
            else
            {
                if (txtUsuario.Text == "etec" && txtSenha.Text == "etec")
                {
                    MessageBox.Show("Seja bem-vindo!");
                    MenuInicial telamenuInicial = new MenuInicial();
                    telamenuInicial.Show();
                }
                else
                {
                    MessageBox.Show("Usuário ou Senha inválidos!");
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
