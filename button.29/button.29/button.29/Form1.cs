using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace button._29
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int aylar=comboBox1.SelectedIndex;
            aylar++;
            if(aylar==1 || aylar==2 || aylar == 12)
            {
                label1.Text = "KIŞ MEVSİMİ";
            }
            else if (aylar==3 || aylar==4 || aylar == 5)
            {
                label1.Text = "İLKBAHAR MEVSİMİ";
            }
            else if (aylar==6 || aylar==7 || aylar == 8)
            {
                label1.Text = "YAZ MEVSİMİ";
            }
            else
            {
                label1.Text = "SONBAHAR MEVSİMİ";
            }

        }
    }
}
