using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace staj_1
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aDDBOOKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_book adbk = new Add_book();
            adbk.Show();
        }

        private void vIEWBOOKSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Viewbook vb = new Viewbook();
            vb.Show();
        }

        private void aDDSTUDENTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Addstudent ad = new Addstudent();
            ad.Show();
        }

        private void vIEWSTUDENTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Viewstudent tv = new Viewstudent();
            tv.Show();
        }

        private void ıSSUEBOOKSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Issuebook ıssuebook = new Issuebook();
            ıssuebook.Show();
        }

        private void rETURNBOOKSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            returnbook r = new returnbook();
            r.Show();
        }
    }
}
