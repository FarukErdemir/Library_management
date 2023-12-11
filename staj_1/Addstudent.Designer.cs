namespace staj_1
{
    partial class Addstudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Addstudent));
            txt_stuname = new System.Windows.Forms.TextBox();
            txt_stuno = new System.Windows.Forms.TextBox();
            txt_stunum = new System.Windows.Forms.TextBox();
            txt_stumail = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            btn_stusave = new System.Windows.Forms.Button();
            label5 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // txt_stuname
            // 
            txt_stuname.BackColor = System.Drawing.Color.White;
            txt_stuname.Location = new System.Drawing.Point(460, 161);
            txt_stuname.Name = "txt_stuname";
            txt_stuname.Size = new System.Drawing.Size(250, 27);
            txt_stuname.TabIndex = 0;
            // 
            // txt_stuno
            // 
            txt_stuno.Location = new System.Drawing.Point(460, 214);
            txt_stuno.Name = "txt_stuno";
            txt_stuno.Size = new System.Drawing.Size(250, 27);
            txt_stuno.TabIndex = 1;
            txt_stuno.TextChanged += textBox2_TextChanged;
            // 
            // txt_stunum
            // 
            txt_stunum.Location = new System.Drawing.Point(460, 267);
            txt_stunum.Name = "txt_stunum";
            txt_stunum.Size = new System.Drawing.Size(250, 27);
            txt_stunum.TabIndex = 2;
            // 
            // txt_stumail
            // 
            txt_stumail.Location = new System.Drawing.Point(460, 320);
            txt_stumail.Name = "txt_stumail";
            txt_stumail.Size = new System.Drawing.Size(250, 27);
            txt_stumail.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
            label1.Location = new System.Drawing.Point(256, 164);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(119, 20);
            label1.TabIndex = 4;
            label1.Text = "STUDENT NAME";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
            label2.Location = new System.Drawing.Point(256, 217);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(99, 20);
            label2.TabIndex = 5;
            label2.Text = "STUDENT NO";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
            label3.Location = new System.Drawing.Point(256, 270);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(138, 20);
            label3.TabIndex = 6;
            label3.Text = "CONTACT NUMBER";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
            label4.Location = new System.Drawing.Point(256, 323);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(57, 20);
            label4.TabIndex = 7;
            label4.Text = "E-MAIL";
            // 
            // btn_stusave
            // 
            btn_stusave.BackColor = System.Drawing.Color.FromArgb(128, 255, 128);
            btn_stusave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btn_stusave.Location = new System.Drawing.Point(460, 458);
            btn_stusave.Name = "btn_stusave";
            btn_stusave.Size = new System.Drawing.Size(94, 29);
            btn_stusave.TabIndex = 8;
            btn_stusave.Text = "SAVE";
            btn_stusave.UseVisualStyleBackColor = false;
            btn_stusave.Click += btn_stusave_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
            label5.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label5.Location = new System.Drawing.Point(290, 32);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(355, 67);
            label5.TabIndex = 9;
            label5.Text = "ADD STUDENT";
            // 
            // Addstudent
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(255, 192, 192);
            BackgroundImage = (System.Drawing.Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(882, 553);
            Controls.Add(label5);
            Controls.Add(btn_stusave);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_stumail);
            Controls.Add(txt_stunum);
            Controls.Add(txt_stuno);
            Controls.Add(txt_stuname);
            Name = "Addstudent";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Addstudent";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txt_stuname;
        private System.Windows.Forms.TextBox txt_stuno;
        private System.Windows.Forms.TextBox txt_stunum;
        private System.Windows.Forms.TextBox txt_stumail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_stusave;
        private System.Windows.Forms.Label label5;
    }
}