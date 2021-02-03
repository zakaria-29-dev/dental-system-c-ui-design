using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dental_sys
{
    public partial class Loading : Form
    {
        public Loading()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(guna2CircleProgressBar1.Value==100)
            {
                timer1.Stop();

                Principal p = new Principal();
                p.Show();
                this.Hide();

            }
            else
            { 
            guna2CircleProgressBar1.Value += 1;
            label_val.Text = (Convert.ToInt32(label_val.Text) + 1).ToString();
              }
        }

        private void Loading_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);
            timer1.Start();
        }
    }
}
