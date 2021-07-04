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
    public partial class frmSale : Form
    {
        public frmSale()
        {
            InitializeComponent();
        }
        DB db = new DB();
        DataTable tblSale = new DataTable();
        int intRow = 0;
        string CusNO;
        string ItemNO;
        private void filltblSale(string selectstatment = "select * from Selling")
        {
            tblSale.Clear();
            tblSale = db.RunReader(selectstatment);
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
        private void ShowData()
        {
            filltblSale();
            txtActionno.Text = tblSale.Rows[intRow][0].ToString();
            cbxCust.SelectedValue = tblSale.Rows[intRow][1].ToString();
            cbxItem.SelectedValue = tblSale.Rows[intRow][2].ToString();
            cbxDay.SelectedIndex = Convert.ToInt16(tblSale.Rows[intRow][3]) - 1;
            dtpDate.Text = tblSale.Rows[intRow][4].ToString();
            nudQty.Value = Convert.ToInt16(tblSale.Rows[intRow][5]);
            NudPrice.Value = Convert.ToInt32(tblSale.Rows[intRow][6]);
            textBox4.Text = tblSale.Rows[intRow][7].ToString();
            btnEdite.Enabled = true;
            btnDel.Enabled = true;
            btnAdd.Enabled = false;
            cbxCust.Enabled = false;
            cbxItem.Enabled = false;
        }
        private void CalcTotal()
        {
            txttotal.Text = (nudQty.Value * NudPrice.Value).ToString();
        }
        private void AutoNume()
        {
            filltblSale("select max(SaleNO) from Selling ");
            if (tblSale.Rows[0][0].ToString() != DBNull.Value.ToString())
                txtActionno.Text = (Convert.ToInt16(tblSale.Rows[0][0].ToString()) + 1).ToString();
            else
                txtActionno.Text = "1";


        }
        private void frmSale_Load(object sender, EventArgs e)
        {
            fillCust();
            fillitem();
            cbxDay.SelectedIndex = 0;
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
        int price;
        private bool CkeckPrice()
        {
            price=Convert.ToInt32( db.RunReader("select Pricet from Item where ItemNO = " + cbxItem.SelectedValue).Rows[0][0]);
            if (NudPrice.Value < price)
                return false;
            else
                return true;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (CkeckPrice())
            {
                db.RunNonQuery("insert into Selling Values (" + txtActionno.Text + "," + cbxCust.SelectedValue + "," + cbxItem.SelectedValue + "," + (cbxDay.SelectedIndex + 1).ToString() + ",'" + dtpDate.Text + "','" + nudQty.Value.ToString() + "','" + NudPrice.Value.ToString() + "','" + textBox4.Text + "')", "Added -_O ");
                ClearData();
            }
            else
                MessageBox.Show("Price of selling  lower than the Price of Item Price of Item = " + price);
        }

        private void btnEdite_Click(object sender, EventArgs e)
        {
       

            if (CkeckPrice())
            {

                db.RunNonQuery("update Selling set DayNO =" + (cbxDay.SelectedIndex + 1).ToString() + ", SallDate ='" + dtpDate.Text + "',QTY ='" + nudQty.Value.ToString() + "',Price = '" + NudPrice.Value.ToString() + "',Details = '" + textBox4.Text + "' Where SaleNO=" + txtActionno.Text + "and CustNO = " + cbxCust.SelectedValue + "and ItemNO =" + cbxItem.SelectedValue, "Edited -_O ");
                ClearData();
            }
            else
                MessageBox.Show("Price of selling  lower than the Price of Item");
        }

        private void btnDel_Click(object sender, EventArgs e)
        {

            db.RunNonQuery("delete from Saellingg Where SaleNO=" + txtActionno.Text + "and CustNO = " + cbxCust.SelectedValue + "and ItemNO =" + cbxItem.SelectedValue, "deleted -_O ");
            ClearData();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            intRow = 0;
            ShowData();
        }

        private void btnBrev_Click(object sender, EventArgs e)
        {

            filltblSale();
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
            filltblSale();
            if (intRow >= tblSale.Rows.Count - 1)
                MessageBox.Show("This Last Customer", "This Last Customer");
            else
            {
                intRow += 1;
                ShowData();
            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {

            filltblSale();
            intRow = tblSale.Rows.Count - 1;
            ShowData();
        }

        private void tbnSearch_Click(object sender, EventArgs e)
        {

            pnlsearch.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            db.RunNonQuery("create view SallALL as select Selling.CustNO ,Custname , Selling.ItemNO,ItemName,Selling.DayNO,DayName,SallDate,QTY,Price,Details from Selling,Customer,Item,Days where Selling.CustNO=Customer.CustNO and Selling.ItemNO=Item.ItemNO and Selling.DayNO=Days.DayNO", "OK");

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pnlsearch.Visible = false;
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
                calname = "SellDate";
            else if (rbtnQTY.Checked == true)
                calname = "QTY";

            else
                calname = "Price";


            dgvsearch.DataSource = db.RunReader("Select * from SallALL where " + calname + " like'%" + txtsearch.Text + "%'");
        }

        private void nudQty_ValueChanged(object sender, EventArgs e)
        {
            CalcTotal();
        }

        private void NudPrice_ValueChanged(object sender, EventArgs e)
        {
            CalcTotal();
        }
    }
}
