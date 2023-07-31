namespace TesteRS
{
    partial class Amizade
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtAmigo = new System.Windows.Forms.TextBox();
            this.btnLupa = new FontAwesome.Sharp.IconButton();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listaAmigos = new System.Windows.Forms.ListBox();
            this.lblPosts = new System.Windows.Forms.Label();
            this.btnSolicita = new TesteRS.RadiusButtom();
            this.SuspendLayout();
            // 
            // txtAmigo
            // 
            this.txtAmigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtAmigo.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtAmigo.Location = new System.Drawing.Point(12, 12);
            this.txtAmigo.Name = "txtAmigo";
            this.txtAmigo.Size = new System.Drawing.Size(649, 26);
            this.txtAmigo.TabIndex = 24;
            this.txtAmigo.Text = "Nome do amigo";
            this.txtAmigo.Enter += new System.EventHandler(this.txtAmigo_Enter);
            this.txtAmigo.Leave += new System.EventHandler(this.txtAmigo_Leave);
            // 
            // btnLupa
            // 
            this.btnLupa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLupa.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnLupa.IconColor = System.Drawing.Color.Black;
            this.btnLupa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLupa.IconSize = 25;
            this.btnLupa.Location = new System.Drawing.Point(667, 12);
            this.btnLupa.Name = "btnLupa";
            this.btnLupa.Size = new System.Drawing.Size(75, 26);
            this.btnLupa.TabIndex = 25;
            this.btnLupa.UseVisualStyleBackColor = true;
            this.btnLupa.Click += new System.EventHandler(this.btnLupa_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 44);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(649, 407);
            this.listBox1.TabIndex = 26;
            this.listBox1.Visible = false;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listaAmigos
            // 
            this.listaAmigos.FormattingEnabled = true;
            this.listaAmigos.Location = new System.Drawing.Point(670, 174);
            this.listaAmigos.Name = "listaAmigos";
            this.listaAmigos.Size = new System.Drawing.Size(199, 277);
            this.listaAmigos.TabIndex = 28;
            // 
            // lblPosts
            // 
            this.lblPosts.AutoSize = true;
            this.lblPosts.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosts.Location = new System.Drawing.Point(714, 150);
            this.lblPosts.Name = "lblPosts";
            this.lblPosts.Size = new System.Drawing.Size(110, 21);
            this.lblPosts.TabIndex = 29;
            this.lblPosts.Text = "Meus amigos: ";
            // 
            // btnSolicita
            // 
            this.btnSolicita.BackColor = System.Drawing.Color.Red;
            this.btnSolicita.BackgroundColor = System.Drawing.Color.Red;
            this.btnSolicita.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSolicita.BorderRadius = 17;
            this.btnSolicita.BorderSize = 0;
            this.btnSolicita.FlatAppearance.BorderSize = 0;
            this.btnSolicita.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSolicita.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSolicita.ForeColor = System.Drawing.Color.White;
            this.btnSolicita.Location = new System.Drawing.Point(748, 8);
            this.btnSolicita.Name = "btnSolicita";
            this.btnSolicita.Size = new System.Drawing.Size(34, 32);
            this.btnSolicita.TabIndex = 27;
            this.btnSolicita.TextColor = System.Drawing.Color.White;
            this.btnSolicita.UseVisualStyleBackColor = false;
            this.btnSolicita.Visible = false;
            this.btnSolicita.Click += new System.EventHandler(this.btnSolicita_Click);
            // 
            // Amizade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 459);
            this.Controls.Add(this.lblPosts);
            this.Controls.Add(this.listaAmigos);
            this.Controls.Add(this.btnSolicita);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnLupa);
            this.Controls.Add(this.txtAmigo);
            this.Name = "Amizade";
            this.Text = "Amizade";
            this.Load += new System.EventHandler(this.Amizade_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Amizade_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAmigo;
        private FontAwesome.Sharp.IconButton btnLupa;
        private System.Windows.Forms.ListBox listBox1;
        private RadiusButtom btnSolicita;
        private System.Windows.Forms.ListBox listaAmigos;
        private System.Windows.Forms.Label lblPosts;
    }
}