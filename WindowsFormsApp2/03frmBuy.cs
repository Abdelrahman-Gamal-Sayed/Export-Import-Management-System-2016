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
    public partial class frmBuy : Form
    {
        public frmBuy()
        {
            InitializeComponent();
        }
        DB db = new DB();
        DataTable tblBuy = new DataTable();
        int intRow = 0;
        private void filltblBuy(string selectstatment = "select * from Buying")
        {
            tblBuy.Clear();
            tblBuy = db.RunReader(selectstatment);
        }

        private void fillCust()
        {
            cbxCust.DataSource = db.RunReader("select CustNO , CustName from Customer");
            cbxCust.DisplayMember = "CustName";
            cbxCust.ValueMember = "CustNO";
        }
        private void fillitem()
        {
            cbxItem.DataSource = db.RunReader("select ItemNO , ItemName from Item");
            cbxItem.DisplayMember = "ItemName";
            cbxItem.ValueMember = "ItemNO";
        }
        private void frmBuy_Load(object sender, EventArgs e)
        {
            fillCust();
            fillitem();
            cbxDay.SelectedIndex = 0;
            ClearData();
        }
        private void CalcTotal()
        {
            txttotal.Text = (nudQty.Value * NudPrice.Value).ToString();
        }
        private void nudQty_ValueChanged(object sender, EventArgs e)
        {
            CalcTotal();
        }

        private void NudPrice_ValueChanged(object sender, EventArgs e)
        {
            CalcTotal();
        }
        private void ClearData()
        {
            AutoNume();
            nudQty.Value = 1;
            NudPrice.Value = 100;
            txttotal.Clear();
            textBox4.Clear();
            btnEdite.Enabled = false;
            btnDel.Enabled = false;
            btnAdd.Enabled = true;
            cbxCust.Enabled = true;
            cbxItem.Enabled = true;


        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            db.RunNonQuery("insert into Buying Values (" +txtActionno.Text +","+ cbxCust.SelectedValue + "," + cbxItem.SelectedValue + "," + (cbxDay.SelectedIndex + 1).ToString() + ",'" + dtpDate.Text + "','" + nudQty.Value.ToString() + "','" + NudPrice.Value.ToString() + "','" + textBox4.Text + "')", "Added -_O ");
            ClearData();
        }

        private void btnEdite_Click(object sender, EventArgs e)
        {
            db.RunNonQuery("update Buying set DayNO =" + (cbxDay.SelectedIndex + 1).ToString() + ", BuyDate ='" + dtpDate.Text + "',QTY ='" + nudQty.Value.ToString() + "',Price = '" + NudPrice.Value.ToString() + "',Details = '" + textBox4.Text + "' Where BuyNO="+txtActionno.Text +"and CustNO = " + cbxCust.SelectedValue + "and ItemNO =" + cbxItem.SelectedValue  , "Edited -_O ");
            ClearData();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            db.RunNonQuery("delete from Buying Where BuyNO=" + txtActionno.Text + "and CustNO = " + cbxCust.SelectedValue + "and ItemNO =" + cbxItem.SelectedValue, "deleted -_O ");
            ClearData();
        }
        private void AutoNume()
        {
            filltblBuy("select max(BuyNO) from Buying ");
            if (tblBuy.Rows[0][0].ToString() != DBNull.Value.ToString())
                txtActionno.Text = (Convert.ToInt16(tblBuy.Rows[0][0].ToString()) + 1).ToString();
            else
                txtActionno.Text = "1";


        }

        private void ShowData()
        {
            filltblBuy();
            txtActionno.Text = tblBuy.Rows[intRow][0].ToString();
            cbxCust.SelectedValue = tblBuy.Rows[intRow][1].ToString();
            cbxItem.SelectedValue = tblBuy.Rows[intRow][2].ToString();
            cbxDay.SelectedIndex = Convert.ToInt16( tblBuy.Rows[intRow][3]) - 1;
            dtpDate.Text = tblBuy.Rows[intRow][4].ToString();
            nudQty.Value = Convert.ToInt16(tblBuy.Rows[intRow][5]);
            NudPrice.Value = Convert.ToInt32(tblBuy.Rows[intRow][6]);
            textBox4.Text = tblBuy.Rows[intRow][7].ToString();
            btnEdite.Enabled = true;
            btnDel.Enabled = true;
            btnAdd.Enabled = false;
            cbxCust.Enabled = false;
            cbxItem.Enabled = false;
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            intRow = 0;
            ShowData();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            filltblBuy();
            intRow = tblBuy.Rows.Count - 1;
            ShowData();
        }

        private void btnBrev_Click(object sender, EventArgs e)
        {
            filltblBuy();
            if (intRow <= 0)
                MessageBox.Show("This First Customer", "This First Customer");
            else
            {
                intRow -= 1;
                ShowData();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            filltblBuy();
            if (intRow >= tblBuy.Rows.Count - 1)
                MessageBox.Show("This Last Customer", "This Last Customer");
            else
            {
                intRow += 1;
                ShowData();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void btncreateview_Click(object sender, EventArgs e)
        {
            db.RunNonQuery("create view BuyALL2 as select Buying.CustNO ,Custname , Buying.ItemNO,ItemName,Buying.DayNO,DayName,BuyDate,QTY,Price,Details from Buying,Customer,Item,Days where Buying.CustNO=Customer.CustNO and Buying.ItemNO=Item.ItemNO and Buying.DayNO=Days.DayNO","OK");
        }

        private void tbnSearch_Click(object sender, EventArgs e)
        {
            pnlsearch.Visible = true;
        }

        private void btnshowsearch_Click(object sender, EventArgs e)
        {

            string calname = "";
            if (rbtnCustNo.Checked == true)
                calname = "CustNO";
            else if (rbtnCustStartDate.Checked == true)
                calname = "CustName";
            else if (rbtnItemNo.Checked == true)
                calname = "ItemNO";
            else if (rbtnItemName.Checked == true)
                calname = "ItemName";
            else if (rbtnDay.Checked == true)
                calname = "DayName";
            else if (rbtnDate.Checked == true)
                calname = "BuyDate";
            else if (rbtnQTY.Checked == true)
                calname = "QTY";

            else
                calname = "Price";


            dgvsearch.DataSource = db.RunReader("Select * from BuyALL where " + calname + " like'%" + txtsearch.Text + "%'");
        }

        private void btnshowsearch1_Click(object sender, EventArgs e)
        {
           btnshowsearch_Click(null, null);

        }

        private void txtsearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnshowsearch_Click(null, null);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pnlsearch.Visible = false;
        }
    }
}
