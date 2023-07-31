namespace TesteRS
{
    partial class Cadastro
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
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtApelido = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rbFem = new System.Windows.Forms.RadioButton();
            this.rbMasc = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblvinte = new System.Windows.Forms.Label();
            this.lblMAI = new System.Windows.Forms.Label();
            this.lblMIN = new System.Windows.Forms.Label();
            this.lblSim = new System.Windows.Forms.Label();
            this.lblNum = new System.Windows.Forms.Label();
            this.dtNascimento = new System.Windows.Forms.DateTimePicker();
            this.btnRevela = new FontAwesome.Sharp.IconButton();
            this.btnCadastro = new TesteRS.RadiusButtom();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtEmail.Location = new System.Drawing.Point(254, 147);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(293, 26);
            this.txtEmail.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Emoji", 12F);
            this.label2.Location = new System.Drawing.Point(80, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Email: ";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtNome.Location = new System.Drawing.Point(254, 188);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(293, 26);
            this.txtNome.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Emoji", 12F);
            this.label1.Location = new System.Drawing.Point(80, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nome: ";
            // 
            // txtApelido
            // 
            this.txtApelido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtApelido.Location = new System.Drawing.Point(254, 238);
            this.txtApelido.Name = "txtApelido";
            this.txtApelido.Size = new System.Drawing.Size(293, 26);
            this.txtApelido.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Emoji", 12F);
            this.label3.Location = new System.Drawing.Point(80, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 21);
            this.label3.TabIndex = 9;
            this.label3.Text = "Apelido (Opcional):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Emoji", 12F);
            this.label4.Location = new System.Drawing.Point(80, 292);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 21);
            this.label4.TabIndex = 11;
            this.label4.Text = "Data de Nascimento: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Emoji", 12F);
            this.label5.Location = new System.Drawing.Point(80, 343);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 21);
            this.label5.TabIndex = 13;
            this.label5.Text = "Gênero: ";
            // 
            // rbFem
            // 
            this.rbFem.AutoSize = true;
            this.rbFem.Font = new System.Drawing.Font("Segoe UI Emoji", 12F);
            this.rbFem.Location = new System.Drawing.Point(254, 343);
            this.rbFem.Name = "rbFem";
            this.rbFem.Size = new System.Drawing.Size(93, 25);
            this.rbFem.TabIndex = 14;
            this.rbFem.TabStop = true;
            this.rbFem.Text = "Feminino";
            this.rbFem.UseVisualStyleBackColor = true;
            // 
            // rbMasc
            // 
            this.rbMasc.AutoSize = true;
            this.rbMasc.Font = new System.Drawing.Font("Segoe UI Emoji", 12F);
            this.rbMasc.Location = new System.Drawing.Point(370, 343);
            this.rbMasc.Name = "rbMasc";
            this.rbMasc.Size = new System.Drawing.Size(99, 25);
            this.rbMasc.TabIndex = 15;
            this.rbMasc.TabStop = true;
            this.rbMasc.Text = "Masculino";
            this.rbMasc.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Segoe UI Emoji", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Aqua;
            this.label6.Location = new System.Drawing.Point(206, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(222, 64);
            this.label6.TabIndex = 16;
            this.label6.Text = "Cadastro";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Emoji", 12F);
            this.label7.Location = new System.Drawing.Point(80, 409);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 21);
            this.label7.TabIndex = 18;
            this.label7.Text = "Senha: ";
            // 
            // txtSenha
            // 
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtSenha.Location = new System.Drawing.Point(254, 407);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(293, 26);
            this.txtSenha.TabIndex = 19;
            this.txtSenha.UseSystemPasswordChar = true;
            this.txtSenha.TextChanged += new System.EventHandler(this.Verificar);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Emoji", 12F);
            this.label8.Location = new System.Drawing.Point(80, 478);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(164, 21);
            this.label8.TabIndex = 21;
            this.label8.Text = "A senha deve possuir: ";
            // 
            // lblvinte
            // 
            this.lblvinte.AutoSize = true;
            this.lblvinte.Font = new System.Drawing.Font("Segoe UI Emoji", 12F);
            this.lblvinte.ForeColor = System.Drawing.Color.Red;
            this.lblvinte.Location = new System.Drawing.Point(264, 478);
            this.lblvinte.Name = "lblvinte";
            this.lblvinte.Size = new System.Drawing.Size(161, 21);
            this.lblvinte.TabIndex = 22;
            this.lblvinte.Text = "• De 8 a 20 caracteres";
            // 
            // lblMAI
            // 
            this.lblMAI.AutoSize = true;
            this.lblMAI.Font = new System.Drawing.Font("Segoe UI Emoji", 12F);
            this.lblMAI.ForeColor = System.Drawing.Color.Red;
            this.lblMAI.Location = new System.Drawing.Point(264, 514);
            this.lblMAI.Name = "lblMAI";
            this.lblMAI.Size = new System.Drawing.Size(288, 21);
            this.lblMAI.TabIndex = 23;
            this.lblMAI.Text = "• Possuir ao menos uma letra maiúscula";
            // 
            // lblMIN
            // 
            this.lblMIN.AutoSize = true;
            this.lblMIN.Font = new System.Drawing.Font("Segoe UI Emoji", 12F);
            this.lblMIN.ForeColor = System.Drawing.Color.Red;
            this.lblMIN.Location = new System.Drawing.Point(264, 551);
            this.lblMIN.Name = "lblMIN";
            this.lblMIN.Size = new System.Drawing.Size(289, 21);
            this.lblMIN.TabIndex = 24;
            this.lblMIN.Text = "• Possuir ao menos uma letra minúscula";
            // 
            // lblSim
            // 
            this.lblSim.AutoSize = true;
            this.lblSim.Font = new System.Drawing.Font("Segoe UI Emoji", 12F);
            this.lblSim.ForeColor = System.Drawing.Color.Red;
            this.lblSim.Location = new System.Drawing.Point(264, 583);
            this.lblSim.Name = "lblSim";
            this.lblSim.Size = new System.Drawing.Size(231, 21);
            this.lblSim.TabIndex = 25;
            this.lblSim.Text = "• Possuir ao menos um símbolo";
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Font = new System.Drawing.Font("Segoe UI Emoji", 12F);
            this.lblNum.ForeColor = System.Drawing.Color.Red;
            this.lblNum.Location = new System.Drawing.Point(264, 616);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(230, 21);
            this.lblNum.TabIndex = 26;
            this.lblNum.Text = "• Possuir ao menos um número";
            // 
            // dtNascimento
            // 
            this.dtNascimento.Font = new System.Drawing.Font("Segoe UI Emoji", 12F);
            this.dtNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNascimento.Location = new System.Drawing.Point(254, 286);
            this.dtNascimento.MaxDate = new System.DateTime(2023, 4, 5, 0, 0, 0, 0);
            this.dtNascimento.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtNascimento.Name = "dtNascimento";
            this.dtNascimento.Size = new System.Drawing.Size(110, 29);
            this.dtNascimento.TabIndex = 28;
            this.dtNascimento.Value = new System.DateTime(2023, 1, 1, 0, 0, 0, 0);
            // 
            // btnRevela
            // 
            this.btnRevela.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRevela.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            this.btnRevela.IconColor = System.Drawing.Color.Black;
            this.btnRevela.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRevela.IconSize = 20;
            this.btnRevela.Location = new System.Drawing.Point(553, 408);
            this.btnRevela.Name = "btnRevela";
            this.btnRevela.Size = new System.Drawing.Size(41, 26);
            this.btnRevela.TabIndex = 29;
            this.btnRevela.UseVisualStyleBackColor = true;
            this.btnRevela.Click += new System.EventHandler(this.btnRevela_Click);
            // 
            // btnCadastro
            // 
            this.btnCadastro.BackColor = System.Drawing.Color.Aqua;
            this.btnCadastro.BackgroundColor = System.Drawing.Color.Aqua;
            this.btnCadastro.BorderColor = System.Drawing.Color.Black;
            this.btnCadastro.BorderRadius = 20;
            this.btnCadastro.BorderSize = 1;
            this.btnCadastro.FlatAppearance.BorderSize = 0;
            this.btnCadastro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.btnCadastro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.btnCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnCadastro.ForeColor = System.Drawing.Color.Black;
            this.btnCadastro.Location = new System.Drawing.Point(217, 676);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Size = new System.Drawing.Size(182, 40);
            this.btnCadastro.TabIndex = 27;
            this.btnCadastro.Text = "Finalizar Cadastro";
            this.btnCadastro.TextColor = System.Drawing.Color.Black;
            this.btnCadastro.UseVisualStyleBackColor = false;
            this.btnCadastro.Click += new System.EventHandler(this.btnCadastro_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.iconButton3);
            this.panel1.Controls.Add(this.iconButton2);
            this.panel1.Controls.Add(this.iconButton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(624, 44);
            this.panel1.TabIndex = 30;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // iconButton3
            // 
            this.iconButton3.BackColor = System.Drawing.Color.Transparent;
            this.iconButton3.FlatAppearance.BorderSize = 0;
            this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.X;
            this.iconButton3.IconColor = System.Drawing.Color.Black;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.IconSize = 15;
            this.iconButton3.Location = new System.Drawing.Point(577, 12);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(44, 23);
            this.iconButton3.TabIndex = 2;
            this.iconButton3.UseVisualStyleBackColor = false;
            this.iconButton3.Click += new System.EventHandler(this.iconButton3_Click);
            // 
            // iconButton2
            // 
            this.iconButton2.BackColor = System.Drawing.Color.Transparent;
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.ForeColor = System.Drawing.Color.Transparent;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.iconButton2.IconColor = System.Drawing.Color.Black;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 15;
            this.iconButton2.Location = new System.Drawing.Point(477, 12);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(44, 23);
            this.iconButton2.TabIndex = 1;
            this.iconButton2.UseVisualStyleBackColor = false;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.Transparent;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.WindowRestore;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 15;
            this.iconButton1.Location = new System.Drawing.Point(527, 12);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(44, 23);
            this.iconButton1.TabIndex = 0;
            this.iconButton1.UseVisualStyleBackColor = false;
            // 
            // Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(624, 760);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnRevela);
            this.Controls.Add(this.dtNascimento);
            this.Controls.Add(this.btnCadastro);
            this.Controls.Add(this.lblNum);
            this.Controls.Add(this.lblSim);
            this.Controls.Add(this.lblMIN);
            this.Controls.Add(this.lblMAI);
            this.Controls.Add(this.lblvinte);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rbMasc);
            this.Controls.Add(this.rbFem);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtApelido);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Cadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro";
            this.Load += new System.EventHandler(this.Cadastro_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtApelido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rbFem;
        private System.Windows.Forms.RadioButton rbMasc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblvinte;
        private System.Windows.Forms.Label lblMAI;
        private System.Windows.Forms.Label lblMIN;
        private System.Windows.Forms.Label lblSim;
        private System.Windows.Forms.Label lblNum;
        private RadiusButtom btnCadastro;
        private System.Windows.Forms.DateTimePicker dtNascimento;
        private FontAwesome.Sharp.IconButton btnRevela;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}