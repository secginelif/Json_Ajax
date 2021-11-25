using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace timerapp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        int sayac = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(sayac==1000)
            {
                timer1.Stop();
            }
            
            progressBar1.Value = sayac;
            label1.Text = sayac.ToString();
            sayac++;


        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
