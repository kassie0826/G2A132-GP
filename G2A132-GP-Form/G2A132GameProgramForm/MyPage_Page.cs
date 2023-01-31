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
    public partial class MyPage : Form
    {
        string[] MemberInfoVolume = new string[14]
        {
            "",                          //  0
            "textBox_LastName",          //  1 
            "textBox_FirstName",         //  2
            "textBox_LastNameFurigana",  //  3 
            "textBox_FirstNameFurigana", //  4
            "textBox_BirthYear",         //  5
            "comboBox_BirthMonth",       //  6
            "textBox_BirthDate",         //  7
            "textBox_Address",           //  8
            "textBox_PhoneNumberLead",   //  9
            "textBox_PhoneNumberMiddle", // 10
            "textBox_PhoneNumberEnd",    // 11
            "textBox_EmailAddress",      // 12
            "textBox_Password",          // 13
        };

        public MyPage()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            using (SQLiteConnection memberInfo = new SQLiteConnection("Data Source=GEO.db"))
            {
                DataTable dt = new DataTable();
                SQLiteDataAdapter da = new SQLiteDataAdapter("SELECT * FROM member_info WHERE MemberID =" + Properties.Settings.Default.MemberID, memberInfo);
                da.Fill(dt);
                textBox_LastName.Text = dt.Rows[0]["MemberLastName"].ToString();
                textBox_FirstName.Text = dt.Rows[0]["MemberFirstName"].ToString();
                textBox_LastNameFurigana.Text = dt.Rows[0]["MemberFuriganaLastName"].ToString();
                textBox_FirstNameFurigana.Text = dt.Rows[0]["memberFuriganaFirstName"].ToString();
                textBox_BirthYear.Text = dt.Rows[0]["MemberBirthYear"].ToString();
                comboBox_BirthMonth.Text = dt.Rows[0]["MemberBirthMonth"].ToString();
                textBox_BirthDate.Text = dt.Rows[0]["MemberBirthDate"].ToString();
                textBox_Address.Text = dt.Rows[0]["MemberAddress"].ToString();
                textBox_PhoneNumberLead.Text = dt.Rows[0]["MemberPhoneNumberLead"].ToString();
                textBox_PhoneNumberMiddle.Text = dt.Rows[0]["MemberPhoneNumberMiddle"].ToString();
                textBox_PhoneNumberEnd.Text = dt.Rows[0]["MemberPhoneNumberEnd"].ToString();
                textBox_EmailAddress.Text = dt.Rows[0]["MemberEmailAddress"].ToString();
                textBox_Password.Text = dt.Rows[0]["MemberPassword"].ToString();
            }

            for (int i = 1; i < MemberInfoVolume.Length; i++)
            {
                // 入力形式を整数型に固定したいテキストボックスを指定
                if (i == 5 || i == 7 || i == 9 || i == 10 || i == 11)
                {
                    // 数字以外の入力を無効にする
                    Controls[MemberInfoVolume[i]].KeyPress += new KeyPressEventHandler(IntOnly_KeyPress);
                    // 半角の入力のみ受け付けるようにする
                    Controls[MemberInfoVolume[i]].ImeMode = ImeMode.Disable;
                }
                // コンボボックスは他と少し処理が違うため分岐
                else if (MemberInfoVolume[i] == "comboBox_BirthMonth")
                {
                    // コンボボックスの入力不可処理
                    comboBox_BirthMonth.KeyPress += new KeyPressEventHandler(ComboBox_KeyPress);
                    // ドロップダウンリストにする設定
                    comboBox_BirthMonth.DropDownStyle = ComboBoxStyle.DropDownList;
                }
            }

            #region テキストボックスのコピペ入力を無効にする 
            textBox_LastName.ShortcutsEnabled = false;
            textBox_FirstName.ShortcutsEnabled = false;
            textBox_LastNameFurigana.ShortcutsEnabled = false;
            textBox_FirstNameFurigana.ShortcutsEnabled = false;
            textBox_BirthYear.ShortcutsEnabled = false;
            textBox_BirthDate.ShortcutsEnabled = false;
            textBox_Address.ShortcutsEnabled = false;
            textBox_PhoneNumberLead.ShortcutsEnabled = false;
            textBox_PhoneNumberMiddle.ShortcutsEnabled = false;
            textBox_PhoneNumberEnd.ShortcutsEnabled = false;
            textBox_EmailAddress.ShortcutsEnabled = false;
            textBox_Password.ShortcutsEnabled = false;
            #endregion
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

        private void button_Update_Click(object sender, EventArgs e)
        {
            // 空のテキストボックスを保持しておくための配列
            int[] emptyPositionInfoVolume1 = new int[13];
            // 空、入力済みのテキストボックスを区別するループ処理
            for (int i = 1, emp = 0; i < MemberInfoVolume.Length; i++)
            {
                // 空の判定をとる
                if ((Controls[MemberInfoVolume[i]].Text) == string.Empty)
                {
                    emptyPositionInfoVolume1[emp] = i;
                    emp++;
                }
            }

            // 空のテクストボックスがあったとき
            if (emptyPositionInfoVolume1[0] != 0)
            {
                // メッセージボックスに出す未入力項目をまとめるための変数
                string emptyMessageInfoVolume1 = string.Empty;
                // 未入力時に電話番号のメッセージが複数出ないようにするため
                bool phoneNumberDecision1 = false;
                // 未入力項目をまとめる
                for (int c = 0; c < emptyPositionInfoVolume1.Length; c++)
                {
                    // 格納されている数字によって処理を分ける
                    switch (emptyPositionInfoVolume1[c])
                    {
                        // textBox_LastName
                        case 1:
                            // メッセージに姓を追加
                            emptyMessageInfoVolume1 += "・姓\n";
                            break;
                        // textBox_FirstName
                        case 2:
                            // メッセージに名を追加
                            emptyMessageInfoVolume1 += "・名\n";
                            break;
                        // textBox_LastNameFurigana
                        case 3:
                            // メッセージに姓 (カナ)を追加
                            emptyMessageInfoVolume1 += "・姓 (カナ)\n";
                            break;
                        // textBox_FirstNameFurigana
                        case 4:
                            // メッセージに名 (カナ)を追加
                            emptyMessageInfoVolume1 += "・名 (カナ)\n";
                            break;
                        // textBox_BirthYear
                        case 5:
                            // メッセージに誕生年を追加
                            emptyMessageInfoVolume1 += "・誕生年\n";
                            break;
                        // comboBox_BirthMonth
                        case 6:
                            // メッセージに誕生月を追加
                            emptyMessageInfoVolume1 += "・誕生月\n";
                            break;
                        // textBox_BirthDate
                        case 7:
                            // メッセージに誕生日を追加
                            emptyMessageInfoVolume1 += "・誕生日\n";
                            break;
                        // textBox_Address
                        case 8:
                            // メッセージに住所を追加
                            emptyMessageInfoVolume1 += "・住所\n";
                            break;
                        // textBox_PhoneNumberLead
                        case 9:
                            // すでに電話番号が未入力項目に入っていれば処理を抜ける
                            if (phoneNumberDecision1) break;
                            // 未入力項目がかぶらないようにフラグを立てる
                            phoneNumberDecision1 = true;
                            // メッセージに電話番号を追加
                            emptyMessageInfoVolume1 += "・電話番号\n";
                            break;
                        // textBox_PhoneNumberMiddle
                        case 10:
                            // すでに電話番号が未入力項目に入っていれば処理を抜ける
                            if (phoneNumberDecision1) break;
                            // 未入力項目がかぶらないようにフラグを立てる
                            phoneNumberDecision1 = true;
                            // メッセージに電話番号を追加
                            emptyMessageInfoVolume1 += "・電話番号\n";
                            break;
                        // textBox_PhoneNumberEnd
                        case 11:
                            // すでに電話番号が未入力項目に入っていれば処理を抜ける
                            if (phoneNumberDecision1) break;
                            // 未入力項目がかぶらないようにフラグを立てる
                            phoneNumberDecision1 = true;
                            // メッセージに電話番号を追加
                            emptyMessageInfoVolume1 += "・電話番号\n";
                            break;
                        case 12:
                            // メッセージにメールアドレスを追加
                            emptyMessageInfoVolume1 += "・メールアドレス\n";
                            break;
                        case 13:
                            // メッセージにパスワードを追加
                            emptyMessageInfoVolume1 += "・パスワード\n";
                            break;
                    }
                }
                // 未入力項目の表示
                MessageBox.Show("次の項目が未入力です。\n" + emptyMessageInfoVolume1, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            // 空のテクストボックスがなかったとき
            else if (emptyPositionInfoVolume1[0] == 0)
            {
                using (SQLiteConnection update = new SQLiteConnection("Data Source=GEO.db"))
                {
                    update.Open();
                    using (SQLiteTransaction data = update.BeginTransaction())
                    {
                        SQLiteCommand command = update.CreateCommand();
                        command.CommandText = "UPDATE member_info set MemberPassword = @password, MemberLastName = @lastname, MemberFirstName = @firstname, MemberFuriganaLastName = @furilastname, MemberFuriganaFirstName = @furifirstname, MemberBirthYear = @year, MemberBirthMonth = @month, MemberBirthDate = @date, MemberAddress = @address, MemberPhoneNumberLead = @lead, MemberPhoneNumberMiddle = @middle, MemberPhoneNumberEnd = @end, MemberEmailAddress = @email";
                        command.Parameters.Add("password", System.Data.DbType.String);
                        command.Parameters.Add("lastname", System.Data.DbType.String);
                        command.Parameters.Add("firstname", System.Data.DbType.String);
                        command.Parameters.Add("furilastname", System.Data.DbType.String);
                        command.Parameters.Add("furifirstname", System.Data.DbType.String);
                        command.Parameters.Add("year", System.Data.DbType.Int32);
                        command.Parameters.Add("month", System.Data.DbType.Int32);
                        command.Parameters.Add("date", System.Data.DbType.Int32);
                        command.Parameters.Add("address", System.Data.DbType.String);
                        command.Parameters.Add("lead", System.Data.DbType.Int32);
                        command.Parameters.Add("middle", System.Data.DbType.Int32);
                        command.Parameters.Add("end", System.Data.DbType.Int32);
                        command.Parameters.Add("email", System.Data.DbType.String);

                        command.Parameters["password"].Value = textBox_Password.Text;
                        command.Parameters["lastname"].Value = textBox_LastName.Text;
                        command.Parameters["firstname"].Value = textBox_FirstName.Text;
                        command.Parameters["furilastname"].Value = textBox_LastNameFurigana.Text;
                        command.Parameters["furifirstname"].Value = textBox_FirstNameFurigana.Text;
                        command.Parameters["year"].Value = int.Parse(textBox_BirthYear.Text);
                        command.Parameters["month"].Value = int.Parse(comboBox_BirthMonth.Text);
                        command.Parameters["date"].Value = int.Parse(textBox_BirthDate.Text);
                        command.Parameters["address"].Value = textBox_Address.Text;
                        command.Parameters["lead"].Value = int.Parse(textBox_PhoneNumberLead.Text);
                        command.Parameters["middle"].Value = int.Parse(textBox_PhoneNumberMiddle.Text);
                        command.Parameters["end"].Value = int.Parse(textBox_PhoneNumberEnd.Text);
                        command.Parameters["email"].Value = textBox_EmailAddress.Text;
                        command.ExecuteNonQuery();
                        data.Commit();
                    }
                }
                MessageBox.Show("更新が完了しました。", "更新完了", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult deleteDialog = MessageBox.Show("退会してもよろしいですか？\n現在登録されている情報はすべて削除されます。", "削除確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (deleteDialog == DialogResult.OK)
            {
                using (SQLiteConnection delete = new SQLiteConnection("Data Source=GEO.db"))
                {
                    delete.Open();
                    using (SQLiteTransaction deleteComfirm = delete.BeginTransaction())
                    {
                        SQLiteCommand command = delete.CreateCommand();
                        command.CommandText = "DELETE FROM member_info WHERE MemberID = @id;";
                        command.Parameters.Add("id", System.Data.DbType.Int32);
                        command.Parameters["id"].Value = Properties.Settings.Default.MemberID;
                        command.ExecuteNonQuery();
                        deleteComfirm.Commit();
                        Properties.Settings.Default.MemberID = 0;
                    }
                    delete.Close();
                }
                DialogResult deleteConfirmDialog = MessageBox.Show("退会が完了しました。\nメインページへ戻ります", "退会完了", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                if (deleteConfirmDialog == DialogResult.OK)
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

        /// <summary>
        /// コンボボックスの入力不可処理
        /// </summary>
        /// <param name="sender">入力不可にしたいコンボボックス</param>
        /// <param name="e">このフォームがロードされたとき</param>
        private void ComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        /// <summary>
        /// テキストボックスに入力する際に文字のみの入力に強制する処理
        /// </summary>
        /// <param name="sender">文字のみ入力可能にしたいテキストボックス</param>
        /// <param name="e">このフォームがロードされたとき</param>
        private void StringOnly_KeyPress(object sender, KeyPressEventArgs e)
        {
            // A～Z, a～z以外の入力だったら無効
            if ((e.KeyChar < 'A' || 'Z' < e.KeyChar) || (e.KeyChar < 'a' || 'z' < e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// テキストボックスに入力する際に数字のみの入力に強制する処理
        /// </summary>
        /// <param name="sender">数字のみ入力可能にしたいテキストボックス</param>
        /// <param name="e">このフォームがロードされたとき</param>
        private void IntOnly_KeyPress(object sender, KeyPressEventArgs e)
        {
            // 0～9以外の入力だったら無効
            if ((e.KeyChar < '0' || '9' < e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }
    }
}
