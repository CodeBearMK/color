using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace color
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            hScrollBar1.Value = 128;
            hScrollBar2.Value = 128;
            hScrollBar3.Value = 128;
            vScrollBar1.Value = 255;
        }

        private void hScrollBar1_ValueChanged(object sender, EventArgs e)
        {
            label1.BackColor = Color.FromArgb(vScrollBar1.Value, hScrollBar1.Value,
                                              hScrollBar2.Value, hScrollBar3.Value);
            string val = hScrollBar1.Value.ToString();
            label2.Text = "紅=" + val;
        }

        private void hScrollBar2_ValueChanged(object sender, EventArgs e)
        {
            label1.BackColor = Color.FromArgb(vScrollBar1.Value, hScrollBar1.Value,
                                              hScrollBar2.Value, hScrollBar3.Value);
            string val = hScrollBar2.Value.ToString();
            label3.Text = "綠=" + val;
        }

        private void hScrollBar3_ValueChanged(object sender, EventArgs e)
        {
            label1.BackColor = Color.FromArgb(vScrollBar1.Value, hScrollBar1.Value,
                                              hScrollBar2.Value, hScrollBar3.Value);
            string val = hScrollBar3.Value.ToString();
            label4.Text = "藍=" + val;
        }

        private void vScrollBar1_ValueChanged(object sender, EventArgs e)
        {
            label1.BackColor = Color.FromArgb(vScrollBar1.Value, hScrollBar1.Value,
                                              hScrollBar2.Value, hScrollBar3.Value);
            string val = vScrollBar1.Value.ToString();
            label5.Text = "透明度=" + val;
        }
    }
}
