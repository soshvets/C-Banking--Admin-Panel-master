using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banking_adm_pn
{
    public partial class newAccount : Form
    {
        string gender = string.Empty;
        string m_status = string.Empty;
        decimal no;
        banking_dbEntities BSE;
        MemoryStream ms;

        public newAccount()
        {
            InitializeComponent();
            loaddate();
            loadaccount();
            loadstate();
        }

        private void loadstate()
        {
            comboBox1.Items.Add("Kiev");
            comboBox1.Items.Add("Tokyo");
            comboBox1.Items.Add("Delhi");
            comboBox1.Items.Add("Shanghai");
            comboBox1.Items.Add("Sao Paulo");
            comboBox1.Items.Add("Mexico City");
            comboBox1.Items.Add("Cairo");
            comboBox1.Items.Add("Dhaka");
            comboBox1.Items.Add("Mumbai");
            comboBox1.Items.Add("Beijing");
            comboBox1.Items.Add("Osaka");
            comboBox1.Items.Add("Karachi");
            comboBox1.Items.Add("Chongqing");
            comboBox1.Items.Add("Buenos Aires");
            comboBox1.Items.Add("Istanbul");
            comboBox1.Items.Add("Kolkata");
            comboBox1.Items.Add("Lagos");
            comboBox1.Items.Add("Manila");
            comboBox1.Items.Add("Tianjin");
            comboBox1.Items.Add("Rio De Janeiro");
            comboBox1.Items.Add("Guangzhou");
            comboBox1.Items.Add("Moscow");
            comboBox1.Items.Add("Lahore");
            comboBox1.Items.Add("Shenzhen");
            comboBox1.Items.Add("Bangalore");
            comboBox1.Items.Add("Paris");
            comboBox1.Items.Add("Bogota");
            comboBox1.Items.Add("Chennai");
            comboBox1.Items.Add("Jakarta");
            comboBox1.Items.Add("Lima");
            comboBox1.Items.Add("Bangkok");
            comboBox1.Items.Add("Seoul");
            comboBox1.Items.Add("Hyderabad");
            comboBox1.Items.Add("London");
            comboBox1.Items.Add("Tehran");
            comboBox1.Items.Add("New York");
            comboBox1.Items.Add("Madrid");
            comboBox1.Items.Add("Alexandria");
        }

        private void loadaccount()
        {
            BSE = new banking_dbEntities();
            var item = BSE.userAccount.ToArray();
            no = item.LastOrDefault().Account_No + 1;
            textBox1.Text = Convert.ToString(no);
        }

        private void loaddate()
        {
            //  throw new NotImplementedException();
            datalbl.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void newAccount_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog opendlg = new OpenFileDialog();
            if (opendlg.ShowDialog()==DialogResult.OK)
            {
                Image img = Image.FromFile(opendlg.FileName);
                pictureBox1.Image = img;
                ms = new MemoryStream();
                img.Save(ms, img.RawFormat);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (maleradio.Checked)
            {
                gender = "male";
            }
            else if (femaleradio.Checked)
            {
                gender = "female";
            }
            else if (otherradio.Checked)
            {
                gender = "other";
            }
            if (marriedradio.Checked)
            {
                m_status = "married";
            }
            else if (unmarriedradio.Checked)
            {
                m_status = "unmarried";
            }
            BSE = new banking_dbEntities();
            userAccount acc = new userAccount();
            acc.Account_No = Convert.ToDecimal(textBox1.Text);
            acc.Name = nametxt.Text;
            acc.DOB = dateTimePicker1.Value.ToString();

            try
            {
                int temp;
                bool isnum = int.TryParse(phonetxt.Text, out temp);
                if (isnum)
                {
                    acc.PhoneNo = phonetxt.Text;
                }
                else
                {
                    throw new NullReferenceException();
                } 
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Please correct <phonebox> type to number instead of laters  " );
                acc.PhoneNo = null;
            }



            acc.Address = addtxt.Text;
            acc.District = disttxt.Text;
            acc.State = comboBox1.SelectedItem.ToString();
            acc.Gender = gender;
            acc.maritial_status = m_status;
            acc.Mother_Name = mothertxt.Text;
            acc.Father_Name = fathertxt.Text;

            try
            {
                int temp1;
                bool isnum1 = int.TryParse(blctxt.Text, out temp1);
                if (isnum1)
                {
                    acc.balance = Convert.ToDecimal(blctxt.Text);
                }
                else
                {
                    throw new NullReferenceException();
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Please  correct < balancebox > type to number instead of laters");
                acc.balance = null;
            }
            
            acc.Date = datalbl.Text;

            try
            {
                acc.Picture = ms.ToArray();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("The PictureBox was null");
                OpenFileDialog opendlg = new OpenFileDialog();
                if (opendlg.ShowDialog() == DialogResult.OK)
                {
                    Image img = Image.FromFile(opendlg.FileName);
                    pictureBox1.Image = img;
                    ms = new MemoryStream();
                    img.Save(ms, img.RawFormat);
                }
                acc.Picture = ms.ToArray();
            }

            if (acc.balance!=null && acc.PhoneNo !=null)
            {
                BSE.userAccount.Add(acc);
                BSE.SaveChanges();
                MessageBox.Show("file saved");
            }
            else
            {
                MessageBox.Show("Correct Forms");
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
