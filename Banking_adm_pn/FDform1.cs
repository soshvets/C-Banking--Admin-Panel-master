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
    public partial class FDform1 : Form
    {
        public FDform1()
        {
            InitializeComponent();
            loaddate();
            loadmode();
        }

        private void loadmode()
        {
            modetxt.Items.Add("Cash");
            modetxt.Items.Add("Chque");

        }

        private void loaddate()
        {
            datelbl.Text = DateTime.UtcNow.ToString("dd/MM/yyyy");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            banking_dbEntities dbe = new banking_dbEntities();
            decimal accno = Convert.ToDecimal(accnotxt.Text);
            var accounts = dbe.userAccount.Where(x => x.Account_No == accno).SingleOrDefault();
            FD fdform = new FD();
            fdform.Account_No = Convert.ToDecimal(accnotxt.Text);
            fdform.Mode = modetxt.SelectedItem.ToString();
            fdform.Rupees = rupeestxt.Text;
            fdform.Period = Convert.ToInt32(periodtxt.Text);
            fdform.Interest_rate = Convert.ToDecimal(interesttxt.Text);
            fdform.Start_Date = DateTime.UtcNow.ToString("dd/MM/yyyy");
            fdform.Maturity_Date = (DateTime.UtcNow.AddDays(Convert.ToInt32(periodtxt.Text))).ToString("dd/MM/yyyy");
            fdform.Maturity_Amount = ((Convert.ToDecimal(rupeestxt.Text) * Convert.ToInt32(periodtxt.Text) * Convert.ToDecimal(interesttxt.Text)) / (100 * 12 * 30))+(Convert.ToDecimal(rupeestxt.Text));
            dbe.FD.Add(fdform);
            decimal amount = Convert.ToDecimal(rupeestxt.Text);
            decimal totalamount = Convert.ToDecimal(accounts.balance);
            decimal fdamount = totalamount - amount;
            accounts.balance = fdamount;
            dbe.SaveChanges();
            MessageBox.Show("FD Started now");

        }
    }
}
