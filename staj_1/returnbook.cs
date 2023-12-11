using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace staj_1
{
    public partial class returnbook : Form
    {
        public returnbook()
        {
            InitializeComponent();
        }

        private void fetch_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source= DESKTOP-1LMVRU2; database= library ;integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from isbook where isnum = " + entry.Text + " and isbookreturndate IS NULL";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count != 0)
            {
                dataGridView1.DataSource = ds.Tables[0];
            }
            else
            {
                MessageBox.Show("Wrong id or no issue", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void returnn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-1LMVRU2; database = library ;integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = "update isbook set isbookreturndate='" + dateTimePicker1.Text + "' where isnum = " + entry.Text + " ";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Return Succesful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
