using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TV_Application
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void Form1_Load(object sender, EventArgs e)
        {
            rbBeyazTV.Checked = true;
            
        }
        public void pBarFonk()
        {
            for (int i = 0; i < 101; i++)
            {
                pBar.Value = i;

            }
        }

        private void rbBeyazTV_CheckedChanged(object sender, EventArgs e)
        {
            
        }
     

        private void rbBeyazTV_Click(object sender, EventArgs e)
        {
            pBar.Value = 0;
            tv.URL = ("http://37.77.31.3:1935/liveedge/_definst_/BEYAZTVHQ/playlist.m3u8");
            pBarFonk();
        }

        
    }
}
