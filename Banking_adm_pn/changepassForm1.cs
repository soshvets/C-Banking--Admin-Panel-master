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
    public partial class changepassForm1 : Form
    {
        public changepassForm1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            banking_dbEntities dbe = new banking_dbEntities();
            if (oldpasstxt.Text != string.Empty && newpasstxt.Text != string.Empty && retypepasstxt.Text != string.Empty)
            {
                Admin_Table user1 = dbe.Admin_Table.FirstOrDefault(a => a.Username.Equals(usernametxt.Text));
                if (user1 != null)
                {
                    if (user1.Password.Equals(oldpasstxt.Text))
                    {
                        if (newpasstxt.Text == retypepasstxt.Text)
                        {
                            user1.Password = newpasstxt.Text;
                            dbe.SaveChanges();
                            MessageBox.Show("Password Change Sucessfully");
                        }
                        else
                        {
                            MessageBox.Show("Retype password and password to change are not the same");
                        }
                        
                    }
                    else
                    {
                        MessageBox.Show("Password Incorrect");
                    }
                }
                else
                {
                    MessageBox.Show("Incorrect User Name");
                }
            }
            else
            {
                MessageBox.Show("Please write the all infarmation");
            }
        }

        private void changepassForm1_Load(object sender, EventArgs e)
        {

        }
    }
}
