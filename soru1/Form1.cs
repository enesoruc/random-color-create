using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace soru1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int renkValue = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            KnownColor[] tipler = (KnownColor[])Enum.GetValues(typeof(KnownColor));
            try
            {
                KnownColor c = (KnownColor)Enum.Parse(typeof(KnownColor), tipler[this.renkValue].ToString());
                label1.Text = tipler[this.renkValue].ToString();
                label1.ForeColor = Color.FromKnownColor(c);
                this.renkValue++;
            }
            catch
            {
                renkValue = 0;
            }
        }
    }
}
