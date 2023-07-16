using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hypixel_Skyblock_Fishing_Timer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            Timer t = new Timer();
            t.Interval = 270000;
            timer1.Enabled = true;
            timer1.Tick += new System.EventHandler(button1_Click);

            timer1.Stop();
            MessageBox.Show("TIMER IS UP. KILL YOUR SEA CREATURES!!!");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Interval = 270000;
            timer1.Enabled = false;
        }
    }    
}
