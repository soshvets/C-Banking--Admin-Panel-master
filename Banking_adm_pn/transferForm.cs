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
    public partial class transferForm : Form
    {
        public transferForm()
        {
            InitializeComponent();
            loaddate();
        }

        private void loaddate()
        {
            datalbl.Text = DateTime.UtcNow.ToString("dd/MM/yyyy");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            banking_dbEntities dbe = new banking_dbEntities();
            decimal b = Convert.ToDecimal(fromacctxt.Text);
            var item = (from u in dbe.userAccount where u.Account_No == b select u).FirstOrDefault();
            nametxt.Text = item.Name;
            curammtxt.Text = Convert.ToString(item.balance);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            banking_dbEntities dbe = new banking_dbEntities();
            decimal b = Convert.ToDecimal(fromacctxt.Text);
            var item = (from u in dbe.userAccount where u.Account_No == b select u).FirstOrDefault();
            decimal b1 = Convert.ToDecimal(item.balance);
            decimal totalbalance = Convert.ToDecimal(amounttxt.Text);
            decimal transferacc = Convert.ToDecimal(destinationacctxt.Text);
            if (b1>totalbalance)
            {
                userAccount item2 = (from u in dbe.userAccount where u.Account_No == transferacc select u).FirstOrDefault();
                item2.balance = item2.balance + totalbalance;
                item.balance = item.balance - totalbalance;
                Transfer transfer = new Transfer();
                transfer.Account_No = Convert.ToDecimal(fromacctxt.Text);
                transfer.ToTransfer = Convert.ToDecimal(destinationacctxt.Text);
                transfer.Date = DateTime.UtcNow.ToString("dd/MM/yyyy");
                transfer.Name = nametxt.Text;
                transfer.balance = Convert.ToDecimal(amounttxt.Text);

                dbe.Transfer.Add(transfer);
                dbe.SaveChanges();
                MessageBox.Show("Transfer Money Sucessfully");

            }
            else
            {
                MessageBox.Show("Not enough money");
            }
        }
    }
}
