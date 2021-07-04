using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;

namespace WindowsFormsApp2
{
    public partial class frmCustomer : Form
    {
        
        public frmCustomer()
        {
            InitializeComponent();
        }


        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""|DataDirectory|\Company.mdf"";Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        DataTable tblCust = new DataTable();
        DataTable tblPhones = new DataTable();
        int intRow = 0;
        private void FilltblCust(string strselect = "select * From Customer")
        {
            

            tblCust.Clear();
            tblCust.Columns.Clear();
            cmd.Connection = conn;
            cmd.CommandText = strselect;
            conn.Open();
            tblCust.Load(cmd.ExecuteReader());
            conn.Close();
         


        }
        private void ShowData ()
        {
            //Show Customer
            FilltblCust();
            txtCustNo.Text = tblCust.Rows[intRow][0].ToString();
            txtCustName.Text = tblCust.Rows[intRow][1].ToString();
            dtpStartDate.Text = tblCust.Rows[intRow][2].ToString();
            txtEmail.Text = tblCust.Rows[intRow][3].ToString();
            txtAddress.Text = tblCust.Rows[intRow][4].ToString();

            //Show Phones
            tblPhones.Clear();
            cmd.Connection = conn;
            cmd.CommandText = "select phone,type From Phone_Customer where CustNO = " + txtCustNo.Text;
            conn.Open();
            tblPhones.Load(cmd.ExecuteReader());
            conn.Close();
            dgvphones.Rows.Clear();

            foreach (DataRow row in tblPhones.Rows)
            {
                dgvphones.Rows.Add(1);
                int newRowIndex = dgvphones.Rows.Count - 2;
                dgvphones.Rows[newRowIndex].Cells[0].Value = row[0];
                dgvphones.Rows[newRowIndex].Cells[1].Value = row[1];
            }

            btnDel.Enabled = true;
            btnEdite.Enabled = true;
            btnAdd.Enabled = false;


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnaddphone_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvphones.Rows)
            {
                if (row.Cells[0].Value != null)
                {
                    if (txtphone.Text == row.Cells[0].Value.ToString())
                    {
                        MessageBox.Show(" This Number  already exist , Please check the Numbers", "Duplicate Number");
                        return;
                    }
                }
            }
            dgvphones.Rows.Add(1);
            int newRowIndex = dgvphones.Rows.Count - 2;
            dgvphones.Rows[newRowIndex].Cells[0].Value = txtphone.Text;
            dgvphones.Rows[newRowIndex].Cells[1].Value = cbxtype.Text;
            txtphone.Clear();
            //cbxtype.ResetText();

        }

        private void delall_Click(object sender, EventArgs e)
        {
            dgvphones.Rows.Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            // Add Custome
            cmd.Connection = conn;
            cmd.CommandText = "insert into Customer Values(" + txtCustNo.Text + ",'" + txtCustName.Text + "','" + dtpStartDate.Text + "','" + txtEmail.Text + "','" + txtAddress.Text + "')";
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            //Add phones
            conn.Open();
            foreach(DataGridViewRow row in dgvphones.Rows)
            {
                if (row.Cells[0].Value != null)
                {
                    cmd.CommandText = "insert into Phone_Customer values(" + txtCustNo.Text + ",'" + row.Cells[0].Value + "','" + row.Cells[1].Value + "')";
                    cmd.ExecuteNonQuery();
                }
            }

            conn.Close();
            MessageBox.Show(txtCustName.Text+"  Added  Successfully", "Add Customer Successfully");
            ClearData();
       
            
            
          
        }
        private void ClearData()
        {
            
            txtAddress.Clear();         
            txtCustName.Clear();
            txtCustNo.Clear();
            txtEmail.Clear();
            dgvphones.Rows.Clear();
            dtpStartDate.Text = DateTime.Now.Date.ToShortDateString();
            btnDel.Enabled = false;
            btnEdite.Enabled = false;
            btnAdd.Enabled = true;
            Autonumber();
        }
        private void Autonumber()
        {
            FilltblCust("select max(CustNO) from Customer ");
            

            if (tblCust.Rows[0][0].ToString() != DBNull.Value.ToString())
                txtCustNo.Text = (Convert.ToInt32(tblCust.Rows[0][0].ToString()) + 1).ToString();
            else
                txtCustNo.Text = "1";
        }
        private void frmCustomer_Load(object sender, EventArgs e)
        {
            Autonumber();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            intRow = 0;
            ShowData();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            FilltblCust();
            intRow = tblCust.Rows.Count - 1;
            ShowData();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            FilltblCust();
            if (intRow >= tblCust.Rows.Count - 1)
                MessageBox.Show("This Last Customer", "This Last Customer");
            else
            {
                intRow += 1;
                ShowData();
            }

        }

