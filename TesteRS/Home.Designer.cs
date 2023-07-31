namespace TesteRS
{
    partial class Home
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.txtPost = new System.Windows.Forms.TextBox();
            this.btnUpload = new TesteRS.RadiusButtom();
            this.btnPost = new TesteRS.RadiusButtom();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 158);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(954, 383);
            this.flowLayoutPanel1.TabIndex = 26;
            // 
            // txtPost
            // 
            this.txtPost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtPost.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtPost.Location = new System.Drawing.Point(12, 12);
            this.txtPost.Multiline = true;
            this.txtPost.Name = "txtPost";
            this.txtPost.Size = new System.Drawing.Size(798, 115);
            this.txtPost.TabIndex = 23;
            this.txtPost.Text = "No que está pensando?";
            this.txtPost.Enter += new System.EventHandler(this.txtPost_Enter);
            this.txtPost.Leave += new System.EventHandler(this.txtPost_Leave);
            // 
            // btnUpload
            // 
            this.btnUpload.BackColor = System.Drawing.Color.DarkBlue;
            this.btnUpload.BackgroundColor = System.Drawing.Color.DarkBlue;
            this.btnUpload.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnUpload.BorderRadius = 20;
            this.btnUpload.BorderSize = 0;
            this.btnUpload.FlatAppearance.BorderSize = 0;
            this.btnUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpload.Font = new System.Drawing.Font("Segoe UI Emoji", 12F);
            this.btnUpload.ForeColor = System.Drawing.Color.White;
            this.btnUpload.Location = new System.Drawing.Point(816, 74);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(150, 40);
            this.btnUpload.TabIndex = 25;
            this.btnUpload.Text = "Upload";
            this.btnUpload.TextColor = System.Drawing.Color.White;
            this.btnUpload.UseVisualStyleBackColor = false;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // btnPost
            // 
            this.btnPost.BackColor = System.Drawing.Color.DarkBlue;
            this.btnPost.BackgroundColor = System.Drawing.Color.DarkBlue;
            this.btnPost.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnPost.BorderRadius = 20;
            this.btnPost.BorderSize = 0;
            this.btnPost.FlatAppearance.BorderSize = 0;
            this.btnPost.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPost.Font = new System.Drawing.Font("Segoe UI Emoji", 12F);
            this.btnPost.ForeColor = System.Drawing.Color.White;
            this.btnPost.Location = new System.Drawing.Point(816, 12);
            this.btnPost.Name = "btnPost";
            this.btnPost.Size = new System.Drawing.Size(150, 40);
            this.btnPost.TabIndex = 24;
            this.btnPost.Text = "Postar";
            this.btnPost.TextColor = System.Drawing.Color.White;
            this.btnPost.UseVisualStyleBackColor = false;
            this.btnPost.Click += new System.EventHandler(this.btnPost_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 534);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.btnPost);
            this.Controls.Add(this.txtPost);
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.Click += new System.EventHandler(this.Home_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private RadiusButtom btnUpload;
        private RadiusButtom btnPost;
        private System.Windows.Forms.TextBox txtPost;
    }
}