using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace not_uygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int i = 0;
        int adet ,enbüyük=0,enküçük=100;
        
        int[] ogrenci;
        int a = 0;
        int b = 0;
        int c = 0;
        int d = 0;
        int f = 0;
        private void hesaplabtn_Click(object sender, EventArgs e)
        {
            int[] ogrenci = new int[adet + 1];
            if (i<adet+1)
            {
                ++i;
                ogrenci[i] = int.Parse(notgrsbox.Text);
            }
            
            foreach (int i in ogrenci)
            {
                if (i >= 85)
                {
                    a++;
                }
                else if (i >= 70)
                {
                    b++;
                }
                else if (i >= 55)
                {
                    c++;
                }
                else if (i >= 40)
                {
                    d++;
                }
                else if (i <= 39 && i>0)
                {
                    f++;
                }
            }
            if (int.Parse(notgrsbox.Text) < enküçük)
            {
                enküçük = int.Parse(notgrsbox.Text);

            }
            if (int.Parse(notgrsbox.Text) > enbüyük)
            {
                enbüyük= int.Parse(notgrsbox.Text);
            }
            bklbl.Text = $"En büyük not: {enbüyük} En küçük not: {enküçük}";
            if (i < adet )
                listelebtn.Enabled = false;
            else
                listelebtn.Enabled = true;
            
            notgrsbox.Clear();
            ogrenciadıBox1.Clear();
        }

        private void scmbox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (scmbox1.Text)
            {
                case "EVET":
                    bklbl.Visible = true;
                    break;
                case "HAYIR":
                    Environment.Exit(0);
                    break;


            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void notadettxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void notgrsbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void ogrenciadıBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);

        }

        private void notadettxt_TextChanged(object sender, EventArgs e)
        {
            if (notadettxt.Text.Length == 0 || notadettxt.Text.Length == 0)
                notadetbtn.Enabled = false;
            else
                notadetbtn.Enabled = true;

        }

        private void notgrsbox_TextChanged(object sender, EventArgs e)
        {
            if (notgrsbox.Text.Length == 0 || i > adet-1)
                noteklebtn.Enabled = false;
            else
                noteklebtn.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            adet = int.Parse(notadettxt.Text);

            int[] ogrenci = new int[adet+1];
            label3.Visible = false;
            notadettxt.Visible = false;
            notadetbtn.Visible = false;
            label2.Visible = true;
            yazi1lbl.Visible = true;
            ogrenciadıBox1.Visible = true;
            notgrsbox.Visible = true;
            noteklebtn.Visible = true;
            listelebtn.Visible = true;
            
        }

        private void listelebtn_Click(object sender, EventArgs e)
        {
            scmbox1.Visible = true;
            sonuclbl.Text = $"Sınıfta A alan {a} kişi, B alan {b} kişi, C alan {c} kişi, D alan {d} kişi, F alan {f} kişi, var.";
            buyukucuklbl.Text = $"En büyük ve en küçük notu görmek istermisin? ";

        }
    }
}
