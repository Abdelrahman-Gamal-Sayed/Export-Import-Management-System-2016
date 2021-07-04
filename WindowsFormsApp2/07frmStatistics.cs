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
    public partial class frmStatistics : Form
    {
        public frmStatistics()
        {
            InitializeComponent();
        }
        DB db = new DB();
        private void ShowStat(string SelectStatment , string txtForm)
        {
            Form frm = new Form();
            Font f = new Font("tahome", 14);
            DataGridView dgv = new DataGridView();
            frm.Font = f;
            dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgv.Dock = DockStyle.Fill;
            dgv.ColumnHeadersHeight = 70;
            dgv.ReadOnly = true;
            dgv.DataSource = db.RunReader(SelectStatment);
            frm.Controls.Add(dgv);
            //frm.WindowState = FormWindowState.Maximized;
            frm.Text = "Statistecs About " + txtForm;
            frm.ShowDialog();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ShowStat("select count(CustNO) 'Number Of Customers'  from Customer", button1.Text);
       
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ShowStat("select CustName 'Customer' from Customer where startdate=(select min(StartDate) from Customer)", button2.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {

            ShowStat("select CustName 'Customer_Name' ,Buying.CustNO 'Customer Number' , count(Buying.CustNO) 'Number_of_Buying' from Buying, Customer where Customer.CustNO=Buying.CustNO group by Buying.CustNO , CustName", button3.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ShowStat("select CustName 'Customer_Name' ,Selling.CustNO 'Customer Number' , count(Selling.CustNO) 'Number_of_Sale' from Selling, Customer where Customer.CustNO=Selling.CustNO group by Selling.CustNO , CustName", button4.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ShowStat("select ItemName 'Item',Buying.ItemNO 'Num_of_Item',count(Buying.ItemNO)  'Number_of_Buy' from Buying , Item where Buying.ItemNO =Item.ItemNO group by Buying.ItemNO,ItemName", button6.Text);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ShowStat("select ItemName 'Item',Selling.ItemNO 'Num_of_Item',count(Selling.ItemNO)  'Number_of_Sale' from Selling , Item where Selling.ItemNO =Item.ItemNO group by Selling.ItemNO,ItemName", button7.Text);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            ShowStat("select sum(Price * QTY) 'Total_Buying' from Buying", button10.Text);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            ShowStat("select sum(Price * QTY) 'Total_Buying' from Buying", button10.Text);
        }
    }
}
