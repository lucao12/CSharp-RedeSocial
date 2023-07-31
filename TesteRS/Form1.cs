using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Biblioteca;

namespace TesteRS
{
    public partial class Form1 : Form
    {
        Credenciais cadastro = new Credenciais();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            Cadastro app = new Cadastro();
            app.ShowDialog();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            cadastro.setEmail(txtEmail.Text.ToLower());
            cadastro.setSenha(txtSenha.Text);

            CredenciaisBLL.ValidaDadosLogin(cadastro);

            if (Erro.getErro())
            {
                MessageBox.Show(Erro.getMsgErro());
            }
            else
            {
                Rede_Social funcionou = new Rede_Social(cadastro);
                funcionou.ShowDialog();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CredenciaisBLL.Conecta();
            if (Erro.getErro())
            {
                MessageBox.Show(Erro.getMsgErro());
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            CredenciaisBLL.Desconecta();
        }

        private void lblRecuperaSenha_Click(object sender, EventArgs e)
        {
            VerificaEsqueciSenha verifica = new VerificaEsqueciSenha(cadastro);
            verifica.ShowDialog();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (txtSenha.UseSystemPasswordChar == true)
            {
                txtSenha.UseSystemPasswordChar = false;
                btnRevela.IconChar = FontAwesome.Sharp.IconChar.Eye;
            }
            else
            {
                txtSenha.UseSystemPasswordChar = true;
                btnRevela.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
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
