using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pansiyon_Kayit_Otomasyonu
{
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox3.Text = textBox3.Text.Substring(1) + textBox3.Text.Substring(0, 1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text=="admin" && textBox2.Text == "12345")
            {
                FrmMusteriKayit kayitform = new FrmMusteriKayit();
                kayitform.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı Adı Yada Şifre");
                textBox1.Clear();
                textBox2.Clear();
            }
        }
    }
}
