using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banking_adm_pn
{
    public partial class balanceform1 : Form
    {
        public balanceform1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            banking_dbEntities dbe = new banking_dbEntities();
            decimal b = Convert.ToDecimal(textBox1.Text);
            var item = (from u in dbe.debit where u.AccountNo == b select u);
            dataGridView1.DataSource = item.ToList();
            var item1 = (from u in dbe.Deposit where u.AccountNo == b select u);
            dataGridView2.DataSource = item1.ToList();
            var item2 = (from u in dbe.Transfer where u.Account_No == b select u);
            dataGridView3.DataSource = item2.ToList();
        }
    }
}
