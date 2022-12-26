using P9_1_1214056.controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P9_1_1214056.view
{
    public partial class FstartUp : Form
    {
        public FstartUp()
        {
            InitializeComponent();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Login frm = new Login();
            progressBar1.Value += 5;
            if(progressBar1.Value == 100)
            {
                Timer.Dispose();
                Hide();
                frm.Show();
            }
        }
    }
}
