﻿using System;
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

        private void MainPage_Load(object sender, EventArgs e)
        {
            this.Size = new Size(820, 500);
            this.MaximizeBox = false;
            picTopPageIcon.Image = Properties.Resources.text_noclaim_noreturn;
            picTopPageIcon.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void btnChengeDB_Click(object sender, EventArgs e)
        {
            DBProduction dBProduction = new DBProduction();
            dBProduction.Show();
        }

        private void btnChangeNewMember_Click(object sender, EventArgs e)
        {
            NewMember_Page newMember_Page = new NewMember_Page();
            newMember_Page.Show();
        }
    }
}