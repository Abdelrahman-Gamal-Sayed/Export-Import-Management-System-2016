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
    public partial class frmStore : Form
    {
        public frmStore()
        {
            InitializeComponent();
        }
        DB db = new DB();
        DataTable tblStore = new DataTable();
        int intRow = 0;

        private void FilltblStore(string SelectStatment = "Select * from Store ")
        {
            tblStore.Clear();
            tblStore.Columns.Clear();
            tblStore = db.RunReader(SelectStatment);

        }
        private void AutoNum()
        {
            FilltblStore("select max(StoreNO) from Store ");
            if (tblStore.Rows[0][0].ToString() != DBNull.Value.ToString())
                txtStoreNo.Text = (Convert.ToInt16(tblStore.Rows[0][0].ToString()) + 1).ToString();
            else
                txtStoreNo.Text = "1";

        }
        private void cleardata()
        {

            AutoNum();
            txtStoreName.Clear();
            //  txtitemno.Clear();
            txtAddress.Clear();
            //  nudpricet.Value = 100;
            txtPhone.Clear();

            btnEdite.Enabled = false;
            btnDel.Enabled = false;
            btnAdd.Enabled = true;


        }
        //private void CalcTotal()
        //{
        //    txttotal.Text = (nudQty.Value * NudPrice.Value).ToString();
        //}
        //private void ClearData()
        //{
        //    AutoNume();
        //    nudQty.Value = 1;
        //    NudPrice.Value = 100;
        //    txttotal.Clear();
        //    textBox4.Clear();
        //    btnEdite.Enabled = false;
        //    btnDel.Enabled = false;
        //    btnAdd.Enabled = true;
        //    cbxCust.Enabled = true;
        //    cbxItem.Enabled = true;


        //}
        private void ShowDataa()
        {
            FilltblStore();
            txtStoreNo.Text = tblStore.Rows[intRow][0].ToString();
            txtStoreName.Text = tblStore.Rows[intRow][1].ToString();
            txtAddress.Text = tblStore.Rows[intRow][2].ToString();
            txtPhone.Text = tblStore.Rows[intRow][3].ToString();
            btnEdite.Enabled = true;
            btnDel.Enabled = true;
            btnAdd.Enabled = false;
        }
        private void frmStore_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            db.RunNonQuery("insert into Store values(" + txtStoreNo.Text + ",'" + txtStoreName.Text + "','" + txtAddress.Text + "'," + txtPhone.Text + ")", "Done");
            cleardata();
        }

        private void btnEdite_Click(object sender, EventArgs e)
        {
            db.RunNonQuery("update  Store set StoreName ='" + txtStoreName.Text + "', Address ='" + txtAddress.Text + "',Phone ='" + txtPhone.Text + "' where StoreNO =" + txtStoreNo.Text, "Done");
            cleardata();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            db.RunNonQuery("Delete from  Store where StoreNo =" + txtStoreNo.Text, "Done");
            cleardata();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cleardata();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {

            intRow = 0;
            ShowDataa();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            FilltblStore();
            intRow = tblStore.Rows.Count - 1;
            ShowDataa();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            FilltblStore();
            if (intRow >= tblStore.Rows.Count - 1)
                MessageBox.Show("This Last Store", "This Last Store");
            else
            {
                intRow += 1;
                ShowDataa();
            }
        }

        private void btnBrev_Click(object sender, EventArgs e)
        {
            FilltblStore();
            if (intRow <= 0)
                MessageBox.Show("This Last Store", "This Last Store");
            else
            {
                intRow -= 1;
                ShowDataa();
            }
        }

        private void tbnSearch_Click(object sender, EventArgs e)
        {
            pnlsearch.Visible = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pnlsearch.Visible = false;
        }

        private void btnshowsearch_Click(object sender, EventArgs e)
        {

            string calname = "";
            if (rbtnIStoreNo.Checked == true)
                calname = "StoreNo";
            else if (rbtnIStoreName.Checked == true)
                calname = "StoreName";
            else if (rbtnIAddress.Checked == true)
                calname = "Address";

            else
                calname = "Phone";

            FilltblStore("Select * from Item where " + calname + " like'%" + txtsearch.Text + "%'");
            dgvsearch.DataSource = tblStore;
        }

        private void btnshowsearch1_Click(object sender, EventArgs e)
        {
            string calname = "";
            if (rbtnIStoreNo.Checked == true)
                calname = "StoreNo";
            else if (rbtnIStoreName.Checked == true)
                calname = "StoreName";
            else if (rbtnIAddress.Checked == true)
                calname = "Address";

            else
                calname = "Phone";

            FilltblStore("Select * from Item where " + calname + " like'%" + txtsearch.Text + "%'");
            dgvsearch.DataSource = tblStore;
        }

        private void txtsearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnshowsearch_Click(null, null);
            }
        }
    }
}
