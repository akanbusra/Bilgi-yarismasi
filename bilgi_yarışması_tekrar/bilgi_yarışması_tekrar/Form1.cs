using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bilgi_yarışması_tekrar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        int sorusayısı, doğru, yanlış;

        private void btnB_Click(object sender, EventArgs e)
        {
            btnsonraki.Enabled = true;
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;

            label8.Text = btnB.Text;
            if (label7.Text == label8.Text)
            {
                doğru++;
                lbldoğru.Text = doğru.ToString();
                pictureBox1.Visible = true;
                pictureBox2.Visible = false;
            }
            else
            {
                yanlış++;
                lblyanlış.Text = yanlış.ToString();
                pictureBox2.Visible = true;
                pictureBox1.Visible = false;
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            btnsonraki.Enabled = true;
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;

            label8.Text = btnC.Text;
            if (label7.Text == label8.Text)
            {
                doğru++;
                lbldoğru.Text = doğru.ToString();
                pictureBox1.Visible = true;
                pictureBox2.Visible = false;
            }
            else
            {
                yanlış++;
                lblyanlış.Text = yanlış.ToString();
                pictureBox2.Visible = true;
                pictureBox1.Visible = false;
            }
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            btnsonraki.Enabled = true;
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;

            label8.Text = btnD.Text;
            if (label7.Text == label8.Text)
            {
                doğru++;
                lbldoğru.Text = doğru.ToString();
                pictureBox1.Visible = true;
                pictureBox2.Visible = false;
            }
            else
            {
                yanlış++;
                lblyanlış.Text = yanlış.ToString();
                pictureBox2.Visible = true;
                pictureBox1.Visible = false;
            }
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            btnsonraki.Enabled = true;
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;

            label8.Text = btnA.Text;
            if (label7.Text==label8.Text)
            {
                doğru++;
                lbldoğru.Text = doğru.ToString();
                pictureBox1.Visible = true;
                pictureBox2.Visible = false;
            }
            else
            {
                yanlış++;
                lblyanlış.Text = yanlış.ToString();
                pictureBox2.Visible = true;
                pictureBox1.Visible = false;
            }
        }

        private void btnsonraki_Click(object sender, EventArgs e)
        {
            btnsonraki.Enabled = false;
            btnA.Enabled = true;
            btnB.Enabled = true;
            btnC.Enabled = true;
            btnD.Enabled = true;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;

            sorusayısı++;
            lblsorusayısı.Text = sorusayısı.ToString();

            if (sorusayısı==1)
            {
                richTextBox1.Text = "Aşağıdakilerden hangisi bir mevsim değildir?";
                btnA.Text = "İlkbahar";
                btnB.Text = "Yaz";
                btnC.Text = "Sonbahar";
                btnD.Text = "Nisan";
                label7.Text = "Nisan";   
            }
            if (sorusayısı==2)
            {
                richTextBox1.Text = "34 plakası hangi ilimize aittir? ";
                btnA.Text = "İstanbul";
                btnB.Text = "Ankara";
                btnC.Text = "Malatya";
                btnD.Text = "Edirne";
                label7.Text = "İstanbul";
            }
            if (sorusayısı==3)
            {
                richTextBox1.Text = "Aşağıdakilerden hangisi h2o formülünün sahibidir?";
                btnA.Text = "Meyve suyu";
                btnB.Text = "Su";
                btnC.Text = "Süt";
                btnD.Text = "Yumurta";
                label7.Text = "Su";
            }
            if (sorusayısı == 4)
            {
                richTextBox1.Text = "Aşağıdakilerden hangisi 4.aydır?";
                btnA.Text = "Ocak";
                btnB.Text = "Şubat";
                btnC.Text = "Nisan";
                btnD.Text = "Aralık";
                label7.Text = "Nisan";
                btnsonraki.Text = "SONUÇLAR";
                
            }
            if (sorusayısı==5)
            {
                btnsonraki.Enabled = false;
                btnA.Enabled = false;
                btnB.Enabled = false;
                btnC.Enabled = false;
                btnD.Enabled = false;
                MessageBox.Show("doğru sayısı: " + doğru + "\n" + "yanlış sayısı:" + yanlış);
            }

        }
    }
}
