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
    public partial class viewFDform1 : Form
    {
        BindingList<FD> bl;
        banking_dbEntities dbe;
        public viewFDform1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bl = new BindingList<FD>();
            dbe = new banking_dbEntities();
            string date = dateTimePicker1.Value.ToString("dd/MM/yyyy");
            MessageBox.Show(date);
            var item = dbe.FD.Where(a => a.Start_Date.Equals(date));
            dataGridView1.DataSource = item.ToList();
        }
    }
}
