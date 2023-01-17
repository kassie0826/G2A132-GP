using System;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace G2A132GameProgramForm
{
    public partial class NewMember_Page : Form
    {
        // フォームが生成されたときに呼び出される
        public NewMember_Page()
        {
            InitializeComponent();
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
        string[] _newMemberInfoVolume2 = new string[5] 
        { 
            "",                              // 0
            "textBox_EmailAddress",          // 1
            "textBox_MemberID",              // 2
            "textBox_Password",              // 3
            "textBox_PasswordReconfirmation" // 4
        };

        /// <summary>
        /// 新規会員登録ページに来たら入力項目のテキストに空にする処理と入力型の設定処理
        /// いらないかもしれない
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewMemberPage_Load(object sender, EventArgs e)
        {
            for (int i = 1; i < _newMemberInfoVolume1.Length; i++)
            {
                groupBox_InfoVolume1.Controls[_newMemberInfoVolume1[i]].ResetText();
                if (i == 1 ||  i == 2 || i == 3 || i == 4 || i == 8)
                {
                    groupBox_InfoVolume1.Controls[_newMemberInfoVolume1[i]].KeyPress += new KeyPressEventHandler(StringOnly_KeyPress);
                }
                else if (i == 5 || i == 6 || i == 7 || i == 9 || i == 10 || i == 11)
                {
                    groupBox_InfoVolume1.Controls[_newMemberInfoVolume1[i]].KeyPress += new KeyPressEventHandler(IntOnly_KeyPress);
                }

                if (_newMemberInfoVolume1[i] == "comboBox_BirthMonth")
                {
                    // コンボボックスの入力不可処理 ()
                    comboBox_BirthMonth.KeyPress += new KeyPressEventHandler(ComboBox_KeyPress);
                    comboBox_BirthMonth.DropDownStyle = ComboBoxStyle.DropDownList;
                }
            }

            for (int i = 1; i < _newMemberInfoVolume2.Length; i++)
            {
                groupBox_InfoVolume2.Controls[_newMemberInfoVolume2[i]].ResetText();
                groupBox_InfoVolume2.Controls[_newMemberInfoVolume2[i]].KeyPress += new KeyPressEventHandler(StringOnly_KeyPress);
            }
        }

        /// <summary>
        /// メインページに戻る処理
        /// すでに入力されている項目がある場合は、内容が破棄されることを確認するメッセージを出す
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBackMainPage_Click(object sender, EventArgs e)
        {
            Program.mainFormContext.MainForm = new Main_Page();
            Program.mainFormContext.MainForm.Show();
            this.Close();
        }

        /// <summary>
        /// 1ページ目の項目チェック
        /// ・必須項目が入力されていなかったらメッセージボックスで未入力項目を表示
        /// ・入力項目が型にあっているかの判定
        /// 問題がなければ2ページ目への推移判定
        /// </summary>
        /// <param name="sender">button_ChangeInfoVolume2</param>
        /// <param name="e">ボタンが押された時</param>
        private void button_ChangeInfoVolume2_Click(object sender, EventArgs e)
        {
            int[] emptyPositionInfoVolume1 = new int[11];
            int[] notEmptyPositionInfoVolume1 = new int[11];
            for (int i = 1, emp = 0, not = 0; i < _newMemberInfoVolume1.Length; i++)
            {
                Console.WriteLine(groupBox_InfoVolume1.Controls[_newMemberInfoVolume1[i]].Text);
                if ((groupBox_InfoVolume1.Controls[_newMemberInfoVolume1[i]].Text) == string.Empty)
                {
                    Console.WriteLine("e" + i);
                    emptyPositionInfoVolume1[emp] = i;
                    emp++;
                }
                else if ((groupBox_InfoVolume1.Controls[_newMemberInfoVolume1[i]].Text) != string.Empty)
                {
                    Console.WriteLine("ne" + i);
                    notEmptyPositionInfoVolume1[not] = i;
                    not++;
                }
            }
            Console.WriteLine(emptyPositionInfoVolume1.Length);
            if (emptyPositionInfoVolume1[0] != 0)
            {
                string emptyMessageInfoVolume1 = string.Empty;
                bool phoneNumberDecision1 = false;
                for (int c = 0; c < emptyPositionInfoVolume1.Length; c++)
                {
                    Console.WriteLine(emptyPositionInfoVolume1[c]);
                    switch (emptyPositionInfoVolume1[c])
                    {
                        case 1:
                            emptyMessageInfoVolume1 += "・姓\n";
                            break;
                        case 2:
                            emptyMessageInfoVolume1 += "・名\n";
                            break;
                        case 3:
                            emptyMessageInfoVolume1 += "・姓 (カナ)\n";
                            break;
                        case 4:
                            emptyMessageInfoVolume1 += "・名 (カナ)\n";
                            break;
                        case 5:
                            emptyMessageInfoVolume1 += "・誕生年\n";
                            break;
                        case 6:
                            emptyMessageInfoVolume1 += "・誕生月\n";
                            break;
                        case 7:
                            emptyMessageInfoVolume1 += "・誕生日\n";
                            break;
                        case 8:
                            emptyMessageInfoVolume1 += "・住所\n";
                            break;
                        case 9:
                            if (phoneNumberDecision1) break;
                            phoneNumberDecision1 = true;
                            emptyMessageInfoVolume1 += "・電話番号\n";
                            break;
                        case 10:
                            if (phoneNumberDecision1) break;
                            phoneNumberDecision1 = true;
                            emptyMessageInfoVolume1 += "・電話番号\n";
                            break;
                        case 11:
                            if (phoneNumberDecision1) break;
                            phoneNumberDecision1 = true;
                            emptyMessageInfoVolume1 += "・電話番号\n";
                            break;
                    }
                }
                MessageBox.Show("次の項目が未入力です。\n" + emptyMessageInfoVolume1, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (emptyPositionInfoVolume1[0] == 0)
            {
                // 
                groupBox_InfoVolume2.Visible = true;
            }
            
        }

        /// <summary>
        /// 2ページ目から1ページ目に戻る処理
        /// 値は保持しておく予定
        /// </summary>
        private void button_BackInfoVolume1_Click(object sender, EventArgs e)
        {
            // 2ページ目の非表示処理 (ごり押し)
            groupBox_InfoVolume2.Visible = false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_NewMemberRegister_Click(object sender, EventArgs e)
        {
            int[] emptyPositionInfoVolume2 = new int[4];
            for (int i = 1, c = 0; i < _newMemberInfoVolume2.Length; i++)
            {
                Console.WriteLine(groupBox_InfoVolume2.Controls[_newMemberInfoVolume2[i]].Text);
                if ((groupBox_InfoVolume2.Controls[_newMemberInfoVolume2[i]].Text) == string.Empty)
                {
                    Console.WriteLine(i);
                    emptyPositionInfoVolume2[c] = i;
                    c++;
                }
            }
            if (emptyPositionInfoVolume2[0] != 0)
            {
                string emptyMessageInfoVolume2 = string.Empty;
                for (int c = 0; c < emptyPositionInfoVolume2.Length; c++)
                {
                    Console.WriteLine(emptyPositionInfoVolume2[c]);
                    switch (emptyPositionInfoVolume2[c])
                    {
                        case 1:
                            emptyMessageInfoVolume2 += "・メールアドレス\n";
                            break;
                        case 2:
                            emptyMessageInfoVolume2 += "・会員ID\n";
                            break;
                        case 3:
                            emptyMessageInfoVolume2 += "・パスワード\n";
                            break;
                        case 4:
                            emptyMessageInfoVolume2 += "・パスワード (確認)\n";
                            break;
                    }
                }
                MessageBox.Show("次の項目が未入力です。\n" + emptyMessageInfoVolume2, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (emptyPositionInfoVolume2[0] == 0)
            {
                // 登録処理
                // 登録成功通知
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
            if (e.KeyChar < 'A' || 'Z' < e.KeyChar || e.KeyChar < 'a' || 'z' < e.KeyChar)
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
            if (e.KeyChar < '0' || '9' < e.KeyChar)
            {
                e.Handled = true;
            }
        }
    }
}
