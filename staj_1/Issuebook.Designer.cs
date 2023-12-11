namespace staj_1
{
    partial class Issuebook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Issuebook));
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            button1 = new System.Windows.Forms.Button();
            dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            name = new System.Windows.Forms.TextBox();
            num = new System.Windows.Forms.TextBox();
            mail = new System.Windows.Forms.TextBox();
            comboBox1 = new System.Windows.Forms.ComboBox();
            label7 = new System.Windows.Forms.Label();
            entry = new System.Windows.Forms.TextBox();
            button2 = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(63, 99);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(119, 20);
            label1.TabIndex = 0;
            label1.Text = "STUDENT NAME";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(63, 154);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(142, 20);
            label2.TabIndex = 1;
            label2.Text = "STUDENT CONTACT";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(63, 206);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(125, 20);
            label3.TabIndex = 2;
            label3.Text = "STUDENT E-MAIL";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(63, 261);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(57, 20);
            label4.TabIndex = 3;
            label4.Text = "BOOKS";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(63, 315);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(87, 20);
            label5.TabIndex = 4;
            label5.Text = "ISSUE DATE";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = System.Drawing.Color.FromArgb(255, 224, 192);
            label6.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label6.Location = new System.Drawing.Point(241, 9);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(303, 67);
            label6.TabIndex = 5;
            label6.Text = "ISSUE BOOK";
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.Color.FromArgb(128, 255, 128);
            button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            button1.Location = new System.Drawing.Point(348, 386);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(94, 29);
            button1.TabIndex = 6;
            button1.Text = "ISSUE";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new System.Drawing.Point(241, 310);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new System.Drawing.Size(250, 27);
            dateTimePicker1.TabIndex = 7;
            // 
            // name
            // 
            name.BackColor = System.Drawing.Color.Silver;
            name.Location = new System.Drawing.Point(241, 96);
            name.Name = "name";
            name.ReadOnly = true;
            name.Size = new System.Drawing.Size(250, 27);
            name.TabIndex = 8;
            // 
            // num
            // 
            num.BackColor = System.Drawing.Color.Silver;
            num.Location = new System.Drawing.Point(241, 151);
            num.Name = "num";
            num.ReadOnly = true;
            num.Size = new System.Drawing.Size(250, 27);
            num.TabIndex = 9;
            // 
            // mail
            // 
            mail.BackColor = System.Drawing.Color.Silver;
            mail.Location = new System.Drawing.Point(241, 203);
            mail.Name = "mail";
            mail.ReadOnly = true;
            mail.Size = new System.Drawing.Size(250, 27);
            mail.TabIndex = 10;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = System.Drawing.Color.Silver;
            comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new System.Drawing.Point(241, 258);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new System.Drawing.Size(250, 28);
            comboBox1.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label7.Location = new System.Drawing.Point(549, 154);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(208, 28);
            label7.TabIndex = 12;
            label7.Text = "SEARCH STUDENT NO";
            // 
            // entry
            // 
            entry.BackColor = System.Drawing.Color.FromArgb(128, 255, 255);
            entry.ForeColor = System.Drawing.SystemColors.MenuText;
            entry.Location = new System.Drawing.Point(557, 206);
            entry.Name = "entry";
            entry.Size = new System.Drawing.Size(200, 27);
            entry.TabIndex = 13;
            // 
            // button2
            // 
            button2.BackColor = System.Drawing.Color.FromArgb(255, 128, 128);
            button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            button2.Location = new System.Drawing.Point(591, 261);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(124, 52);
            button2.TabIndex = 14;
            button2.Text = "FETCH DATA";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Issuebook
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImage = (System.Drawing.Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(button2);
            Controls.Add(entry);
            Controls.Add(label7);
            Controls.Add(comboBox1);
            Controls.Add(mail);
            Controls.Add(num);
            Controls.Add(name);
            Controls.Add(dateTimePicker1);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Issuebook";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Issuebook";
            Load += Issuebook_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox num;
        private System.Windows.Forms.TextBox mail;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox entry;
        private System.Windows.Forms.Button button2;
    }
}