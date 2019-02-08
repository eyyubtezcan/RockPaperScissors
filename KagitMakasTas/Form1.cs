using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KagitMakasTas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int randomsayi;
        int userscore = 0;
        int pcscore = 0;
        string[] sonuc;
        Random rnd = new Random();
        private void Form1_Load(object sender, EventArgs e)
        {
           
            randomsayi = rnd.Next(0, 3);
            sonuc = new string[] { "Taş", "Kağıt", "Makas" };
            label5.Text = pcscore.ToString();
            label6.Text = userscore.ToString();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = sonuc[randomsayi];
            if(randomsayi==0)
            {
                MessageBox.Show("Kazandınız");
                userscore++;
            }
            else
            {
                MessageBox.Show("Kaybettiniz");
                pcscore++;
            }
            randomsayi = rnd.Next(0, 3);
            label5.Text = pcscore.ToString();
            label6.Text = userscore.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = sonuc[randomsayi];
            if (randomsayi == 1)
            {
                MessageBox.Show("Kazandınız");
                userscore++;
            }
            else
            {
                MessageBox.Show("Kaybettiniz");
                pcscore++;
            }
            randomsayi = rnd.Next(0, 3);
            label5.Text = pcscore.ToString();
            label6.Text = userscore.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = sonuc[randomsayi];
            if (randomsayi == 2)
            {
                MessageBox.Show("Kazandınız");
                userscore++;
            }
            else
            {
                MessageBox.Show("Kaybettiniz");
                pcscore++;
            }
            randomsayi = rnd.Next(0, 3);
            label5.Text = pcscore.ToString();
            label6.Text = userscore.ToString();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.K)
            {
                label1.Text = sonuc[randomsayi];
                if (randomsayi == 0)
                {
                    MessageBox.Show("Kazandınız");
                    userscore++;
                }
                else
                {
                    MessageBox.Show("Kaybettiniz");
                    pcscore++;
                }
                randomsayi = rnd.Next(0, 3);
                label5.Text = pcscore.ToString();
                label6.Text = userscore.ToString();
            }
            else if (e.KeyCode == Keys.M)
            {
                label1.Text = sonuc[randomsayi];
                if (randomsayi == 1)
                {
                    MessageBox.Show("Kazandınız");
                    userscore++;
                }
                else
                {
                    MessageBox.Show("Kaybettiniz");
                    pcscore++;
                }
                randomsayi = rnd.Next(0, 3);
                label5.Text = pcscore.ToString();
                label6.Text = userscore.ToString();
            }
            else if (e.KeyCode == Keys.T)
            {
                label1.Text = sonuc[randomsayi];
                if (randomsayi == 2)
                {
                    MessageBox.Show("Kazandınız");
                    userscore++;
                }
                else
                {
                    MessageBox.Show("Kaybettiniz");
                    pcscore++;
                }
                randomsayi = rnd.Next(0, 3);
                label5.Text = pcscore.ToString();
                label6.Text = userscore.ToString();
            }
        }

        
    }
}
