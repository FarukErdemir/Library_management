using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace staj_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source=DESKTOP-1LMVRU2;database=library;integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from logintable where username = '" + txt_username.Text + "'and pass = '" + txt_password.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            if (ds.Tables[0].Rows.Count != 0)
            {
                this.Hide();
                Dashboard dss = new Dashboard();
                dss.Show();
            }
            else
            {
                MessageBox.Show("Wrong Username or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btn_signup_Click(object sender, EventArgs e)
        {

        }
    }
}
