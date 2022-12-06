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
                if (((TextBox)Controls[$"Column{i}"]).Text != null)
                {
                    tBoxCount[c] = i;
                    c++;
                }
            }

            if (tBoxCount != null)
            {
                string createTableName = tBoxCreateTableName.Text;
                string createTableColumn = null;
                string[] tBoxText = new string[9];
                foreach (int num in tBoxCount)
                {
                    createTableColumn += (((TextBox)Controls[$"Column{tBoxCount[num]}"]).Text) + " " + "text int" + ",";
                }
                using (var con = new SQLiteConnection($"Data Source={createTableName}"))
                {
                    con.Open();
                    using (SQLiteCommand command = con.CreateCommand())
                    {
                        command.CommandText = $"create table t_product()";
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
