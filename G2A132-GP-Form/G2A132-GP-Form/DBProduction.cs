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

namespace G2A132_GP_Form
{
    public partial class DBProduction : Form
    {
        public DBProduction()
        {
            InitializeComponent();
        }

        private void DBProduction_Load(object sender, EventArgs e)
        {

        }

        private void btnCreateTable_Click(object sender, EventArgs e)
        {
            int[] tBoxCount = new int[9];
            for (int i = 1, c = 1; i < 10; i++)
            {
                if (((TextBox)Controls[$"tBoxColumn{i}"]).Text != String.Empty)
                {
                    tBoxCount[c] = i;
                    c++;
                }
            }

            if (tBoxCount != null)
            {
                string createTableName = tBoxCreateTableName.Text;
                string createTableColumn = null;
                string[] INTEGER = new string[9];
                string[] TEXT = new string[9];
                foreach (int num in tBoxCount)
                {
                    if (((RadioButton)Controls["rButtonINTEGER" + $"{tBoxCount[num]}"]).Checked == true)
                    {
                        createTableColumn += (((TextBox)Controls[$"Column" + $"{tBoxCount[num]}"]).Text) + " " + $"INTEGER{num}" + ",";
                    }
                    else if (((RadioButton)Controls[$"rButtonTEXT" + "{tBoxCount[num]}"]).Checked == true)
                    {
                        createTableColumn += (((TextBox)Controls[$"Column" + "{tBoxCount[num]}"]).Text) + " " + $"TEXT{num}" + ",";
                    }
                    else if (((RadioButton)Controls[$"rButtonINTEGER" + "{tBoxCount[num]}"]).Checked == false && ((RadioButton)Controls[$"rButtonTEXT{tBoxCount[num]}"]).Checked == false)
                    {
                        MessageBox.Show("値の型を選んでください。", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    
                }
                string createTableColumn2 = createTableColumn.Remove(createTableColumn.Length - 1);
                using (var con = new SQLiteConnection($"Data Source=GEO.db"))
                {
                    con.Open();
                    using (SQLiteCommand command = con.CreateCommand())
                    {
                        command.CommandText = $"create table {createTableName}(CD INTEGER   PRIMARY KEY AUTOINCREMENT" + createTableColumn2 + ")";
                        command.ExecuteNonQuery();
                    }
                    con.Close();
                }
            }
            else if (tBoxCount == null)
            {
                MessageBox.Show("列名を入力してください", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
