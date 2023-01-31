using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;

namespace G2A132GameProgramForm
{
    public partial class Search_Page : Form
    {
        string[] SearchInfoVolume = new string[13]
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
        };

        public Search_Page()
        {
            InitializeComponent();
        }

        private void Search_Page_Load(object sender, EventArgs e)
        {
            #region テキストボックスのコピペ入力を無効にする 
            textBox_LastName.Enabled = false;
            textBox_FirstName.Enabled = false;
            textBox_LastNameFurigana.Enabled = false;
            textBox_FirstNameFurigana.Enabled = false;
            textBox_BirthYear.Enabled = false;
            comboBox_BirthMonth.Enabled = false;
            textBox_BirthDate.Enabled = false;
            textBox_Address.Enabled = false;
            textBox_PhoneNumberLead.Enabled = false;
            textBox_PhoneNumberMiddle.Enabled = false;
            textBox_PhoneNumberEnd.Enabled = false;
            textBox_EmailAddress.Enabled = false;
            #endregion
        }

        private void button_BackMainPage_Click(object sender, EventArgs e)
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

        private void button_Search_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection memberInfo = new SQLiteConnection("Data Source=GEO.db"))
            {
                DataTable dt = new DataTable();
                SQLiteDataAdapter da = new SQLiteDataAdapter("SELECT * FROM member_info WHERE MemberID =" + int.Parse(textBox_ID.Text), memberInfo);
                da.Fill(dt);
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("そのIDは存在しません。", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                else
                {
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
                }
            }
        }
    }
}
