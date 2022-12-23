using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace G2A132GameProgramForm
{
    public partial class Main_Page : Form
    {
        public Main_Page()
        {
            InitializeComponent();
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            this.Size = new Size(820, 500);
            this.MaximizeBox = false;
            picTopPageIcon.Image = Properties.Resources.text_noclaim_noreturn;
            picTopPageIcon.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void btnChengeDB_Click(object sender, EventArgs e)
        {
            
        }

        private void btnChangeNewMember_Click(object sender, EventArgs e)
        {
            Program.mainFormContext.MainForm = new NewMember_Page();
            Program.mainFormContext.MainForm.Show();
            this.Close();
        }
    }
}