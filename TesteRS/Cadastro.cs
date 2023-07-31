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
using System.Net;
using System.Net.Mail;
using System.IO;

namespace TesteRS
{
    public partial class Cadastro : Form
    {
        Credenciais cadastro = new Credenciais();
        public Cadastro()
        {
            InitializeComponent();
        }

        private void Verificar(object sender, EventArgs e)
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
                    if(temNum == false)
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
                        if(temLetMAI == false)
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
                        if(temLetMIN == false)
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
            if(txtSenha.Text.Length >= 8 && txtSenha.Text.Length <= 20)
            {
                tem8ou20 = true;
            }
            else
            {
                tem8ou20 = false;
            }
            if(temNum == true)
            {
                lblNum.ForeColor = Color.Green;
            }
            else
            {
                lblNum.ForeColor = Color.Red;
            }
            if(temLetMAI == true)
            {
                lblMAI.ForeColor = Color.Green;
            }
            else
            {
                lblMAI.ForeColor = Color.Red;
            }
            if(temLetMIN == true)
            {
                lblMIN.ForeColor = Color.Green;
            }
            else
            {
                lblMIN.ForeColor = Color.Red;
            }
            if(temSim == true)
            {
                lblSim.ForeColor = Color.Green;
            }
            else
            {
                lblSim.ForeColor = Color.Red;
            }
            if(tem8ou20 == true)
            {
                lblvinte.ForeColor = Color.Green;
            }
            else
            {
                lblvinte.ForeColor = Color.Red;
            }
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            cadastro.setEmail(txtEmail.Text.ToLower());
            cadastro.setNome(txtNome.Text);
            cadastro.setApelido(txtApelido.Text);
            cadastro.setNascimento(dtNascimento.Value);
            if(rbMasc.Checked)
            {
                cadastro.setGenero("M");
            }
            if(rbFem.Checked)
            {
                cadastro.setGenero("F");
            }
            if(!rbMasc.Checked && !rbFem.Checked)
            {
                cadastro.setGenero("");
            }
            cadastro.setSenha(txtSenha.Text);
            cadastro.setFotoPerfil("semFoto.png");

            CredenciaisBLL.ValidaDados(cadastro);

            if (Erro.getErro())
            {
                MessageBox.Show(Erro.getMsgErro());
            }
            else
            {
                MessageBox.Show("Cadastro Concluido!");
                Close();
            }
        }

        private void btnRevela_Click(object sender, EventArgs e)
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

        private void Cadastro_Load(object sender, EventArgs e)
        {
            dtNascimento.MaxDate = DateTime.Today;
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
