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
    public partial class allcustomers : Form
    {
        public allcustomers()
        {
            InitializeComponent();
            bindgrid();
        }

        private void bindgrid()
        {
            dataGridView1.AutoGenerateColumns = false;
            banking_dbEntities bs = new banking_dbEntities();
            var item = bs.userAccount.ToList();
            dataGridView1.DataSource = item;
        }

        private void allcustomers_Load(object sender, EventArgs e)
        {
            

        }
    }
}
