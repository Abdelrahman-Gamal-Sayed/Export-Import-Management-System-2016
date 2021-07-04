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
    public partial class frmItems : Form
    {
        public frmItems()
        {
            InitializeComponent();
        }
        DB db = new DB();
        DataTable tblItem = new DataTable();
        int intRow = 0;



        private void FilltblItem(string SelectStatment = "Select * from Item ")
        {
            tblItem.Clear();
            tblItem.Columns.Clear();
            tblItem = db.RunReader(SelectStatment);

        }
        private void AutoNume()
        {
            FilltblItem("select max(ItemNO) from Item " );
            if (tblItem.Rows[0][0].ToString() != DBNull.Value.ToString())
                txtitemno.Text = (Convert.ToInt16(tblItem.Rows[0][0].ToString()) + 1).ToString();
            else
                txtitemno.Text = "1";
           
          
        }
        private void ClearData ()
        {
            AutoNume();
            txtitemname.Clear();
          //  txtitemno.Clear();
            txtsymbol.Clear();
            nudpricet.Value = 100;
            btnEdite.Enabled = false;
            btnDel.Enabled = false;
            btnAdd.Enabled = true;
        }
        private void ShowDataa()
        {
            FilltblItem();
            txtitemno.Text = tblItem.Rows[intRow][0].ToString();
            txtitemname.Text= tblItem.Rows[intRow][1].ToString();
            txtsymbol.Text= tblItem.Rows[intRow][2].ToString();
            nudpricet.Value=Convert.ToInt32( tblItem.Rows[intRow][3]);
            
            btnEdite.Enabled = true;
            btnDel.Enabled = true;
            btnAdd.Enabled = false;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            db.RunNonQuery("insert into Item values (" + txtitemno.Text + ",'" + txtitemname.Text + "','" + txtsymbol.Text + "'," + nudpricet.Value + ")", " Item Added Successfully");
            ClearData();

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearData();
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

        private void btnBrev_Click(object sender, EventArgs e)
        {
            FilltblItem();
            if (intRow <= 0)
                MessageBox.Show("This First Customer", "This First Customer");
            else
            {
                intRow -= 1;
                ShowDataa();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            FilltblItem();
            if (intRow >= tblItem.Rows.Count - 1)
                MessageBox.Show("This Last Customer", "This Last Customer");
            else
            {
                intRow += 1;
                ShowDataa();
            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            FilltblItem();
            intRow = tblItem.Rows.Count - 1;
            ShowDataa();
        }

        private void frmItems_Load(object sender, EventArgs e)
        {
            ClearData();
        }

        private void btnEdite_Click(object sender, EventArgs e)
        {

            db.RunNonQuery("update  Item set ItemName = '" + txtitemname.Text + "', Symbol = '" + txtsymbol.Text + "',Pricet = " + nudpricet.Value + " where ItemNO = " + txtitemno.Text, " Item Updated Successfully");
            ClearData();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {

            db.RunNonQuery("Delete from Item   where ItemNO = " + txtitemno.Text, " Item Deleted Successfully");
            ClearData();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pnlsearch.Visible = false;
        }

        private void tbnSearch_Click(object sender, EventArgs e)
        {
            pnlsearch.Visible = true;
        }

        private void btnshowsearch_Click(object sender, EventArgs e)
        {

            string calname = "";
            if (rbtnItemNo.Checked == true)
                calname = "ItemNO";
            else if (rbtnItemName.Checked == true)
                calname = "ItemName";
            else if (rbtnSymbol.Checked == true)
                calname = "Symbol";
         
            else
                calname = "Pricet";

            FilltblItem("Select * from Item where " + calname + " like'%" + txtsearch.Text + "%'");
            dgvsearch.DataSource = tblItem;
        }

        private void btnshowsearch1_Click(object sender, EventArgs e)
        {
            string calname = "";
            if (rbtnItemNo.Checked == true)
                calname = "ItemNO";
            else if (rbtnItemName.Checked == true)
                calname = "ItemName";
            else if (rbtnSymbol.Checked == true)
                calname = "Symbol";

            else
                calname = "Pricet";

            FilltblItem("Select * from Item where " + calname + " like'%" + txtsearch.Text + "%'");
            dgvsearch.DataSource = tblItem;
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtsearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                btnshowsearch_Click(null, null);
            }
        }
    }

}
