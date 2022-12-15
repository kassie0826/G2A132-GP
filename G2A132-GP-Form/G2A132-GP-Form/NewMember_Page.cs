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
    public partial class NewMember_Page : Form
    {
        public NewMember_Page()
        {
            InitializeComponent();
        }

        private void btnBackMainPage_Click(object sender, EventArgs e)
        {
            Program.mainFormContext.MainForm = new Main_Page();
            Program.mainFormContext.MainForm.Show();
            this.Close();
        }

        private void btnNextInfoInput_Click(object sender, EventArgs e)
        {

        }
    }
}
