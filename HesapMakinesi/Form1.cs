using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesapMakinesi
{
    public partial class HesapMakinesi : Form
    {
        private char _islem;
        private bool _EkranTemizlenecekMi;
        private int  _ilkSayi;


        public HesapMakinesi()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_EkranTemizlenecekMi)
            {
                EkranLabel1.Text = "";
                _EkranTemizlenecekMi = false;
            }
               


            if (EkranLabel1.Text == "0") EkranLabel1.Text = "";
            EkranLabel1.Text += "1";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            EkranLabel1.Text = "0";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            _islem = '+';
            _EkranTemizlenecekMi = true;
            _ilkSayi = Convert.ToInt32(EkranLabel1.Text);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            _islem = 'x';
            _EkranTemizlenecekMi = true;
            _ilkSayi = Convert.ToInt32(EkranLabel1.Text);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            _islem = '-';
            _EkranTemizlenecekMi = true;
            _ilkSayi = Convert.ToInt32(EkranLabel1.Text);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            _islem = '/';
            _EkranTemizlenecekMi = true;
            _ilkSayi = Convert.ToInt32(EkranLabel1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (_EkranTemizlenecekMi)
            {
                EkranLabel1.Text = "";
                _EkranTemizlenecekMi = false;
            }
            if (EkranLabel1.Text == "0") EkranLabel1.Text = "";
            EkranLabel1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (_EkranTemizlenecekMi)
            {
                EkranLabel1.Text = "";
                _EkranTemizlenecekMi = false;
            }
            if (EkranLabel1.Text == "0") EkranLabel1.Text = "";
            EkranLabel1.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (_EkranTemizlenecekMi)
            {
                EkranLabel1.Text = "";
                _EkranTemizlenecekMi = false;
            }
            if (EkranLabel1.Text == "0") EkranLabel1.Text = "";
            EkranLabel1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (_EkranTemizlenecekMi)
            {
                EkranLabel1.Text = "";
                _EkranTemizlenecekMi = false;
            }
            if (EkranLabel1.Text == "0") EkranLabel1.Text = "";
            EkranLabel1.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (_EkranTemizlenecekMi)
            {
                EkranLabel1.Text = "";
                _EkranTemizlenecekMi = false;
            }
            if (EkranLabel1.Text == "0") EkranLabel1.Text = "";
            EkranLabel1.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (_EkranTemizlenecekMi)
            {
                EkranLabel1.Text = "";
                _EkranTemizlenecekMi = false;
            }
            if (EkranLabel1.Text == "0") EkranLabel1.Text = "";
            EkranLabel1.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (_EkranTemizlenecekMi)
            {
                EkranLabel1.Text = "";
                _EkranTemizlenecekMi = false;
            }
            if (EkranLabel1.Text == "0") EkranLabel1.Text = "";
            EkranLabel1.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (_EkranTemizlenecekMi)
            {
                EkranLabel1.Text = "";
                _EkranTemizlenecekMi = false;
            }
            if (EkranLabel1.Text == "0") EkranLabel1.Text = "";
            EkranLabel1.Text += "9";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (_EkranTemizlenecekMi) EkranLabel1.Text = "";
            if (EkranLabel1.Text == "0") EkranLabel1.Text = "";
            EkranLabel1.Text += "0";
        }

        private void buttonEsit_Click(object sender, EventArgs e)
        {
            int _ikinciSayi = Convert.ToInt32(EkranLabel1.Text);
            int sonuc;

            switch (_islem) 
            {
                case '+':
                    sonuc = _ilkSayi + _ikinciSayi;
                break;

                case '-':
                    sonuc = _ilkSayi - _ikinciSayi;
                break;

                case 'x':
                    sonuc = _ilkSayi * _ikinciSayi;
                break;

                case '/':
                    sonuc = _ilkSayi / _ikinciSayi;
                break;

                default: sonuc = 0; break;
            }
            EkranLabel1.Text = Convert.ToString(sonuc);
        }
    }
}
