using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace PsychHRV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTick dt = new DataTick("D:\\HRV1.dat", 10);
            TUIBV1 behavior = new TUIBV1(this);
            dt.mBehaviorInst = behavior;
            dt.Start();
        }
    }
}
