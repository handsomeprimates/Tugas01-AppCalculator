using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecndCalcu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHitung_Click(object sender, EventArgs e)
        {
            Double nilaiA, nilaiB, hasil; // 3 variabel

            if (NamaComboBox.SelectedIndex == 0)
            {
                nilaiA = Double.Parse(NamaText1.Text);
                nilaiB = Double.Parse(NamaText2.Text);
                hasil = nilaiA + nilaiB;
                txtHasil.Text = hasil.ToString();
            }
            else if (NamaComboBox.SelectedIndex == 1)
            {
                nilaiA = Double.Parse(NamaText1.Text);
                nilaiB = Double.Parse(NamaText2.Text);
                hasil = nilaiA - nilaiB;
                txtHasil.Text = hasil.ToString();
            }
            else if (NamaComboBox.SelectedIndex == 2)
            {
                nilaiA = Double.Parse(NamaText1.Text);
                nilaiB = Double.Parse(NamaText2.Text);
                hasil = nilaiA * nilaiB;
                txtHasil.Text = hasil.ToString();
            }
            else if (NamaComboBox.SelectedIndex == 3)
            {
                nilaiA = Double.Parse(NamaText1.Text);
                nilaiB = Double.Parse(NamaText2.Text);
                hasil = nilaiA / nilaiB;
                txtHasil.Text = hasil.ToString();
            }
        }
    }
}
