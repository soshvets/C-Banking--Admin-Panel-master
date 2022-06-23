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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void withToolStripMenuItem_Click(object sender, EventArgs e)
        {
            withdrawlForm widthdrawl = new withdrawlForm();
            widthdrawl.MdiParent = this;
            widthdrawl.Show();
        }

        private void newAccountToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            newAccount newacc = new newAccount();
            newacc.MdiParent = this;
            newacc.Show();
        }

        private void updateSearchAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdationForm up = new UpdationForm();
            up.MdiParent = this;
            up.Show();
        }

        private void allToolStripMenuItem_Click(object sender, EventArgs e)
        {
            allcustomers allcust = new allcustomers();
            allcust.MdiParent = this;
            allcust.Show();
        }

        private void depositToolStripMenuItem_Click(object sender, EventArgs e)
        {
            depositForm depositfrm = new depositForm();
            depositfrm.MdiParent = this;
            depositfrm.Show();
        }

        private void transferToolStripMenuItem_Click(object sender, EventArgs e)
        {
            transferForm transForm = new transferForm();
            transForm.MdiParent = this;
            transForm.Show();
        }

        private void fDFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FDform1 fdform = new FDform1();
            fdform.MdiParent = this;
            fdform.Show();
        }

        private void balanceSheetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            balanceform1 blc = new balanceform1();
            blc.MdiParent = this;
            blc.Show();
        }

        private void viewFDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewFDform1 viewFD = new viewFDform1();
            viewFD.MdiParent = this;
            viewFD.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changepassForm1 changepass = new changepassForm1();
            changepass.MdiParent = this;
            changepass.Show();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
