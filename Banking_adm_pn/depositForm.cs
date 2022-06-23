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
    public partial class depositForm : Form
    {
        public depositForm()
        {
            InitializeComponent();
            loaddate();
            loadmode();
        }

        private void loadmode()
        {
            comboBox1.Items.Add("Cash");
            comboBox1.Items.Add("Chque");
        }

        private void loaddate()
        {
            datelbl.Text = DateTime.UtcNow.ToString("dd/MM/yyyy");
        }

        private void detailsbutton_Click(object sender, EventArgs e)
        {
            banking_dbEntities context = new banking_dbEntities();
            newAccount acc = new newAccount();
            Deposit dp = new Deposit();
            dp.Date = datelbl.Text;
            dp.AccountNo = Convert.ToDecimal(acctxt.Text);
            dp.Name = nametxt.Text;
            dp.OldBalance = Convert.ToDecimal(balancetxt.Text);
            dp.Mode = comboBox1.SelectedItem.ToString();
            dp.DipAmount = Convert.ToDecimal(depamounttxt.Text);
            context.Deposit.Add(dp);
            context.SaveChanges();
            decimal b = Convert.ToDecimal(acctxt.Text);
            var item = (from u in context.userAccount where u.Account_No == b select u).FirstOrDefault();
            item.balance = item.balance + Convert.ToDecimal(depamounttxt.Text);
            context.SaveChanges();
            MessageBox.Show("Deposit Money Sucessfully");



        }

        private void button1_Click(object sender, EventArgs e)
        {
            banking_dbEntities context = new banking_dbEntities();
            decimal b = Convert.ToDecimal(acctxt.Text);
            var item = (from u in context.userAccount where u.Account_No == b select u).FirstOrDefault();
            nametxt.Text = item.Name;
            balancetxt.Text = Convert.ToString(item.balance);
        }
    }
}
