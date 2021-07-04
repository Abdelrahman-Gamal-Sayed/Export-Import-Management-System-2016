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
    public partial class frmActionStore : Form
    {
        public frmActionStore()
        {
            InitializeComponent();
        }
        DB db = new DB();
        DataTable tblAction = new DataTable();
        int intRow = 0;
        string CustNO;
        string ItrmNO;
        string StoreNO;
        private void SetCustItemOut()
        {
            CustNO = cbxCustOut.SelectedValue.ToString();

            ItrmNO = cbxItemOut.SelectedValue.ToString();

            StoreNO = cbxStoreOut.SelectedValue.ToString();
        }
        private void SetCustItemIn()
        {
            CustNO = cbxCustIn.SelectedValue.ToString();

            ItrmNO = cbxItemIn.SelectedValue.ToString();

            StoreNO = cbxStoreIn.SelectedValue.ToString();
        }
        private void filltblActionOut(string selectstatment = "select * from Action_In")
        {
            tblAction.Clear();
            tblAction = db.RunReader(selectstatment);
        }
        private void filltblActionIn(string selectstatment = "select * from Action_Out")
        {
            tblAction.Clear();
            tblAction = db.RunReader(selectstatment);
        }
        private void AutoNume()
        {
            filltblActionOut("select max(ActionOutNO) from Action_Out ");
            if (tblAction.Rows[0][0].ToString() != DBNull.Value.ToString())
                txtNOOut.Text = (Convert.ToInt16(tblAction.Rows[0][0].ToString()) + 1).ToString();
            else
                txtNOOut.Text = "1";

           
                filltblActionIn("select max(ActionNO) from Action_In ");
                if (tblAction.Rows[0][0].ToString() != DBNull.Value.ToString())
                    txtInNO.Text = (Convert.ToInt16(tblAction.Rows[0][0].ToString()) + 1).ToString();
                else
                txtInNO.Text = "1";


           
        }


        private void ShowDataOut()
        {
            filltblActionOut();
            txtNOOut.Text = tblAction.Rows[intRow][0].ToString();
            cbxCustOut.SelectedValue = tblAction.Rows[intRow][1].ToString();
            cbxItemOut.SelectedValue = tblAction.Rows[intRow][2].ToString();
            cbxStoreOut.SelectedIndex = Convert.ToInt16(tblAction.Rows[intRow][3]) - 1;
            nudQTYOut.Value = Convert.ToInt16(tblAction.Rows[intRow][4]);
            nudPriceOut.Value = Convert.ToInt32(tblAction.Rows[intRow][5]);
            dtpDateOut.Text = tblAction.Rows[intRow][6].ToString();
            txtDetailsOut.Text = tblAction.Rows[intRow][7].ToString();

            btnEditeOut.Enabled = true;
            btnDelOut.Enabled = true;
            btnAddOut.Enabled = false;
            cbxCustOut.Enabled = false;
            cbxItemOut.Enabled = false;
        }
        private void ShowDataIn()
        {
            filltblActionIn();
            txtInNO.Text = tblAction.Rows[intRow][0].ToString();
            cbxCustIn.SelectedValue = tblAction.Rows[intRow][1].ToString();
            cbxItemIn.SelectedValue = tblAction.Rows[intRow][2].ToString();
            cbxStoreIn.SelectedIndex = Convert.ToInt16(tblAction.Rows[intRow][3]) - 1;
            nudQTYIn.Value = Convert.ToInt16(tblAction.Rows[intRow][4]);
            nudPriceIn.Value = Convert.ToInt32(tblAction.Rows[intRow][5]);
            dtpDateIn.Text = tblAction.Rows[intRow][6].ToString();
            txtDetialsIn.Text = tblAction.Rows[intRow][7].ToString();

            btnEditIn.Enabled = true;
            btnDeleteIIn.Enabled = true;
            btnAddin.Enabled = false;
            cbxCustIn.Enabled = false;
            cbxItemIn.Enabled = false;
        }
        private void ClearData()
        {
            AutoNume();
            txtDetailsOut.Clear();
            txtDetialsIn.Clear();
        }
        private void fillCust()
        {
            cbxCustOut.DataSource = db.RunReader("select CustNO , CustName from Customer");
            cbxCustOut.DisplayMember = "CustName";
            cbxCustOut.ValueMember = "CustNO";
            cbxCustIn.DataSource = db.RunReader("select CustNO , CustName from Customer");
            cbxCustIn.DisplayMember = "CustName";
            cbxCustIn.ValueMember = "CustNO";
        }
        private void fillitem()
        {
            cbxItemOut.DataSource = db.RunReader("select ItemNO , ItemName from Item");
            cbxItemOut.DisplayMember = "ItemName";
            cbxItemOut.ValueMember = "ItemNO";
            cbxItemIn.DataSource = db.RunReader("select ItemNO , ItemName from Item");
            cbxItemIn.DisplayMember = "ItemName";
            cbxItemIn.ValueMember = "ItemNO";
        }
        private void fillStore()
        {
            cbxStoreOut.DataSource = db.RunReader("select  StoreName , StoreNO from Store");
            cbxStoreOut.DisplayMember = "StoreName";
            cbxStoreOut.ValueMember = "StoreNO";
            cbxStoreIn.DataSource = db.RunReader("select StoreName , StoreNO from Store");
            cbxStoreIn.DisplayMember = "StoreName";
            cbxStoreIn.ValueMember = "StoreNO";
        }
        private void frmActionStore_Load(object sender, EventArgs e)
        {
            fillCust();
            fillitem();
            fillStore();
            ClearData();
        }

        private void btnFirstout_Click(object sender, EventArgs e)
        {
            intRow = 0;
            ShowDataOut();
        }

        private void btnFirstin_Click(object sender, EventArgs e)
        {
            intRow = 0;
            ShowDataIn();
        }

        private void btnBrevin_Click(object sender, EventArgs e)
        {
            filltblActionIn();
            if (intRow <= 0)
                MessageBox.Show("This First Customer", "This First Customer");
            else
            {
                intRow -= 1;
                ShowDataIn();
            }
        }

        private void btnBrevout_Click(object sender, EventArgs e)
        {
            filltblActionOut();
            if (intRow <= 0)
                MessageBox.Show("This First Customer", "This First Customer");
            else
            {
                intRow -= 1;
                ShowDataOut();
            }
        }

        private void btnNextout_Click(object sender, EventArgs e)
        {
            filltblActionOut();
            if (intRow >= tblAction.Rows.Count - 1)
                MessageBox.Show("This Last Customer", "This Last Customer");
            else
            {
                intRow += 1;
                ShowDataOut();
            }
        }

        private void btnNextin_Click(object sender, EventArgs e)
        {
            filltblActionIn();
            if (intRow >= tblAction.Rows.Count - 1)
                MessageBox.Show("This Last Customer", "This Last Customer");
            else
            {
                intRow += 1;
                ShowDataIn();
            }
        }

        private void btnLastin_Click(object sender, EventArgs e)
        {
            filltblActionIn();
            intRow = tblAction.Rows.Count - 1;
            ShowDataIn();
        }

        private void btnLastout_Click(object sender, EventArgs e)
        {
            filltblActionOut();
            intRow = tblAction.Rows.Count - 1;
            ShowDataOut();
        }

        private void btnAddOut_Click(object sender, EventArgs e)
        {
         //   MessageBox.Show(cbxItemOut.ValueMember.ToString());
            db.RunNonQuery("insert into Action_Out values (" + txtNOOut.Text + "," + cbxCustOut.SelectedValue + "," + cbxItemOut.SelectedValue + "," + cbxStoreOut.SelectedValue + "," + nudQTYOut.Value + "," + nudPriceOut.Value + ",'" + dtpDateOut.Text + "','" + txtDetailsOut.Text + "')", " Item Added Successfully");
            ClearData();
        }

        private void btnAddin_Click(object sender, EventArgs e)
        {
            db.RunNonQuery("insert into Action_In values (" + txtInNO.Text + "," + cbxCustIn.SelectedValue + "," + cbxItemIn.SelectedValue + "," + cbxStoreIn.SelectedValue + "," + nudQTYIn.Value + "," + nudPriceIn.Value + ",'" + dtpDateIn.Text + "','" + txtDetialsIn.Text + "')", " Item Added Successfully");
            ClearData();
        }

        private void btnClearIn_Click(object sender, EventArgs e)
        {
            ClearData();
            AutoNume();
        }

        private void btnEditeOut_Click(object sender, EventArgs e)
        {
            ClearData();
            AutoNume();
        }

        private void btnExitOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExitIn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
