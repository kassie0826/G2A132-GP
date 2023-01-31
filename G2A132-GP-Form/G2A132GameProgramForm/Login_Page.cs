using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;

namespace G2A132GameProgramForm
{
    public partial class Login_Page : Form
    {
        bool _btnSwitch = default;

        public Login_Page()
        {
            InitializeComponent();
            // フォームを開いた際に画面中央に展開される処理
            this.StartPosition = FormStartPosition.CenterScreen;
            // パスワード用テキストボックスの文字部分を隠す処理
            textBox_Password.PasswordChar = '*';
        }

        /// <summary>
        /// ログイン処理
        /// ・入力された会員ID、パスワードが空かどうか確認する
        /// ・入力された会員ID、パスワードが合っているか確認する
        /// 処理が終わるとメインページに推移
        /// その後ログイン状態になるよう必要情報を渡す?
        /// </summary>
        /// <param name="sender">button_Login</param>
        /// <param name="e">ログインボタンを押したとき</param>
        private void button_Login_Click(object sender, EventArgs e)
        {
            if (textBox_MemberID.Text == string.Empty)
            {
                MessageBox.Show("会員IDが入力されていません。", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (textBox_Password.Text == string.Empty)
            {
                MessageBox.Show("パスワードが入力されていません。", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            //Properties.Settings.Default.MemberID
            //Properties.Settings.Default.ManagerID
            using (SQLiteConnection login = new SQLiteConnection("Data Source=GEO.db"))
            {
                DataTable dt = new DataTable();
                SQLiteDataAdapter da = new SQLiteDataAdapter("SELECT MemberID FROM member_info WHERE MemberID = " + int.Parse(textBox_MemberID.Text), login);
                da.Fill(dt);
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("そのIDは存在しません。", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                int id = int.Parse(textBox_MemberID.Text);

                dt = new DataTable();
                da = new SQLiteDataAdapter("SELECT * FROM member_info WHERE MemberID = " + id + " AND MemberPassword = '" + textBox_Password.Text + "'", login);
                da.Fill(dt);
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("パスワードが一致しません。", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                Properties.Settings.Default.MemberID = id;
                DialogResult successLogin = MessageBox.Show("ログインに成功しました。\nメインページへ戻ります。", "ログイン成功", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                if (successLogin == DialogResult.OK)
                {
                    // メインページをメインフォームに設定
                    Program.SetMainForm(new Main_Page());
                    // 現在のメインフォームを取得 (直前で設定したフォーム)
                    Form mainPageOpen = Program.GetMainForm();
                    // メインページを開く
                    mainPageOpen.Show();
                    // 新規会員登録ページを閉じる
                    this.Close();
                }
            }
        }

        private void button_DispalySwitching_Click(object sender, EventArgs e)
        {
            if (_btnSwitch)
            {
                textBox_Password.PasswordChar = '*';
            }
            else if (!_btnSwitch)
            {
                textBox_Password.PasswordChar = '\0';
            }
            _btnSwitch = !_btnSwitch;
        }

        private void button_BackMainPage_Click(object sender, EventArgs e)
        {
            // メインページをメインフォームに設定
            Program.SetMainForm(new Main_Page());
            // 現在のメインフォームを取得 (直前で設定したフォーム)
            Form mainPageOpen = Program.GetMainForm();
            // メインページを開く
            mainPageOpen.Show();
            // 新規会員登録ページを閉じる
            this.Close();
        }
    }
}
