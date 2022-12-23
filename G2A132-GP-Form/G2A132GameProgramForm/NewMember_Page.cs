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
    public partial class NewMember_Page : Form
    {
        /// <summary>
        /// フォームが生成されたときに呼び出される
        /// </summary>
        public NewMember_Page()
        {
            InitializeComponent();
            //コンボボックスの入力不可処理 ()
            comboBox_BirthMonth.KeyPress += new KeyPressEventHandler(ComboBox_KeyPress);
        }

        //入力内容を確認するためにオブジェクト名(?)を配列に入れる
        //1ページ目の入力項目を文字列で格納する配列
        string[] _newMemberInfoVolume1 = new string[12]
        {
            "",
            "textBox_LastName", 
            "textBox_FirstName", 
            "textBox_LastNameFurigana", 
            "textBox_FirstNameFurigana",
            "textBox_BirthYear",
            "comboBox_BirthMonth",
            "textBox_BirthDate",
            "textBox_Address",
            "textBox_PhoneNumberLead",
            "textBox_PhoneNumberMiddle",
            "textBox_PhoneNumberEnd"
        };

        //2ページ目の入力項目を文字列で格納する配列
        string[] _newMemberInfoVolume2 = new string[5] 
        { 
            "",
            "textBox_EmailAddress", 
            "textBox_MemberID",
            "textBox_Password", 
            "textBox_PasswordReconfirmation" 
        };

        /// <summary>
        /// 新規会員登録ページに来たら入力項目のテキストを空にする処理
        /// いらないかもしれない
        /// </summary>
        private void NewMemberPage_Load(object sender, EventArgs e)
        {
            textBox_LastName.ResetText();
            textBox_FirstName.ResetText();
            textBox_LastNameFurigana.ResetText();
            textBox_FirstNameFurigana.ResetText();
            textBox_BirthYear.ResetText();
            comboBox_BirthMonth.ResetText();
            comboBox_BirthMonth.DropDownStyle = ComboBoxStyle.DropDownList;
            textBox_BirthDate.ResetText();
            textBox_Address.ResetText();
            textBox_PhoneNumberLead.ResetText();
            textBox_PhoneNumberMiddle.ResetText();
            textBox_PhoneNumberEnd.ResetText();
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
        /// 1ページ目の未入力項目チェック
        /// 必須項目が入力されていなかったらメッセージボックスで未入力項目を表示
        /// 同時に2ページ目への推移判定
        /// </summary>
        private void button_ChangeInfoVolume2_Click(object sender, EventArgs e)
        {
            int[] emptyPositionInfoVolume1 = new int[11];
            int[] notEmptyPositionInfoVolume1 = new int[11];
            for (int i = 1, c = 0; i < _newMemberInfoVolume1.Length; i++)
            {
                Console.WriteLine(groupBox_InfoVolume1.Controls[_newMemberInfoVolume1[i]].Text);
                if ((groupBox_InfoVolume1.Controls[_newMemberInfoVolume1[i]].Text) == string.Empty)
                {
                    Console.WriteLine(i);
                    emptyPositionInfoVolume1[c] = i;
                    c++;
                }
            }
            Console.WriteLine(emptyPositionInfoVolume1.Length);
            if (emptyPositionInfoVolume1[0] != 0)
            {
                string emptyMessageInfoVolume1 = string.Empty;
                bool phoneNumberDecision = false;
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
                            if (phoneNumberDecision) break;
                            phoneNumberDecision = true;
                            emptyMessageInfoVolume1 += "・電話番号\n";
                            break;
                        case 10:
                            if (phoneNumberDecision) break;
                            phoneNumberDecision = true;
                            emptyMessageInfoVolume1 += "・電話番号\n";
                            break;
                        case 11:
                            if (phoneNumberDecision) break;
                            phoneNumberDecision = true;
                            emptyMessageInfoVolume1 += "・電話番号\n";
                            break;
                    }
                }
                MessageBox.Show("次の項目が未入力です。\n" + emptyMessageInfoVolume1, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (emptyPositionInfoVolume1[0] == 0)
            {

                groupBox_InfoVolume2.Visible = true;
            }
            
        }

        /// <summary>
        /// 2ページ目から1ページ目に戻る処理
        /// 値は保持しておく予定
        /// </summary>
        private void button_BackInfoVolume1_Click(object sender, EventArgs e)
        {
            groupBox_InfoVolume2.Visible = false;
        }

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
                
            }
        }

        /// <summary>
        /// コンボボックスの入力不可処理
        /// </summary>
        private void ComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
