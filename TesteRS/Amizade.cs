using Biblioteca;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TesteRS
{
    public partial class Amizade : Form
    {
        Credenciais cadastro { get; set; }
        public Amizade()
        {
            InitializeComponent();
        }
        public Amizade(Credenciais _cadastro)
        {
            cadastro = _cadastro;
            InitializeComponent();
        }

        private void Amizade_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtAmigo.ContainsFocus)
            {
                this.ActiveControl = null;
            }
        }
        private void txtAmigo_Enter(object sender, EventArgs e)
        {
            if (txtAmigo.Text == "Nome do amigo")
            {
                txtAmigo.Text = "";
                txtAmigo.ForeColor = SystemColors.WindowText;
            }
        }

        private void txtAmigo_Leave(object sender, EventArgs e)
        {
            this.ActiveControl = null;
            if (txtAmigo.Text == "")
            {
                txtAmigo.Text = "Nome do amigo";
                txtAmigo.ForeColor = SystemColors.GrayText;
            }
        }

        private void btnLupa_Click(object sender, EventArgs e)
        {
            if(txtAmigo.Text == "Nome do amigo")
            {
                List<string> amigo = new List<string>();
                cadastro.ClearAmigos();
                amigo = CredenciaisBLL.SelecionaTodosUsuarios(cadastro);
                listBox1.Items.Clear();
                foreach (string a in amigo)
                {
                    bool contemNaListaAmigos = false;
                    foreach (string item in listaAmigos.Items)
                    {
                        if (a.Contains(item))
                        {
                            cadastro.getAmigos().RemoveAt(0);
                            contemNaListaAmigos = true;
                            break;
                        }
                    }

                    if (!contemNaListaAmigos)
                    {
                        listBox1.Items.Add(a);
                    }
                }
                listBox1.Visible = true;
            }
            else
            {
                cadastro.setAmigo(txtAmigo.Text);
                List<string> amigo = new List<string>();
                cadastro.ClearAmigos();
                amigo = CredenciaisBLL.SelecionaUsuarios(cadastro);
                listBox1.Items.Clear();
                foreach (string a in amigo)
                {
                    listBox1.Items.Add(a);
                }
                listBox1.Visible = true;
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<string> ami = new List<string>();
            ami = cadastro.getAmigos();

            int index = listBox1.SelectedIndex;

            cadastro.setEmailAmigo(ami[index]);
            DialogResult dialogo;
            dialogo = MessageBox.Show("Deseja Adicionar este perfil como amigo?", "Amizade", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogo == DialogResult.Yes)
            {
                CredenciaisBLL.Amizade(cadastro);
                if (Erro.getErro())
                {
                    MessageBox.Show(Erro.getMsgErro());
                }
                else
                {
                    MessageBox.Show("Pedido enviado");
                }
            }
        }

        private void Amizade_Load(object sender, EventArgs e)
        {
            cadastro.ClearAmigos();
            CredenciaisBLL.VerificaAmizade(cadastro);

            if (cadastro.getAmigos().Count > 0)
            {
                btnSolicita.Visible = true;
                if (cadastro.getAmigos().Count > 9) { btnSolicita.Text = "9+"; }
                else { btnSolicita.Text = $"{cadastro.getAmigos().Count}"; }

            }
            else
            {
                btnSolicita.Visible = false;
            }

            List<string> amigos = CredenciaisBLL.SeusAmigos(cadastro);
            foreach (string amigo in amigos)
            {
                listaAmigos.Items.Add(amigo);
            }

        }
        private void AbreForm(object sender, EventArgs e)
        {
            int i = cadastro.getAmigos().Count - 1;
            do
            {
                DialogResult amigo = MessageBox.Show($"Deseja fazer amizade com {cadastro.getAmigos()[i]}?", "Amigo?", MessageBoxButtons.YesNo);

                if (amigo == DialogResult.Yes)
                {
                    cadastro.ClearAmigos();
                    CadastroDAL.UpdateAmigo(cadastro);
                    btnSolicita.Visible = false;


                }
                else
                {
                    cadastro.ClearAmigos();
                    btnSolicita.Visible = false;

                }
                i--;
            } while (i != -1);
            
        }

        private void btnSolicita_Click(object sender, EventArgs e)
        {
            AbreForm(sender, e);
        }
    }
}
