namespace staj_1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txt_username = new System.Windows.Forms.TextBox();
            txt_password = new System.Windows.Forms.TextBox();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            btn_login = new System.Windows.Forms.Button();
            btn_signup = new System.Windows.Forms.Button();
            btn_close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txt_username
            // 
            txt_username.BackColor = System.Drawing.Color.Cyan;
            txt_username.Location = new System.Drawing.Point(79, 219);
            txt_username.Name = "txt_username";
            txt_username.PlaceholderText = "USERNAME";
            txt_username.Size = new System.Drawing.Size(175, 27);
            txt_username.TabIndex = 0;
            txt_username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_password
            // 
            txt_password.BackColor = System.Drawing.Color.Cyan;
            txt_password.Location = new System.Drawing.Point(79, 252);
            txt_password.Name = "txt_password";
            txt_password.PlaceholderText = "PASSWORD";
            txt_password.Size = new System.Drawing.Size(175, 27);
            txt_password.TabIndex = 1;
            txt_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icon_256x256;
            pictureBox1.Location = new System.Drawing.Point(79, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(175, 150);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // btn_login
            // 
            btn_login.BackColor = System.Drawing.Color.Lime;
            btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btn_login.Location = new System.Drawing.Point(79, 321);
            btn_login.Name = "btn_login";
            btn_login.Size = new System.Drawing.Size(175, 40);
            btn_login.TabIndex = 3;
            btn_login.Text = "LOGIN";
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += button1_Click;
            // 
            // btn_signup
            // 
            btn_signup.BackColor = System.Drawing.Color.FromArgb(255, 128, 0);
            btn_signup.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btn_signup.Location = new System.Drawing.Point(79, 367);
            btn_signup.Name = "btn_signup";
            btn_signup.Size = new System.Drawing.Size(175, 40);
            btn_signup.TabIndex = 4;
            btn_signup.Text = "SIGNUP";
            btn_signup.UseVisualStyleBackColor = false;
            btn_signup.Click += btn_signup_Click;
            // 
            // btn_close
            // 
            btn_close.BackColor = System.Drawing.Color.Silver;
            btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btn_close.Location = new System.Drawing.Point(295, 12);
            btn_close.Name = "btn_close";
            btn_close.Size = new System.Drawing.Size(25, 25);
            btn_close.TabIndex = 5;
            btn_close.Text = "X";
            btn_close.UseVisualStyleBackColor = false;
            btn_close.Click += btn_close_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(0, 0, 64);
            ClientSize = new System.Drawing.Size(332, 453);
            Controls.Add(btn_close);
            Controls.Add(btn_signup);
            Controls.Add(btn_login);
            Controls.Add(pictureBox1);
            Controls.Add(txt_password);
            Controls.Add(txt_username);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "Form1";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button btn_signup;
        private System.Windows.Forms.Button btn_close;
    }
}
