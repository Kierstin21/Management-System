using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Management_System.AllUserControl
{
    public partial class UC_Welcome : UserControl
    {
        public UC_Welcome()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        int num = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(num == 0)
            {
                labelBanner.Location = new Point(1, 367);
                labelBanner.ForeColor = Color.Red;
                num++;
            }
            else if(num == 1)
            {
                labelBanner.Location = new Point(100, 367);
                labelBanner.ForeColor = Color.Gray;
                num++;
            }
            else if (num == 2)
            {
                labelBanner.Location = new Point(200, 367);
                labelBanner.ForeColor = Color.Lavender;
                num = 0;
            }
        }

        private void UC_Welcome_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
