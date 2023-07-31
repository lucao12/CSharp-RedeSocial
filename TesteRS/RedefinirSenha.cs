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
    public partial class RedefinirSenha : Form
    {
        public Credenciais _cadastro { get; set; }
        public RedefinirSenha()
        {
            InitializeComponent();
        }
        public RedefinirSenha(Credenciais cadastro)
        {
            _cadastro = cadastro;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtSenha.UseSystemPasswordChar == true)
            {
                txtSenha.UseSystemPasswordChar = false;
            }
            else
            {
                txtSenha.UseSystemPasswordChar = true;
            }
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {
            bool temNum = false, temLetMAI = false, temLetMIN = false, temSim = false, tem8ou20 = false;
            foreach (char c in txtSenha.Text)
            {
                if (Char.IsDigit(c))
                {
                    temNum = true;
                }
                else
                {
                    if (temNum == false)
                    {
                        temNum = false;
                    }
                }
                if (Char.IsLetter(c))
                {
                    if (Char.IsUpper(c))
                    {
                        temLetMAI = true;
                    }
                    else
                    {
                        if (temLetMAI == false)
                        {
                            temLetMAI = false;
                        }
                    }
                    if (Char.IsLower(c))
                    {
                        temLetMIN = true;
                    }
                    else
                    {
                        if (temLetMIN == false)
                        {
                            temLetMIN = false;
                        }
                    }
                }
                if (Char.IsSymbol(c) || Char.IsPunctuation(c))
                {
                    temSim = true;
                }
                else
                {
                    if (temSim == false)
                    {
                        temSim = false;
                    }
                }
            }
            if (txtSenha.Text.Length >= 8 && txtSenha.Text.Length <= 20)
            {
                tem8ou20 = true;
            }
            else
            {
                tem8ou20 = false;
            }
            if (temNum == true)
            {
                lblNum.ForeColor = Color.Green;
            }
            else
            {
                lblNum.ForeColor = Color.Red;
            }
            if (temLetMAI == true)
            {
                lblMAI.ForeColor = Color.Green;
            }
            else
            {
                lblMAI.ForeColor = Color.Red;
            }
            if (temLetMIN == true)
            {
                lblMIN.ForeColor = Color.Green;
            }
            else
            {
                lblMIN.ForeColor = Color.Red;
            }
            if (temSim == true)
            {
                lblSim.ForeColor = Color.Green;
            }
            else
            {
                lblSim.ForeColor = Color.Red;
            }
            if (tem8ou20 == true)
            {
                lblvinte.ForeColor = Color.Green;
            }
            else
            {
                lblvinte.ForeColor = Color.Red;
            }
        }

        private void btnVerifica_Click(object sender, EventArgs e)
        {
            _cadastro.setSenha(txtSenha.Text);
            CredenciaisBLL.ValidaSenha(_cadastro);

            if (Erro.getErro())
            {
                MessageBox.Show(Erro.getMsgErro());
            }
            else
            {
                MessageBox.Show("Senha alterada com sucesso!");
                Close();
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
