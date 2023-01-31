using System;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Linq;

namespace G2A132GameProgramForm
{
    
    public partial class NewMember_Page : Form
    {
        // フォームが生成されたときに呼び出される
        public NewMember_Page()
        {
            InitializeComponent();
            // フォームの開始位置を画面中央に設定する処理
            this.StartPosition = FormStartPosition.CenterScreen;
            // 最大化を無効にする処理
            this.MaximizeBox = false;
        }

        //入力内容を確認するためにオブジェクト名(?)を配列に入れる
        //1ページ目の入力項目を文字列で格納する配列
        string[] _newMemberInfoVolume1 = new string[12]
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
            "textBox_PhoneNumberEnd"     // 11
        };

        //2ページ目の入力項目を文字列で格納する配列
        string[] _newMemberInfoVolume2 = new string[4] 
        { 
            "",                              // 0
            "textBox_EmailAddress",          // 1
            "textBox_Password",              // 2
            "textBox_PasswordReconfirmation" // 3
        };

        /// <summary>
        /// 新規会員登録ページに来たら入力項目のテキストに空にする処理と入力型の設定処理
        /// 文字配列の中身を使用して各々の入力項目に合った処理を行う
        /// </summary>
        /// <param name="sender">なんて書けばいいんだろう</param>
        /// <param name="e">このフォームが読み込まれたとき</param>
        private void NewMemberPage_Load(object sender, EventArgs e)
        {
            // 1ページ目の入力項目設定
            for (int i = 1; i < _newMemberInfoVolume1.Length; i++)
            {
                // テキストを空にする
                groupBox_InfoVolume1.Controls[_newMemberInfoVolume1[i]].ResetText();
                
                // 入力形式を整数型に固定したいテキストボックスを指定
                if (i == 5 || i == 7 || i == 9 || i == 10 || i == 11)
                {
                    // 数字以外の入力を無効にする
                    groupBox_InfoVolume1.Controls[_newMemberInfoVolume1[i]].KeyPress += new KeyPressEventHandler(IntOnly_KeyPress);
                    // 半角の入力のみ受け付けるようにする
                    groupBox_InfoVolume1.Controls[_newMemberInfoVolume1[i]].ImeMode = ImeMode.Disable;
                }
                // コンボボックスは他と少し処理が違うため分岐
                else if (_newMemberInfoVolume1[i] == "comboBox_BirthMonth")
                {
                    // コンボボックスの入力不可処理
                    comboBox_BirthMonth.KeyPress += new KeyPressEventHandler(ComboBox_KeyPress);
                    // ドロップダウンリストにする設定
                    comboBox_BirthMonth.DropDownStyle = ComboBoxStyle.DropDownList;
                }
            }

            // 2ページ目の入力項目設定
            for (int i = 1; i < _newMemberInfoVolume2.Length; i++)
            {
                // テキストを空にする
                groupBox_InfoVolume2.Controls[_newMemberInfoVolume2[i]].ResetText();
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
            textBox_PasswordReconfirmation.ShortcutsEnabled = false;
            #endregion
        }

        /// <summary>
        /// メインページに戻る処理
        /// すでに入力されている項目がある場合は、内容が破棄されることを確認するメッセージを出す
        /// </summary>
        /// <param name="sender">button_BackMainPage</param>
        /// <param name="e">新規会員登録画面からメインページに戻る</param>
        private void button_BackMainPage_Click(object sender, EventArgs e)
        {
            // 入力済みのテキストボックスを保持しておくための配列
            int[] notEmptyPositionInfoVolume1and2 = new int[15];

            // 入力済みの項目を探すためのループ処理
            for (int i = 1, not = 0; i <= (_newMemberInfoVolume1.Length - 1) + (_newMemberInfoVolume2.Length - 1); i++)
            {
                // 1ページ目の入力項目確認
                if (i <= _newMemberInfoVolume1.Length - 1)
                {
                    // 空ではない判定をとる
                    if ((groupBox_InfoVolume1.Controls[_newMemberInfoVolume1[i]].Text) != string.Empty)
                    {
                        // テキストボックスを判別するための変数を保持
                        notEmptyPositionInfoVolume1and2[not] = i;
                        // notのカウントアップ
                        not++;
                    }
                }
                // 2ページ目の入力項目確認
                else
                {
                    // 空ではない判定をとる
                    if ((groupBox_InfoVolume2.Controls[_newMemberInfoVolume2[i - 11]].Text) != string.Empty)
                    {
                        // テキストボックスを判別するための変数を保持
                        notEmptyPositionInfoVolume1and2[not] = i;
                        // notのカウントアップ
                        not++;
                    }
                }
                
            }

            // 入力している項目があったとき
            if (notEmptyPositionInfoVolume1and2[0] != 0)
            {
                // 入力内容を破棄していいかの確認
                DialogResult discardCheck = MessageBox.Show("入力内容を破棄してメインページに戻ろうとしています。 \nよろしいですか？", "入力内容の破棄", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                // 「はい」が押された場合
                if (discardCheck == DialogResult.Yes)
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
            else
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

        /// <summary>
        /// 1ページ目の項目チェック
        /// ・項目が入力されていなかったらメッセージボックスで未入力項目を表示
        /// 問題がなければ2ページ目への推移判定
        /// </summary>
        /// <param name="sender">button_ChangeInfoVolume2</param>
        /// <param name="e">ボタンが押された時</param>
        private void button_ChangeInfoVolume2_Click(object sender, EventArgs e)
        {
            // 空のテキストボックスを保持しておくための配列
            int[] emptyPositionInfoVolume1 = new int[11];
            // 入力済みのテキストボックスを保持しておくための配列
            int[] notEmptyPositionInfoVolume1 = new int[11];

            // 空、入力済みのテキストボックスを区別するループ処理
            for (int i = 1, emp = 0, not = 0; i < _newMemberInfoVolume1.Length; i++)
            {
                // 空の判定をとる
                if ((groupBox_InfoVolume1.Controls[_newMemberInfoVolume1[i]].Text) == string.Empty)
                {
                    emptyPositionInfoVolume1[emp] = i;
                    emp++;
                }
                // 空ではない判定をとる
                else if ((groupBox_InfoVolume1.Controls[_newMemberInfoVolume1[i]].Text) != string.Empty)
                {
                    notEmptyPositionInfoVolume1[not] = i;
                    not++;
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
                    }
                }
                // 未入力項目の表示
                MessageBox.Show("次の項目が未入力です。\n" + emptyMessageInfoVolume1, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            // 1ページ目の項目が全て空ではなかった時
            else if (emptyPositionInfoVolume1[0] == 0)
            {
                groupBox_InfoVolume2.BringToFront();
                // 2ページ目の表示処理
                groupBox_InfoVolume2.Visible = true;
            }
            
        }

        /// <summary>
        /// 2ページ目から1ページ目に戻る処理
        /// 値は保持しておく
        /// </summary>
        /// <param name="sender">button_BackInfoVolume1</param>
        /// <param name="e">1ページ目の項目に戻る</param>
        private void button_BackInfoVolume1_Click(object sender, EventArgs e)
        {
            // 2ページ目の非表示処理
            groupBox_InfoVolume2.Visible = false;
        }

        /// <summary>
        /// 2ページ目の入力項目チェック
        /// ・項目が入力されていなかったらメッセージボックスで未入力項目を表示
        /// 全ての項目が入力されていれば会員登録処理を行う
        /// 登録が完了したら通知をしてログイン画面へ推移
        /// </summary>
        /// <param name="sender">button_NewMemberRegister</param>
        /// <param name="e">登録ボタンが押された時</param>
        private void button_NewMemberRegister_Click(object sender, EventArgs e)
        {
            // 2ページ目未入力の
            int[] emptyPositionInfoVolume2 = new int[3];
            // 2ページ目の入力項目
            for (int i = 1, c = 0; i < _newMemberInfoVolume2.Length; i++)
            {
                if ((groupBox_InfoVolume2.Controls[_newMemberInfoVolume2[i]].Text) == string.Empty)
                {
                    emptyPositionInfoVolume2[c] = i;
                    c++;
                }
            }
            if (emptyPositionInfoVolume2[0] != 0)
            {
                string emptyMessageInfoVolume2 = string.Empty;
                for (int c = 0; c < emptyPositionInfoVolume2.Length; c++)
                {
                    switch (emptyPositionInfoVolume2[c])
                    {
                        case 1:
                            emptyMessageInfoVolume2 += "・メールアドレス\n";
                            break;
                        case 2:
                            emptyMessageInfoVolume2 += "・パスワード\n";
                            break;
                        case 3:
                            emptyMessageInfoVolume2 += "・パスワード (確認)\n";
                            break;
                    }
                }
                MessageBox.Show("次の項目が未入力です。\n" + emptyMessageInfoVolume2, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (emptyPositionInfoVolume2[0] == 0)
            {
                // 登録処理
                using (SQLiteConnection registerSQL = new SQLiteConnection("Data Source=GEO.db"))
                {
                    registerSQL.Open();
                    using (SQLiteCommand command = registerSQL.CreateCommand())
                    {
                        command.CommandText = "insert or ignore into " +
                        "member_info(MemberPassword, MemberLastName, MemberFirstName, MemberFuriganaLastName, MemberFuriganaFirstName, MemberBirthYear, MemberBirthMonth, MemberBirthDate, MemberAddress, MemberPhoneNumberLead, MemberPhoneNumberMiddle, MemberPhoneNumberEnd, MemberEmailAddress) " +
                        "VALUES (@password, @lastname, @firstname, @furiganalastname, @furiganafirstname, @birthyear, @birthmonth, @birthdate, @address, @phonenumberlead, @phonenumbermiddle, @phonenumberend, @emailaddress)";
                        command.Parameters.Add("password", System.Data.DbType.String);
                        command.Parameters.Add("lastname", System.Data.DbType.String);
                        command.Parameters.Add("firstname", System.Data.DbType.String);
                        command.Parameters.Add("furiganalastname", System.Data.DbType.String);
                        command.Parameters.Add("furiganafirstname", System.Data.DbType.String);
                        command.Parameters.Add("birthyear", System.Data.DbType.Int32);
                        command.Parameters.Add("birthmonth", System.Data.DbType.Int32);
                        command.Parameters.Add("birthdate", System.Data.DbType.Int32);
                        command.Parameters.Add("address", System.Data.DbType.String);
                        command.Parameters.Add("phonenumberlead", System.Data.DbType.String);
                        command.Parameters.Add("phonenumbermiddle", System.Data.DbType.String);
                        command.Parameters.Add("phonenumberend", System.Data.DbType.String);
                        command.Parameters.Add("emailaddress", System.Data.DbType.String);

                        command.Parameters["password"].Value = textBox_Password.Text;
                        command.Parameters["lastname"].Value = textBox_LastName.Text;
                        command.Parameters["firstname"].Value = textBox_FirstName.Text;
                        command.Parameters["furiganalastname"].Value = textBox_LastNameFurigana.Text;
                        command.Parameters["furiganafirstname"].Value = textBox_FirstNameFurigana.Text;
                        command.Parameters["birthyear"].Value = int.Parse(textBox_BirthYear.Text);
                        command.Parameters["birthmonth"].Value = int.Parse(comboBox_BirthMonth.Text);
                        command.Parameters["birthdate"].Value = int.Parse(textBox_BirthDate.Text);
                        command.Parameters["address"].Value = textBox_Address.Text;
                        command.Parameters["phonenumberlead"].Value = int.Parse(textBox_PhoneNumberLead.Text);
                        command.Parameters["phonenumbermiddle"].Value = int.Parse(textBox_PhoneNumberMiddle.Text);
                        command.Parameters["phonenumberend"].Value = int.Parse(textBox_PhoneNumberEnd.Text);
                        command.Parameters["emailaddress"].Value = textBox_EmailAddress.Text;
                        command.ExecuteNonQuery();
                    }
                    registerSQL.Close();

                    DataTable dt = new DataTable();
                    SQLiteDataAdapter da = new SQLiteDataAdapter("SELECT max(MemberID) FROM member_info", registerSQL);
                    da.Fill(dt);
                    string id = dt.Rows[0][0].ToString();

                    DialogResult successRegister = MessageBox.Show("登録が完了しました。\n会員ID : " + id + "\n\nメインページへ戻ります。", "登録完了", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    if (successRegister == DialogResult.OK)
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
