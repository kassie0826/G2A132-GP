using System;
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
    public partial class NewMember_Page : Form
    {
        //入力内容の確認用配列
        //1ページ目の入力項目配列
        string[] _newMemberInfoVolume1 = new string[12] { "", "textBox_LastName", "textBox_FirstName", "textBox_LastNameFurigana", "textBox_FirstNameFurigana", "textBox_BirthYear", "comboBox_BirthMonth", "textBox_BirthDate", "textBox_Address", "textBox_PhoneNumberLead", "textBox_PhoneNumberMiddle", "textBox_PhoneNumberEnd" };
        //2ページ目の入力項目配列
        string[] _newMemberInfoVolume2 = new string[4] { "textBox_EmailAddress", "textBox_MemberID", "textBox_Password", "textBox_PasswordReconfirmation" };

        public NewMember_Page()
        {
            InitializeComponent();
        }

        private void btnBackMainPage_Click(object sender, EventArgs e)
        {
            Program.mainFormContext.MainForm = new Main_Page();
            Program.mainFormContext.MainForm.Show();
            this.Close();
        }

        private void button_ChangeInfoVolume2_Click(object sender, EventArgs e)
        {
            int[] emptyPosition = new int[11];
            for (int i = 1, c = 0; i < 11; i++)
            {
                string contextCheck = _newMemberInfoVolume1[i];
                Console.WriteLine(contextCheck);
                if (((TextBox)Controls["contextCheck"]).Text == string.Empty)
                {
                    Console.WriteLine(i);
                    emptyPosition[c] = i;
                    c++;
                }
            }
            if (emptyPosition[0] != 0)
            {
                string emptyMessage = string.Empty;
                foreach (int c in emptyPosition)
                {
                    bool phoneNumberDecision = false;
                    switch (emptyPosition[c])
                    {
                        case 0:
                            emptyMessage += "・姓\n";
                            break;
                        case 1:
                            emptyMessage += "・名\n";
                            break;
                        case 2:
                            emptyMessage += "・姓 (カナ)\n";
                            break;
                        case 3:
                            emptyMessage += "・名 (カナ)\n";
                            break;
                        case 4:
                            emptyMessage += "・誕生年\n";
                            break;
                        case 5:
                            emptyMessage += "・誕生月\n";
                            break;
                        case 6:
                            emptyMessage += "・誕生日\n";
                            break;
                        case 7:
                            emptyMessage += "・住所\n";
                            break;
                        case 8:
                            if (phoneNumberDecision) break;
                            phoneNumberDecision = true;
                            emptyMessage += "・電話番号\n";
                            break;
                        case 9:
                            if (phoneNumberDecision) break;
                            phoneNumberDecision = true;
                            emptyMessage += "・電話番号\n";
                            break;
                        case 10:
                            if (phoneNumberDecision) break;
                            phoneNumberDecision = true;
                            emptyMessage += "・電話番号\n";
                            break;
                    }
                }
                MessageBox.Show("次の項目が未入力です。\n" + emptyMessage,"ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (emptyPosition[0] == 0)
            {
                groupBox_InfoVolume2.Visible = true;
            }
            
        }

        private void button_BackInfoVolume1_Click(object sender, EventArgs e)
        {
            groupBox_InfoVolume2.Visible = false;
        }

        private void button_NewMemberRegister_Click(object sender, EventArgs e)
        {
            
        }
    }
}
