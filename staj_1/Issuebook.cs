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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace staj_1
{
    public partial class Issuebook : Form
    {
        public Issuebook()
        {
            InitializeComponent();
        }

        private void Issuebook_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source =DESKTOP-1LMVRU2; database= library; integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd = new SqlCommand("select bname from newbook", con);
            SqlDataReader Sdr = cmd.ExecuteReader();
            while (Sdr.Read())
            {
                for (int i = 0; i < Sdr.FieldCount; i++)
                {
                    comboBox1.Items.Add(Sdr.GetString(i));
                }
            }
            Sdr.Close();
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (entry.Text != "")
            {
                String eid = entry.Text;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source =DESKTOP-1LMVRU2; database= library; integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select * from newstudent where snum = " + eid + "";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);
                if (DS.Tables[0].Rows.Count != 0)
                {
                    name.Text = DS.Tables[0].Rows[0][0].ToString();
                    num.Text = DS.Tables[0].Rows[0][1].ToString();
                    mail.Text = DS.Tables[0].Rows[0][3].ToString();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (name.Text != "")
            {
                
                String numm = entry.Text;
                String isname = name.Text;
                Int64 iscontact = Int64.Parse(num.Text);
                String email = mail.Text;
                String bookname = comboBox1.Text;
                String isbookdate = dateTimePicker1.Text;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source =DESKTOP-1LMVRU2; database= library; integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                con.Open();
                cmd.CommandText = cmd.CommandText = "insert into isbook (isnum, isname, ismail, isbookname, isbookissuedate, iscontact) " +
                    "values('" + numm + "','" + isname + "','" + email + "','" + bookname + "','" + isbookdate + "'," + iscontact + ")";
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Book Issued.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
        }
    }
}
