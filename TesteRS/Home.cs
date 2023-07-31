using Biblioteca;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TesteRS
{
    public partial class Home : Form
    {
        public string emailMesmo;
        bool visivel = true;
        private int y = 74;
        public List<Control> contentControls = new List<Control>();
        public Credenciais cadastro { get; set; }
        public Home()
        {
            InitializeComponent();
        }
        public Home(Credenciais _cadastro)
        {
            cadastro = _cadastro;
            InitializeComponent();
        }
        private void txtPost_Enter(object sender, EventArgs e)
        {
            if (txtPost.Text == "No que está pensando?")
            {
                txtPost.Text = "";
                txtPost.ForeColor = SystemColors.WindowText;
            }
        }

        private void txtPost_Leave(object sender, EventArgs e)
        {
            this.ActiveControl = null;
            if (txtPost.Text == "")
            {
                txtPost.Text = "No que está pensando?";
                txtPost.ForeColor = SystemColors.GrayText;
            }

        }

        private void Home_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;

            flowLayoutPanel1.Controls.Clear();


            List<Label> mostra1 = CredenciaisBLL.EscreveOsPost(cadastro);
            List<Image> mostra2 = CredenciaisBLL.EscreveAsImagens(cadastro);

            if (mostra1 != null && mostra2 != null)
            {
                mostra1.Reverse();
                mostra2.Reverse();

                int index = 0;
                while (index < Math.Max(mostra1.Count, mostra2.Count))
                {


                    if (index < mostra1.Count)
                    {
                        string email = mostra1[index].Tag.ToString();
                        Label label1 = new Label();
                        label1.Text = $"{email} - ";
                        label1.AutoSize = true;
                        Label label = mostra1[index];
                        label.Location = new Point(14, y);
                        label.Font = new Font("Microsoft YaHei UI", 15, FontStyle.Regular);
                        label.ForeColor = Color.Black;
                        label.AutoSize = true;
                        y += label.Height + 40;

                        PictureBox fotoPerfil = new PictureBox();
                        fotoPerfil.Image = CredenciaisBLL.FotoPost(email);
                        fotoPerfil.SizeMode = PictureBoxSizeMode.Zoom;
                        fotoPerfil.Size = new Size(50, 50);
                        fotoPerfil.Tag = $"{email}";
                        fotoPerfil.Click += new EventHandler(this.PerfilPost);

                        FlowLayoutPanel panel = new FlowLayoutPanel();
                        panel.FlowDirection = FlowDirection.LeftToRight;
                        panel.AutoSize = true;
                        panel.Controls.Add(fotoPerfil);
                        panel.Controls.Add(label1);
                        panel.Controls.Add(label);

                        contentControls.Add(panel);
                    }
                    if (index < mostra2.Count)
                    {
                        string email = mostra2[index].Tag.ToString();
                        Label label = new Label();
                        label.Text = $"{email} - ";
                        label.AutoSize = true;
                        PictureBox fotoPerfil = new PictureBox(); 
                        fotoPerfil.Image = CredenciaisBLL.FotoPost(email);
                        fotoPerfil.SizeMode = PictureBoxSizeMode.Zoom;
                        fotoPerfil.Size = new Size(50, 50);
                        fotoPerfil.Tag = $"{email}";
                        fotoPerfil.Click += new EventHandler(this.PerfilPost);


                        PictureBox pictureBox = new PictureBox();
                        pictureBox.Image = mostra2[index];
                        pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                        pictureBox.Size = new Size(150, 200);
                        pictureBox.Margin = new Padding(10, 0, 0, 0);

                        FlowLayoutPanel panel = new FlowLayoutPanel();
                        panel.FlowDirection = FlowDirection.LeftToRight;
                        panel.AutoSize = true;
                        panel.Controls.Add(fotoPerfil);
                        panel.Controls.Add(label);
                        panel.Controls.Add(pictureBox);

                        y += panel.Height + 40;
                        contentControls.Add(panel);

                    }

                    index++;
                }
                UpdateContent();

            }
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.WrapContents = false;
            flowLayoutPanel1.AutoScroll = true;
        }
        public void PerfilPost(object sender, EventArgs e)
        {
            PictureBox button = (PictureBox)sender;
            emailMesmo = cadastro.getEmail();
            cadastro.setEmail(button.Tag.ToString());
            CredenciaisBLL.FotoPerfilAmigo(cadastro);
            Perfil formPerfil = new Perfil(cadastro);
            formPerfil.TopLevel = false;
            formPerfil.FormBorderStyle = FormBorderStyle.None;
            formPerfil.Dock = DockStyle.Fill;
            this.Controls.Add(formPerfil);
            this.Tag = formPerfil;
            formPerfil.BringToFront();
            formPerfil.Show();
            cadastro.setEmail(emailMesmo);
            CredenciaisBLL.FotoPerfilAmigo(cadastro);
        }

            private void btnPost_Click(object sender, EventArgs e)
        {
            cadastro.setPost(txtPost.Text);
            CredenciaisBLL.VerificaPost(cadastro);
            if (Erro.getErro())
            {
                MessageBox.Show(Erro.getMsgErro());
            }
            else
            {
                CredenciaisBLL.InsiraUmPost(cadastro);

                if (Erro.getErro())
                {
                    MessageBox.Show(Erro.getMsgErro());
                }
                else
                {
                    string email = cadastro.getEmail();
                    PictureBox fotoPerfil = new PictureBox();
                    fotoPerfil.Image = CredenciaisBLL.FotoPost(email);
                    fotoPerfil.SizeMode = PictureBoxSizeMode.Zoom;
                    fotoPerfil.Size = new Size(50, 50);
                    fotoPerfil.Tag = $"{email}";
                    fotoPerfil.Click += new EventHandler(this.PerfilPost);
                    Label label1 = new Label();
                    label1.Text = $"{email} - ";
                    label1.AutoSize = true;
                    Label label = new Label();
                    label.Text = $"{cadastro.getPost()}";
                    label.Location = new Point(14, 0);
                    label.Font = new Font("Microsoft YaHei UI", 15, FontStyle.Regular);
                    label.ForeColor = Color.Black;
                    label.AutoSize = true;
                    FlowLayoutPanel panel = new FlowLayoutPanel();
                    panel.FlowDirection = FlowDirection.LeftToRight;
                    panel.AutoSize = true;
                    panel.Controls.Add(fotoPerfil);
                    panel.Controls.Add(label1);
                    panel.Controls.Add(label);

                    contentControls.Insert(0, panel);
                    UpdateContent();
                }
                txtPost.Text = "No que está pensando?";
                txtPost.ForeColor = SystemColors.GrayText;
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Arquivos de Imagem|*.jpg;*.jpeg;*.png;*.gif";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string nomeArquivo = openFileDialog.SafeFileName;
                string caminhoArquivoOrigem = openFileDialog.FileName;
                string caminhoArquivoDestino = Path.Combine(Application.StartupPath, nomeArquivo);
                int contador = 1;
                while (File.Exists(caminhoArquivoDestino))
                {
                    string nomeSemExtensao = Path.GetFileNameWithoutExtension(nomeArquivo);
                    string extensao = Path.GetExtension(nomeArquivo);
                    nomeArquivo = $"{nomeSemExtensao}({contador}){extensao}";
                    caminhoArquivoDestino = Path.Combine(Application.StartupPath, nomeArquivo);
                    contador++;
                }
                File.Copy(caminhoArquivoOrigem, caminhoArquivoDestino);
                cadastro.setFoto(nomeArquivo);
                CredenciaisBLL.insiraFoto(cadastro);

                string email = cadastro.getEmail();
                PictureBox fotoPerfil = new PictureBox();
                fotoPerfil.Image = CredenciaisBLL.FotoPost(email);
                fotoPerfil.SizeMode = PictureBoxSizeMode.Zoom;
                fotoPerfil.Size = new Size(50, 50);
                fotoPerfil.Tag = $"{email}";
                fotoPerfil.Click += new EventHandler(this.PerfilPost);
                Label label1 = new Label();
                label1.Text = $"{email} - ";
                label1.AutoSize = true;

                PictureBox pictureBox = new PictureBox();
                pictureBox.ImageLocation = caminhoArquivoDestino;
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox.Size = new Size(150, 200);
                pictureBox.Tag = $"{cadastro.getEmail()}";
                string email1 = pictureBox.Tag.ToString();
                Label label = new Label();
                label.Text = $"{email1} - ";
                label.AutoSize = true;
                FlowLayoutPanel panel = new FlowLayoutPanel();
                panel.FlowDirection = FlowDirection.LeftToRight;
                panel.AutoSize = true;
                panel.Controls.Add(fotoPerfil);
                panel.Controls.Add(label1);
                panel.Controls.Add(pictureBox);

                contentControls.Insert(0, panel);
                UpdateContent();
            }
        }
        private void UpdateContent()
        {
            flowLayoutPanel1.Controls.Clear();

            foreach (Control control in contentControls)
            {
                flowLayoutPanel1.Controls.Add(control);
            }
        }

        private void Home_Click(object sender, EventArgs e)
        {
            if (txtPost.ContainsFocus)
            {
                this.ActiveControl = null;
            }
        }
    }
}
