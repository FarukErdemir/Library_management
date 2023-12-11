namespace staj_1
{
    partial class Add_book
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_book));
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            btn_booksave = new System.Windows.Forms.Button();
            btn_bookcancel = new System.Windows.Forms.Button();
            dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            txt_bookname = new System.Windows.Forms.TextBox();
            txt_bookauthor = new System.Windows.Forms.TextBox();
            txt_bookprice = new System.Windows.Forms.TextBox();
            txt_bookpub = new System.Windows.Forms.TextBox();
            txt_bookqua = new System.Windows.Forms.TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Gray;
            label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.SystemColors.Control;
            label1.Location = new System.Drawing.Point(294, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(190, 46);
            label1.TabIndex = 0;
            label1.Text = "ADD BOOK";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.Gray;
            label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            label2.Location = new System.Drawing.Point(200, 97);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(51, 20);
            label2.TabIndex = 1;
            label2.Text = "NAME";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.Color.Gray;
            label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            label3.Location = new System.Drawing.Point(200, 140);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(68, 20);
            label3.TabIndex = 2;
            label3.Text = "AUTHOR";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = System.Drawing.Color.Gray;
            label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            label4.Location = new System.Drawing.Point(200, 182);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(99, 20);
            label4.TabIndex = 3;
            label4.Text = "PUBLICATION";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = System.Drawing.Color.Gray;
            label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            label5.Location = new System.Drawing.Point(200, 229);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(47, 20);
            label5.TabIndex = 4;
            label5.Text = "PRICE";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = System.Drawing.Color.Gray;
            label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            label6.Location = new System.Drawing.Point(200, 278);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(79, 20);
            label6.TabIndex = 5;
            label6.Text = "QUANTITY";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = System.Drawing.Color.Gray;
            label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            label7.Location = new System.Drawing.Point(200, 321);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(122, 20);
            label7.TabIndex = 6;
            label7.Text = "PURCHASE DATE";
            // 
            // btn_booksave
            // 
            btn_booksave.BackColor = System.Drawing.Color.Lime;
            btn_booksave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btn_booksave.Location = new System.Drawing.Point(230, 387);
            btn_booksave.Name = "btn_booksave";
            btn_booksave.Size = new System.Drawing.Size(94, 29);
            btn_booksave.TabIndex = 7;
            btn_booksave.Text = "SAVE";
            btn_booksave.UseVisualStyleBackColor = false;
            btn_booksave.Click += btn_booksave_Click;
            // 
            // btn_bookcancel
            // 
            btn_bookcancel.BackColor = System.Drawing.Color.Red;
            btn_bookcancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btn_bookcancel.Location = new System.Drawing.Point(490, 387);
            btn_bookcancel.Name = "btn_bookcancel";
            btn_bookcancel.Size = new System.Drawing.Size(94, 29);
            btn_bookcancel.TabIndex = 8;
            btn_bookcancel.Text = "CANCEL";
            btn_bookcancel.UseVisualStyleBackColor = false;
            btn_bookcancel.Click += btn_bookcancel_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new System.Drawing.Point(334, 314);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new System.Drawing.Size(250, 27);
            dateTimePicker1.TabIndex = 9;
            // 
            // txt_bookname
            // 
            txt_bookname.BackColor = System.Drawing.Color.FromArgb(255, 224, 192);
            txt_bookname.Location = new System.Drawing.Point(334, 90);
            txt_bookname.Name = "txt_bookname";
            txt_bookname.Size = new System.Drawing.Size(250, 27);
            txt_bookname.TabIndex = 10;
            // 
            // txt_bookauthor
            // 
            txt_bookauthor.BackColor = System.Drawing.Color.FromArgb(255, 224, 192);
            txt_bookauthor.Location = new System.Drawing.Point(334, 133);
            txt_bookauthor.Name = "txt_bookauthor";
            txt_bookauthor.Size = new System.Drawing.Size(250, 27);
            txt_bookauthor.TabIndex = 11;
            // 
            // txt_bookprice
            // 
            txt_bookprice.BackColor = System.Drawing.Color.FromArgb(255, 224, 192);
            txt_bookprice.Location = new System.Drawing.Point(334, 222);
            txt_bookprice.Name = "txt_bookprice";
            txt_bookprice.Size = new System.Drawing.Size(250, 27);
            txt_bookprice.TabIndex = 12;
            // 
            // txt_bookpub
            // 
            txt_bookpub.BackColor = System.Drawing.Color.FromArgb(255, 224, 192);
            txt_bookpub.Location = new System.Drawing.Point(334, 175);
            txt_bookpub.Name = "txt_bookpub";
            txt_bookpub.Size = new System.Drawing.Size(250, 27);
            txt_bookpub.TabIndex = 12;
            // 
            // txt_bookqua
            // 
            txt_bookqua.BackColor = System.Drawing.Color.FromArgb(255, 224, 192);
            txt_bookqua.Location = new System.Drawing.Point(334, 271);
            txt_bookqua.Name = "txt_bookqua";
            txt_bookqua.Size = new System.Drawing.Size(250, 27);
            txt_bookqua.TabIndex = 13;
            // 
            // Add_book
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(0, 64, 0);
            BackgroundImage = (System.Drawing.Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(txt_bookqua);
            Controls.Add(txt_bookpub);
            Controls.Add(txt_bookprice);
            Controls.Add(txt_bookauthor);
            Controls.Add(txt_bookname);
            Controls.Add(dateTimePicker1);
            Controls.Add(btn_bookcancel);
            Controls.Add(btn_booksave);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Add_book";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Add_book";
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
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_booksave;
        private System.Windows.Forms.Button btn_bookcancel;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txt_bookname;
        private System.Windows.Forms.TextBox txt_bookauthor;
        private System.Windows.Forms.TextBox txt_bookprice;
        private System.Windows.Forms.TextBox txt_bookpub;
        private System.Windows.Forms.TextBox txt_bookqua;
    }
}