        private void btnBrev_Click(object sender, EventArgs e)
        {
            FilltblCust();
            if (intRow <= 0)
                MessageBox.Show("This First Customer", "This First Customer");
            else
            {
                intRow -= 1;
                ShowData();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void btnEdite_Click(object sender, EventArgs e)
        {

            // Update Custome
            cmd.Connection = conn;
            cmd.CommandText = "update Customer set CustName = '" + txtCustName.Text + "', StartDate = '" + dtpStartDate.Text + "', Email ='" + txtEmail.Text + "', Address ='" + txtAddress.Text + "' where CustNO =" + txtCustNo.Text;
            conn.Open();
            cmd.ExecuteNonQuery();
        
            // Delete All Phones For Customer
      
            cmd.CommandText = "delete from Phone_Customer where CustNo =" + txtCustNo.Text;
       
            cmd.ExecuteNonQuery();

         

            //Add phones
           
            foreach (DataGridViewRow row in dgvphones.Rows)
            {
                if (row.Cells[0].Value != null)
                {
                    cmd.CommandText = "insert into Phone_Customer values(" + txtCustNo.Text + ",'" + row.Cells[0].Value + "','" + row.Cells[1].Value + "')";
                    cmd.ExecuteNonQuery();
                }
            }

            conn.Close();
            MessageBox.Show(txtCustName.Text + "  Edited  Successfully", "Edite Customer Successfully");
            ClearData();


        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            cmd.Connection = conn;
            conn.Open();
            cmd.CommandText = "delete from Phone_Customer where CustNo =" + txtCustNo.Text;
            cmd.ExecuteNonQuery();
            cmd.CommandText = "delete from Customer where CustNo =" + txtCustNo.Text;
            cmd.ExecuteNonQuery();
            conn.Close();
            ClearData();
            MessageBox.Show(txtCustName.Text + "  Deleted  Successfully", "Delete Customer Successfully");
        }

        private void btnshowsearch_Click(object sender, EventArgs e)
        {
            string calname = "";
            if (rbtnCustNo.Checked == true)
                calname = "CustNO";
            else if (rbtnCustStartDate.Checked == true)
                calname = "StartDate";
            else if (rbtnCustEmail.Checked == true)
                calname = "Email";
            else if (rbtnCustName.Checked == true)
                calname = "CustName";
            else
                calname = "Address";

            FilltblCust("Select * from Customer where " + calname + " like'%" + txtsearch.Text + "%'");
            dgvsearch.DataSource = tblCust;

        }

        private void tbnSearch_Click(object sender, EventArgs e)
        {
           // pnlsearch.Location = new Point(15, 15);
            pnlsearch.Visible = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
          //  pnlsearch.Location = new Point(15, 15);
            pnlsearch.Visible = false;
        }

        private void btnshowsearch1_Click(object sender, EventArgs e)
        {
            string calname = "";
            if (rbtnCustNo.Checked == true)
                calname = "CustNO";
            else if (rbtnCustStartDate.Checked == true)
                calname = "StartDate";
            else if (rbtnCustEmail.Checked == true)
                calname = "Email";
            else if (rbtnCustName.Checked == true)
                calname = "CustName";
            else
                calname = "Address";

            FilltblCust("Select * from Customer where " + calname + " like'%" + txtsearch.Text + "%'");
            dgvsearch.DataSource = tblCust;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            frmHome fr = new frmHome();
            fr.MdiParent = this;
            fr.Show();
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtsearch_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                btnshowsearch_Click(null, null);
            }
        }

        private void GroupBox1_Enter(object sender, EventArgs e) {

        }
    }
}
