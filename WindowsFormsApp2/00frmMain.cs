using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmHome fr = new frmHome();
            fr.MdiParent = this;
            fr.Show();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            frmHome fr = new frmHome();
            fr.MdiParent = this;
            fr.Show();
        }

        private void sbtnCust_Click(object sender, EventArgs e)
        {
            
            frmCustomer fr = new frmCustomer();
            fr.MdiParent = this;
            fr.Show();
        }

        private void sbtnItem_Click(object sender, EventArgs e)
        {

            frmItems fr = new frmItems();
            fr.MdiParent = this;
            fr.Show();
        }

        private void sbtnBuy_Click(object sender, EventArgs e)
        {
            frmBuy fr = new frmBuy();
            fr.MdiParent = this;
            fr.Show();
        }

        private void sbtnSale_Click(object sender, EventArgs e)
        {

            frmSale fr = new frmSale();
            fr.MdiParent = this;
            fr.Show();
        }

        private void sbtnStore_Click(object sender, EventArgs e)
        {
            frmStore fr = new frmStore();
            fr.MdiParent = this;
            fr.Show();
        }

        private void sbtnActionStore_Click(object sender, EventArgs e)
        {
            frmActionStore fr = new frmActionStore();
            fr.MdiParent = this;
            fr.Show();
        }

        private void sbtnStat_Click(object sender, EventArgs e)
        {
            frmStatistics fr = new frmStatistics();
            fr.MdiParent = this;
            fr.Show();
        }

        private void sbtnBackup_Click(object sender, EventArgs e)
        {
            frmBackup fr = new frmBackup();
            fr.MdiParent = this;
            fr.Show();
        }

        private void sbtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
