using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crazy8
{
    public partial class Form1 : Form
    {
        private bool currentFlash;
        public Form1()
        {
            InitializeComponent();
            currentFlash = false;
            timer1.Start();
        }

        private void qBTN_MouseEnter(object sender, EventArgs e)
        {
            qBTN.BackColor = Color.Gold;
        }

        private void qBTN_MouseLeave(object sender, EventArgs e)
        {
            qBTN.BackColor = SystemColors.MenuBar;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            flashALBL = !flashALBL;
        }

        private bool flashALBL
        {
            set
            {
                if(value)
                {
                    aLBL.BackColor = Color.Yellow;
                    aLBL.ForeColor = Color.Red;
                }else
                {
                    aLBL.BackColor = SystemColors.Control;
                    aLBL.ForeColor = Color.Black;
                }
                currentFlash = value;
            }

            get
            {
                return currentFlash;
            }
        }
    }
}
