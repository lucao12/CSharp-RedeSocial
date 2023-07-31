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
using System.Diagnostics;
using System.IO;

namespace TesteRS
{

    public partial class Rede_Social : Form
    {
        bool visivel = true;
        private Timer timer;
        private int y = 74;
        public List<Control> contentControls = new List<Control>();
        public Credenciais cadastro { get; set; }
        public Rede_Social()
        {
            InitializeComponent();
        }
        public Rede_Social(Credenciais _cadastro)
        {
            cadastro = _cadastro;
            InitializeComponent();

        }
        public void Timer_Tick(object sender, EventArgs e)
        {
            pictureBox1.Image = CredenciaisBLL.ImagemPerfil(cadastro);

        }
        private Point lastPoint;
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }   

        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            string diretorioAtual = Environment.CurrentDirectory;
            string caminhoSegundoProjeto = $@"{diretorioAtual}\Top-Down-Zombie-Shooter-Game-in-Windows-Form-main\Shoot Out Game MOO ICT\bin\Debug\Shoot Out Game MOO ICT.exe";

            Process.Start(caminhoSegundoProjeto);
        }

        private void iconButton8_Click(object sender, EventArgs e)
        {
            if(visivel == true)
            {
                panel2.Visible = false;
                iconButton4.Visible = false;
                iconButton5.Visible = false;
                iconButton6.Visible = false;
                iconButton7.Visible = false;
                visivel = false;
            }
            else
            {
                panel2.Visible = true;
                iconButton4.Visible = true;
                iconButton5.Visible = true;
                iconButton6.Visible = true;
                iconButton7.Visible = true;
                visivel = true;
            }
        }

        private void iconButton7_Click(object sender, EventArgs e)
        {
            Perfil formPerfil = new Perfil(cadastro);
            formPerfil.TopLevel = false;
            formPerfil.FormBorderStyle = FormBorderStyle.None;
            formPerfil.Dock = DockStyle.Fill;
            this.Controls.Add(formPerfil);
            this.Tag = formPerfil;
            formPerfil.SalvaClick += FormPerfil_SalvaClick;
            formPerfil.BringToFront();
            formPerfil.Tag = "sim";
            formPerfil.Show();

        }
        private void FormPerfil_SalvaClick(object sender, EventArgs e)
        {
            // Chama o método Timer_Tick da classe Rede_Social
            Timer_Tick(sender, e);
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            Home formHome = new Home(cadastro);
            formHome.TopLevel = false;
            formHome.FormBorderStyle = FormBorderStyle.None;
            formHome.Dock = DockStyle.Fill;
            this.Controls.Add(formHome);
            this.Tag = formHome;
            formHome.BringToFront();
            formHome.Show();
        }

        private void Rede_Social_Load(object sender, EventArgs e)
        {
            CredenciaisBLL.insiraCadastros(cadastro);
            pictureBox1.Image = CredenciaisBLL.ImagemPerfil(cadastro);

            Home formHome = new Home(cadastro);
            formHome.TopLevel = false;
            formHome.FormBorderStyle = FormBorderStyle.None;
            formHome.Dock = DockStyle.Fill;
            this.Controls.Add(formHome);
            this.Tag = formHome;
            formHome.BringToFront();
            formHome.Show();


        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            Amizade formHome = new Amizade(cadastro);
            formHome.TopLevel = false;
            formHome.FormBorderStyle = FormBorderStyle.None;
            formHome.Dock = DockStyle.Fill;
            this.Controls.Add(formHome);
            this.Tag = formHome;
            formHome.BringToFront();
            formHome.Show();
        }
    }
}
