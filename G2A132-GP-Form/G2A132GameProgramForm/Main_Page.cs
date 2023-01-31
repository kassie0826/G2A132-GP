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
            using (var startSQL = new SQLiteConnection("Data Source=GEO.db"))
            {
                startSQL.Open();
                using (SQLiteCommand command = startSQL.CreateCommand())
                {
                    command.CommandText = "create table if not exists member_info(MemberID INTEGER PRIMARY KEY AUTOINCREMENT, MemberPassword TEXT not null, MemberLastName TEXT not null, MemberFirstName TEXT not null, MemberFuriganaLastName TEXT not null, MemberFuriganaFirstName TEXT not null, MemberBirthYear INTEGER not null, MemberBirthMonth INTEGER not null, MemberBirthDate INTEGER not null, MemberAddress TEXT not null, MemberPhoneNumberLead INTEGER not null, MemberPhoneNumberMiddle INTEGER not null, MemberPhoneNumberEnd INTEGER not null, MemberEmailAddress TEXT not null)";
                    command.ExecuteNonQuery();
                }
                startSQL.Close();
            }

            if (Properties.Settings.Default.MemberID == 0)
            {
                groupBox1.Visible = false;
                groupBox2.Visible = true;
            }
            else
            {
                groupBox1.Visible = true;
                groupBox2.Visible = false;
            }
                //this.Size = new Size(820, 500);
                this.MaximizeBox = false;
        }

        private void button6_Click(object sender, EventArgs e)
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

        private void button4_Click(object sender, EventArgs e)
        {
            // ログインフォームをメインフォームに設定
            Program.SetMainForm(new Login_Page());
            // 現在のメインフォームを取得 (直前で設定したフォーム)
            Form mainPageOpen = Program.GetMainForm();
            // メインページを開く
            mainPageOpen.Show();
            // 新規会員登録ページを閉じる
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult logoutDialog = MessageBox.Show("ログアウトしてもよろしいですか？", "ログアウト確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (logoutDialog == DialogResult.OK)
            {
                Properties.Settings.Default.MemberID = 0;
            }
            DialogResult logoutConfirmDialog = MessageBox.Show("ログアウトしました。", "ログアウト完了", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            if (logoutConfirmDialog == DialogResult.OK)
            {
                // メインページフォームをメインフォームに設定
                Program.SetMainForm(new Main_Page());
                // 現在のメインフォームを取得 (直前で設定したフォーム)
                Form mainPageOpen = Program.GetMainForm();
                // メインページを開く
                mainPageOpen.Show();
                // 新規会員登録ページを閉じる
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // マイページフォームをメインフォームに設定
            Program.SetMainForm(new MyPage());
            // 現在のメインフォームを取得 (直前で設定したフォーム)
            Form mainPageOpen = Program.GetMainForm();
            // メインページを開く
            mainPageOpen.Show();
            // 新規会員登録ページを閉じる
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // マイページフォームをメインフォームに設定
            Program.SetMainForm(new Search_Page());
            // 現在のメインフォームを取得 (直前で設定したフォーム)
            Form mainPageOpen = Program.GetMainForm();
            // メインページを開く
            mainPageOpen.Show();
            // 新規会員登録ページを閉じる
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // マイページフォームをメインフォームに設定
            Program.SetMainForm(new Search_Page());
            // 現在のメインフォームを取得 (直前で設定したフォーム)
            Form mainPageOpen = Program.GetMainForm();
            // メインページを開く
            mainPageOpen.Show();
            // 新規会員登録ページを閉じる
            this.Close();
        }

        private void button_AppExit_Click(object sender, EventArgs e)
        {
            // 新規会員登録ページを閉じる
            this.Close();
        }
    }
}