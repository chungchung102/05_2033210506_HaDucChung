using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05_2033210506_HaDucChung
{
    public partial class frmBaiTap1 : Form
    {
        ErrorProvider errorProvider1;
        public frmBaiTap1()
        {
            errorProvider1 = new ErrorProvider();
            InitializeComponent();
        }


        private void textBox1_TextChanged(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                e.Cancel = true;
                textBox1.Focus();
                errorProvider1.SetError(textBox1, "Vui lòng không được để trống giá trị a");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textBox1, null);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n=int.Parse(textBox1.Text);
            if (n < 2)
            {
                textBox2.Text="ko la so nguyen to";
            }
            int count = 0;
            for (int i = 2; i <= n/2; i++)
            {
                if (n % i == 0)
                {
                    count++;
                }
            }
            if (count == 0)
            {
                textBox2.Text = " la so nguyen to";
            }
            else
            {
                textBox2.Text = "ko la so nguyen to";
            }
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            string s = "cac so nguyen to tu 2 den ";
            int n=Convert.ToInt32(textBox3.Text.ToString());
            s = s + n.ToString() + "la";
            for(int i=0;i<n;i++)
            {
                int t = 0;
                if (n < 2)
                    t=0;

                else
                {
                    for (int j = 2; j <= n / 2; i++)
                    {
                        if (n % j == 0)
                            t=0;
                        t= 1;
                    }
                }
                if( t == 1)
                    s = s + " " + i.ToString();
            }
            textBox2.Text = s;
        }

        private void button3_Click(object sender, FormClosingEventArgs e)
        {
            DialogResult kq;
            kq = MessageBox.Show("Ban co muon thoatcua so khong", "Thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.No)
                e.Cancel = true;
        }

        
    }
}
