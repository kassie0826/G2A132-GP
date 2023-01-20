﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace G2A132GameProgramForm
{
    public partial class Main_Page : Form
    {
        public Main_Page()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            //this.Size = new Size(820, 500);
            this.MaximizeBox = false;
            picTopPageIcon.Image = Properties.Resources.text_noclaim_noreturn;
            picTopPageIcon.SizeMode = PictureBoxSizeMode.Zoom;
        }
        
        private void button_ChangeNewMember_Click(object sender, EventArgs e)
        {
            Program._mainFormContext.MainForm = new NewMember_Page();
            Program._mainFormContext.MainForm.Show();
            this.Close();
        }

        private void button_MainLogin_Click(object sender, EventArgs e)
        {
            Program._mainFormContext.MainForm = new Login_Page();
            Program._mainFormContext.MainForm.Show();
            this.Close();
        }

        private void btnChengeDB_Click(object sender, EventArgs e)
        {
            using (var con = new SQLiteConnection("Data Source=GEO.db"))
            {
                con.Open();
                using (SQLiteCommand command = con.CreateCommand())
                {
                    command.CommandText = "create table if not exists member_info(memberid TEXT not null PRIMARY KEY, memberpassword TEXT not null, memberlastname TEXT not null, memberfirstname TEXT not null, memberfuriganalastname TEXT not null, memberfuriganafirstname TEXT not null, memberdateofbirth INTEGER not null, memberaddress TEXT not null, memberphonenumber INTEGER not null, memberemailaddress TEXT not null)";
                    command.ExecuteNonQuery();
                    command.CommandText = "create table if not exists product_class(classid INTEGER not null PRIMARY KEY, classname not null TEXT)";
                    command.ExecuteNonQuery();
                    command.CommandText = "create table if not exists product_info(productid INTEGER not null PRIMARY KEY AUTO, productname TEXT not null, productprice INTEGER not null, productclassification INTEGER not null FOREIGN KEY(classid) REFERENCES [product_class](classid), productstock INTEGER not null)";
                    command.ExecuteNonQuery();
                    command.CommandText = "create table if not exists shop_info(shopid INTEGER not null PRIMARY KEY, shopname TEXT not null, shopaddress TEXT not null, shoptelephone INTEGER not null)";
                    command.ExecuteNonQuery();
                    Console.WriteLine("あああ");
                }
                con.Close();
            }
        }
    }
}