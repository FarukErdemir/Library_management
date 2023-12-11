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
    public partial class Add_book : Form
    {
        public Add_book()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btn_booksave_Click(object sender, EventArgs e)
        {
            string bookname = txt_bookname.Text;
            string bookauthor = txt_bookauthor.Text;
            string bookpublication = txt_bookpub.Text;
            string pdate = dateTimePicker1.Text;
            Int64 price = Int64.Parse(txt_bookprice.Text);
            Int64 quantity = Int64.Parse(txt_bookqua.Text);

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-1LMVRU2;database=library;integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            con.Open();
            cmd.CommandText = "insert into newbook (bname,bauthor,bpubl,bpdatee,bprice,bquan) " +
                "values('" + bookname + "','" + bookauthor + "','" + bookpublication + "','" + pdate + "'," + price + "," + quantity + ")";

            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Data saved", "succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_bookcancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
