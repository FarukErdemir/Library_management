namespace staj_1
{
    partial class returnbook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(returnbook));
            dataGridView1 = new System.Windows.Forms.DataGridView();
            label1 = new System.Windows.Forms.Label();
            fetch = new System.Windows.Forms.Button();
            entry = new System.Windows.Forms.TextBox();
            returnn = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new System.Drawing.Point(281, 96);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new System.Drawing.Size(920, 332);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.FromArgb(255, 192, 192);
            label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(12, 96);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(263, 35);
            label1.TabIndex = 1;
            label1.Text = "STUDENT SEARCH NO";
            // 
            // fetch
            // 
            fetch.BackColor = System.Drawing.Color.Cyan;
            fetch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            fetch.Location = new System.Drawing.Point(84, 258);
            fetch.Name = "fetch";
            fetch.Size = new System.Drawing.Size(110, 58);
            fetch.TabIndex = 2;
            fetch.Text = "FETCH DATA";
            fetch.UseVisualStyleBackColor = false;
            fetch.Click += fetch_Click;
            // 
            // entry
            // 
            entry.BackColor = System.Drawing.SystemColors.InactiveCaption;
            entry.Location = new System.Drawing.Point(12, 194);
            entry.Name = "entry";
            entry.Size = new System.Drawing.Size(250, 27);
            entry.TabIndex = 3;
            // 
            // returnn
            // 
            returnn.BackColor = System.Drawing.Color.Lime;
            returnn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            returnn.Location = new System.Drawing.Point(84, 384);
            returnn.Name = "returnn";
            returnn.Size = new System.Drawing.Size(110, 65);
            returnn.TabIndex = 4;
            returnn.Text = "RETURN";
            returnn.UseVisualStyleBackColor = false;
            returnn.Click += returnn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.FromArgb(255, 224, 192);
            label2.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(528, 26);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(359, 67);
            label2.TabIndex = 5;
            label2.Text = "RETURN BOOK";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new System.Drawing.Point(25, 338);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new System.Drawing.Size(250, 27);
            dateTimePicker1.TabIndex = 6;
            // 
            // returnbook
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImage = (System.Drawing.Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(1342, 461);
            Controls.Add(dateTimePicker1);
            Controls.Add(label2);
            Controls.Add(returnn);
            Controls.Add(entry);
            Controls.Add(fetch);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "returnbook";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "returnbook";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button fetch;
        private System.Windows.Forms.TextBox entry;
        private System.Windows.Forms.Button returnn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}