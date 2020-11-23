using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TakeYourHeight
{
    public partial class TakeYourHeight : Form
    {
        public TakeYourHeight()
        {
            InitializeComponent();
        }

        private void btn_calc_Click(object sender, EventArgs e)
        {
            MessageBox.Show("你的身高是"+this.text_height.Text+"cm","身高");
        }
    }
}
