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
    public partial class Verificação : Form
    {
        public Credenciais _cadastro { get; set; }
        public Verificação()
        {
            InitializeComponent();
        }
        public Verificação(Credenciais cadastro)
        {
            _cadastro = cadastro;
            InitializeComponent();
        }

        private void btnVerifica_Click(object sender, EventArgs e)
        {
            _cadastro.setCodigo(txtCodigo.Text);

            CredenciaisBLL.ValidaCodigo(_cadastro);

            if (Erro.getErro())
            {
                MessageBox.Show(Erro.getMsgErro());
            }
            else
            {
                Close();
            }
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            _cadastro.setCodigo(null);
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
