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
    public partial class Perfil : Form
    {
        private static int y = 74;
        public List<Control> contentControls = new List<Control>();
        Credenciais cadastro { get; set; }
        public Perfil()
        {
            InitializeComponent();
        }
        public Perfil(Credenciais _cadastro)
        {
            cadastro = _cadastro;
            InitializeComponent();
        }

        private void Perfil_Load(object sender, EventArgs e)
        {
            if (this.Tag == "sim")
            {
                btnEdita.Visible = true;
            }
            else
            {
                btnEdita.Visible = false;
            }

            pictureBox1.Image = CredenciaisBLL.ImagemPerfil(cadastro);
            txtNome.Text = cadastro.getNome();
            txtApelido.Text = cadastro.getApelido();
            txtSexo.Text = cadastro.getGenero();
            txtEmail.Text = cadastro.getEmail();
            


            this.WindowState = FormWindowState.Normal;

            flowLayoutPanel1.Controls.Clear();


            List<Label> mostra1 = CredenciaisBLL.EscreveOsPostPerfil(cadastro);
            List<Image> mostra2 = CredenciaisBLL.EscreveAsImagensPerfil(cadastro);

            if (mostra1 != null && mostra2 != null)
            {
                mostra1.Reverse();
                mostra2.Reverse();

                int index = 0;
                while (index < Math.Max(mostra1.Count, mostra2.Count))
                {


                    if (index < mostra1.Count)
                    {
                        Label label = mostra1[index];
                        label.Location = new Point(14, y);
                        label.Font = new Font("Microsoft YaHei UI", 15, FontStyle.Regular);
                        label.ForeColor = Color.Black;
                        label.AutoSize = true;
                        y += label.Height + 40;
                        contentControls.Add(label);
                    }
                    if (index < mostra2.Count)
                    {
                        PictureBox pictureBox = new PictureBox();
                        pictureBox.Image = mostra2[index];
                        pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                        pictureBox.Size = new Size(150, 200);
                        y += pictureBox.Height + 40;
                        contentControls.Add(pictureBox);

                    }

                    index++;
                }
                UpdateContent();

            }
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.WrapContents = false;
            flowLayoutPanel1.AutoScroll = true;

            lblCount.Text = contentControls.Count.ToString();

            CredenciaisBLL.setaDados(cadastro);
        }

        private void radiusButtom1_Click(object sender, EventArgs e)
        {
            txtNome.Enabled = true;
            txtApelido.Enabled = true;
            txtSexo.Enabled = true;

            txtApelido.Visible = true;
            lblApelido.Visible = true;
            txtEmail.Visible = true;
            lblEmail.Visible = true;
            txtSexo.Visible = true;
            lblSexo.Visible = true;

           
            btnFoto.Visible = true;
            btnSalva.Visible = true;
            btnEdita.Visible = false;

        }

        public event EventHandler SalvaClick;

        private void btnSalva_Click(object sender, EventArgs e)
        {
            txtNome.Enabled = false;
            txtApelido.Enabled = false;
            txtSexo.Enabled = false;
            
            btnSalva.Visible = false;
            btnEdita.Visible = true;
            btnFoto.Visible = false;
            btnFoto.BackColor = Color.Red;


            
            cadastro.setNome(txtNome.Text);
            cadastro.setApelido(txtApelido.Text);
            cadastro.setGenero(txtSexo.Text);

            CredenciaisBLL.UpdatePerfil(cadastro);
            SalvaClick?.Invoke(this, EventArgs.Empty);

        }
        private void UpdateContent()
        {
            flowLayoutPanel1.Controls.Clear();

            foreach (Control control in contentControls)
            {
                flowLayoutPanel1.Controls.Add(control);
            }
        }

        private void btnFoto_Click(object sender, EventArgs e)
        {
            btnFoto.BackColor = Color.Lime;
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
                CredenciaisBLL.updateFoto(cadastro);
                pictureBox1.Image = CredenciaisBLL.ImagemPerfil(cadastro);
            }
        }
    }
}
