using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca;

namespace TesteRS
{
    public partial class VerificaEsqueciSenha : Form
    {
        public Credenciais _cadastro { get; set; }
        public VerificaEsqueciSenha()
        {
            InitializeComponent();
        }
        public VerificaEsqueciSenha(Credenciais cadastro)
        {
            _cadastro = cadastro;
            InitializeComponent();
        }

        private void btnVerifica_Click(object sender, EventArgs e)
        {
            _cadastro.setEmail(txtEmail.Text.ToLower());
            CredenciaisBLL.ValidaDadosEsqueci(_cadastro);

            if (Erro.getErro())
            {
                MessageBox.Show(Erro.getMsgErro());
            }
            else
            {
                MessageBox.Show("Email verificado!");
                Close();
                RedefinirSenha senha = new RedefinirSenha(_cadastro);
                senha.ShowDialog();
            }
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private Point lastPoint;

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
    }
}
