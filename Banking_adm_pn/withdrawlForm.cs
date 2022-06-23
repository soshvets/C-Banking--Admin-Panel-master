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
    public partial class withdrawlForm : Form
    {
        public withdrawlForm()
        {
            InitializeComponent();
            loadcombo();
            loaddate();
        }

        private void loadcombo()
        {
            modetxt.Items.Add("Cash");
            modetxt.Items.Add("Chque");
        }

        private void loaddate()
        {
            datelbl.Text = DateTime.UtcNow.ToString("dd/MM/yyyy");
        }

        private void detailsbutton_Click(object sender, EventArgs e)
        {
            
            retrievedata();
        }

        private void retrievedata()
        {
            banking_dbEntities dbe = new banking_dbEntities();
            decimal b = Convert.ToDecimal(accnotxt.Text);
            var item = (from u in dbe.userAccount where u.Account_No == b select u).FirstOrDefault();
            nametxt.Text = item.Name;
            olobalancetxt.Text = Convert.ToString(item.balance);
        }

        private void savebutton_Click(object sender, EventArgs e)
        {

            savedata();
        }

        private void savedata()
        {
            banking_dbEntities dbe = new banking_dbEntities();
            newAccount nacc = new newAccount();
            debit dp = new debit();
            dp.Date = datelbl.Text;
            dp.AccountNo = Convert.ToDecimal(accnotxt.Text);
            dp.Name = nametxt.Text;
            dp.OldBalance = Convert.ToDecimal(olobalancetxt.Text);
            dp.Mode = modetxt.SelectedItem.ToString();
            dp.DebAmount = Convert.ToDecimal(amounttxt.Text);
            dbe.debit.Add(dp);
            dbe.SaveChanges();
            decimal b = Convert.ToDecimal(accnotxt.Text);
            var item = (from u in dbe.userAccount where u.Account_No == b select u).FirstOrDefault();
            item.balance = item.balance - Convert.ToDecimal(amounttxt.Text);
            dbe.SaveChanges();
            MessageBox.Show("Debit Money");
        }
    }
}
