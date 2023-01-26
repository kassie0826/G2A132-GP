using System;
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
            // 新規会員登録フォームをメインフォームに設定
            Program.SetMainForm(new NewMember_Page());
            // 現在のメインフォームを取得 (直前で設定したフォーム)
            Form mainPageOpen = Program.GetMainForm();
            // メインページを開く
            mainPageOpen.Show();
            // 新規会員登録ページを閉じる
            this.Close();
        }

        private void button_MainLogin_Click(object sender, EventArgs e)
        {
            // 新規会員登録フォームをメインフォームに設定
            Program.SetMainForm(new Login_Page());
            // 現在のメインフォームを取得 (直前で設定したフォーム)
            Form mainPageOpen = Program.GetMainForm();
            // メインページを開く
            mainPageOpen.Show();
            // 新規会員登録ページを閉じる
            this.Close();
        }

        private void btnChengeDB_Click(object sender, EventArgs e)
        {
            using (var startSQL = new SQLiteConnection("Data Source=GERO.db"))
            {
                startSQL.Open();
                using (SQLiteCommand command = startSQL.CreateCommand())
                {
                    command.CommandText = "create table if not exists member_info(CD INTEGER AUTOINCREMENT, MemberID TEXT not null, MemberPassword TEXT not null, MemberLastName TEXT not null, MemberFirstName TEXT not null, MemberFuriganaLastName TEXT not null, MemberFuriganaFirstName TEXT not null, MemberDateOfBirth INTEGER not null, MemberAddress TEXT not null, MemberPhoneNumber INTEGER not null, MemberEmailAddress TEXT not null, PRIMARY KEY(CD, MemberID, MemberEmailAddress))";
                    command.ExecuteNonQuery();
                    command.CommandText = "insert ignore into member_info(MemberID, MemberPassword, MemberLastName, MemberFirstName, MemberFuriganaLastName, MemberFuriganaFirstName, MemberDateOfBirth, MemberAddress, MemberPhoneNumber, MemberEmailAddress) VALUE (000, aaaaaaaa, 田中, 太郎, タナカ, タロウ, 20030401, 札幌市中央区北1条西2丁目, 011-222-4894, 20217099-TanakaTarou@hcs.ac.jp)";
                    command.ExecuteNonQuery();
                    command.CommandText = "create table if not exists product_class(ClassID INTEGER not null PRIMARY KEY, ClassName TEXT not null)";
                    command.ExecuteNonQuery();
                    command.CommandText = "create table if not exists product_info(ProductID INTEGER PRIMARY KEY AUTOINCREMENT, ProductName TEXT not null, ProductPrice INTEGER not null, ProductClassification INTEGER not null, ProductStock INTEGER not null, FOREIGN KEY(ProductClassification) REFERENCES [product_class](ClassID))";
                    command.ExecuteNonQuery();
                    command.CommandText = "create table if not exists shop_info(ShopID INTEGER not null PRIMARY KEY, ShopName TEXT not null, ShopAddress TEXT not null, ShopTelephone INTEGER not null)";
                    command.ExecuteNonQuery();
                    Console.WriteLine("あああ");
                }
                startSQL.Close();
            }
        }
    }
}