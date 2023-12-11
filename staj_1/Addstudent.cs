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
    public partial class Addstudent : Form
    {
        public Addstudent()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_stusave_Click(object sender, EventArgs e)
        {
            string name=txt_stuname.Text;
            Int64 num=Int64.Parse(txt_stunum.Text);
            Int64 no=Int64.Parse(txt_stuno.Text);
            string mail=txt_stumail.Text;

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-1LMVRU2;database =library;integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = "insert into newstudent (sname,smail,sno,snum) " +
                "values ('" + name + "','" + mail + "'," + no + "," + num + ")";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data saved", "succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
