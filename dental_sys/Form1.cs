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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Loading _load = new Loading();
            _load.Show();
        }
    }
}
