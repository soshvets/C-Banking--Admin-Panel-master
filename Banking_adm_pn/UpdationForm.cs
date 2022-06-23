using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banking_adm_pn
{
    public partial class UpdationForm : Form
    {

        banking_dbEntities dbe;
        MemoryStream ms;
        BindingList<userAccount> bi;
        public UpdationForm()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void UpdationForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bi = new BindingList<userAccount>();
            dbe = new banking_dbEntities();
            decimal accno = Convert.ToDecimal(acctxt.Text);
            var item = dbe.userAccount.Where(a => a.Account_No == accno);
            foreach (var item1 in item)
            {
                bi.Add(item1);
            }
            dataGridView1.DataSource = bi;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bi = new BindingList<userAccount>();
            dbe = new banking_dbEntities();
            var item = dbe.userAccount.Where(a => a.Name == nametxt.Text);
            foreach(var item1 in item)
            {
                bi.Add(item1);
            }
            dataGridView1.DataSource = bi;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dbe = new banking_dbEntities();
            decimal accno = Convert.ToDecimal(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            var item = dbe.userAccount.Where(a => a.Account_No == accno).FirstOrDefault();
            acctxt.Text = item.Account_No.ToString();
            nametxt.Text = item.Name;
            mothertxt.Text = item.Mother_Name;
            fathertxt.Text = item.Father_Name;
            phonetxt.Text = item.PhoneNo;
            addtxt.Text = item.Address;
            byte[] img = item.Picture;
            MemoryStream ms = new MemoryStream(img);
            pictureBox1.Image = Image.FromStream(ms);
            distxt.Text = item.District;
            statetxt.Text = item.State;
            if (item.Gender=="male")
            {
                maleradio.Checked = true;
            }
            else if (item.Gender=="female")
            {
                femaleradio.Checked = true;
            }
            else if (item.Gender=="other")
            {
                otherradio.Checked = true;
            }
            if (item.maritial_status=="married")
            {
                marriedradio.Checked = true;
            }
            else if (item.maritial_status=="unmarried")
            {
                unmarriedradio.Checked = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenFileDialog opendlg = new OpenFileDialog();
            if (opendlg.ShowDialog()== DialogResult.OK)
            {
                Image img = Image.FromFile(opendlg.FileName);
                pictureBox1.Image = img;
                ms = new MemoryStream();
                img.Save(ms, img.RawFormat);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bi.RemoveAt(dataGridView1.CurrentCell.RowIndex);
            dbe = new banking_dbEntities();
            decimal a = Convert.ToDecimal(acctxt.Text);
            userAccount acc = dbe.userAccount.First(s => s.Account_No.Equals(a));
            dbe.userAccount.Remove(acc);
            dbe.SaveChanges();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dbe = new banking_dbEntities();
            decimal accountno = Convert.ToDecimal(acctxt.Text);
            userAccount useraccount = dbe.userAccount.First(s => s.Account_No.Equals(accountno));
            useraccount.Account_No = Convert.ToDecimal(acctxt.Text);
            useraccount.Name = nametxt.Text;
            useraccount.Date = dateTimePicker1.Value.ToString();
            useraccount.Mother_Name = mothertxt.Text;
            useraccount.Father_Name = fathertxt.Text;
            useraccount.PhoneNo = phonetxt.Text;
            if (maleradio.Checked==true)
            {
                useraccount.Gender = "male";
            }
            else
            {
                if (femaleradio.Checked)
                {
                    useraccount.Gender = "female";
                }
            }
            if (marriedradio.Checked==true)
            {
                useraccount.maritial_status = "married";
            }
            else
            {
                if (unmarriedradio.Checked==true)
                {
                    useraccount.maritial_status = "Un-married";
                }
            }
            Image img = pictureBox1.Image;
            if (img.RawFormat!=null)
            {
                if (ms!=null)
                {
                    img.Save(ms, img.RawFormat);
                    useraccount.Picture = ms.ToArray();

                }
            }
            useraccount.Address = addtxt.Text;
            useraccount.District = distxt.Text;
            useraccount.State = statetxt.Text;
            dbe.SaveChanges();
            MessageBox.Show("Record Updated");
        }
    }
}
