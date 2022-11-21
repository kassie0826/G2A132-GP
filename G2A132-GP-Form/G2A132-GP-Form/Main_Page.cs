using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace G2A132_GP_Form
{
    public partial class Main_Page : Form
    {
        public Main_Page()
        {
            InitializeComponent();
        }

        private void TopPage_Load(object sender, EventArgs e)
        {
            picTopPageIcon.Image = Properties.Resources.text_noclaim_noreturn;
            picTopPageIcon.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void picTopPageIcon_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
