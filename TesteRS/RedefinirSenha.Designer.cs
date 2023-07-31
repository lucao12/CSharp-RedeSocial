namespace TesteRS
{
    partial class RedefinirSenha
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
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnVerifica = new System.Windows.Forms.Button();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lblNum = new System.Windows.Forms.Label();
            this.lblSim = new System.Windows.Forms.Label();
            this.lblMIN = new System.Windows.Forms.Label();
            this.lblMAI = new System.Windows.Forms.Label();
            this.lblvinte = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Segoe UI Emoji", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label6.Location = new System.Drawing.Point(70, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(357, 64);
            this.label6.TabIndex = 21;
            this.label6.Text = "Alterar a senha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Emoji", 12F);
            this.label2.Location = new System.Drawing.Point(66, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 21);
            this.label2.TabIndex = 20;
            this.label2.Text = "Senha nova: ";
            // 
            // btnVerifica
            // 
            this.btnVerifica.Font = new System.Drawing.Font("Segoe UI Emoji", 12F);
            this.btnVerifica.Location = new System.Drawing.Point(203, 462);
            this.btnVerifica.Name = "btnVerifica";
            this.btnVerifica.Size = new System.Drawing.Size(101, 36);
            this.btnVerifica.TabIndex = 19;
            this.btnVerifica.Text = "Verificar";
            this.btnVerifica.UseVisualStyleBackColor = true;
            this.btnVerifica.Click += new System.EventHandler(this.btnVerifica_Click);
            // 
            // txtSenha
            // 
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtSenha.Location = new System.Drawing.Point(203, 158);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(233, 26);
            this.txtSenha.TabIndex = 18;
            this.txtSenha.UseSystemPasswordChar = true;
            this.txtSenha.TextChanged += new System.EventHandler(this.txtSenha_TextChanged);
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Font = new System.Drawing.Font("Segoe UI Emoji", 12F);
            this.lblNum.ForeColor = System.Drawing.Color.Red;
            this.lblNum.Location = new System.Drawing.Point(199, 366);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(230, 21);
            this.lblNum.TabIndex = 33;
            this.lblNum.Text = "• Possuir ao menos um número";
            // 
            // lblSim
            // 
            this.lblSim.AutoSize = true;
            this.lblSim.Font = new System.Drawing.Font("Segoe UI Emoji", 12F);
            this.lblSim.ForeColor = System.Drawing.Color.Red;
            this.lblSim.Location = new System.Drawing.Point(199, 333);
            this.lblSim.Name = "lblSim";
            this.lblSim.Size = new System.Drawing.Size(231, 21);
            this.lblSim.TabIndex = 32;
            this.lblSim.Text = "• Possuir ao menos um símbolo";
            // 
            // lblMIN
            // 
            this.lblMIN.AutoSize = true;
            this.lblMIN.Font = new System.Drawing.Font("Segoe UI Emoji", 12F);
            this.lblMIN.ForeColor = System.Drawing.Color.Red;
            this.lblMIN.Location = new System.Drawing.Point(199, 301);
            this.lblMIN.Name = "lblMIN";
            this.lblMIN.Size = new System.Drawing.Size(289, 21);
            this.lblMIN.TabIndex = 31;
            this.lblMIN.Text = "• Possuir ao menos uma letra minúscula";
            // 
            // lblMAI
            // 
            this.lblMAI.AutoSize = true;
            this.lblMAI.Font = new System.Drawing.Font("Segoe UI Emoji", 12F);
            this.lblMAI.ForeColor = System.Drawing.Color.Red;
            this.lblMAI.Location = new System.Drawing.Point(199, 264);
            this.lblMAI.Name = "lblMAI";
            this.lblMAI.Size = new System.Drawing.Size(288, 21);
            this.lblMAI.TabIndex = 30;
            this.lblMAI.Text = "• Possuir ao menos uma letra maiúscula";
            // 
            // lblvinte
            // 
            this.lblvinte.AutoSize = true;
            this.lblvinte.Font = new System.Drawing.Font("Segoe UI Emoji", 12F);
            this.lblvinte.ForeColor = System.Drawing.Color.Red;
            this.lblvinte.Location = new System.Drawing.Point(199, 228);
            this.lblvinte.Name = "lblvinte";
            this.lblvinte.Size = new System.Drawing.Size(161, 21);
            this.lblvinte.TabIndex = 29;
            this.lblvinte.Text = "• De 8 a 20 caracteres";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Emoji", 12F);
            this.label8.Location = new System.Drawing.Point(15, 228);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(164, 21);
            this.label8.TabIndex = 28;
            this.label8.Text = "A senha deve possuir: ";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(442, 158);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(42, 26);
            this.button1.TabIndex = 27;
            this.button1.Text = "👁‍🗨";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.iconButton2);
            this.panel1.Controls.Add(this.iconButton3);
            this.panel1.Controls.Add(this.iconButton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(499, 37);
            this.panel1.TabIndex = 34;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
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
            this.iconButton2.Location = new System.Drawing.Point(352, 11);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(44, 23);
            this.iconButton2.TabIndex = 1;
            this.iconButton2.UseVisualStyleBackColor = false;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
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
            this.iconButton3.Location = new System.Drawing.Point(452, 11);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(44, 23);
            this.iconButton3.TabIndex = 2;
            this.iconButton3.UseVisualStyleBackColor = false;
            this.iconButton3.Click += new System.EventHandler(this.iconButton3_Click);
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
            this.iconButton1.Location = new System.Drawing.Point(402, 11);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(44, 23);
            this.iconButton1.TabIndex = 0;
            this.iconButton1.UseVisualStyleBackColor = false;
            // 
            // RedefinirSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(499, 524);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblNum);
            this.Controls.Add(this.lblSim);
            this.Controls.Add(this.lblMIN);
            this.Controls.Add(this.lblMAI);
            this.Controls.Add(this.lblvinte);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnVerifica);
            this.Controls.Add(this.txtSenha);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RedefinirSenha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Redefinir Senha";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnVerifica;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.Label lblSim;
        private System.Windows.Forms.Label lblMIN;
        private System.Windows.Forms.Label lblMAI;
        private System.Windows.Forms.Label lblvinte;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}