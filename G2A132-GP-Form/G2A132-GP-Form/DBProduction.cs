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
        int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

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

            if (tBoxColumn1 != null)
            {
                string CreateTableName = tBoxCreateTableName.Text;
                using (var con = new SQLiteConnection($"Data Source={CreateTableName}"))
                {
                    con.Open();
                    using (SQLiteCommand command = con.CreateCommand())
                    {
                        command.CommandText = "create table t_product(CD INTEGER   PRIMARY KEY AUTOINCREMENT, productname TEXT, price INTEGER)";
                        command.ExecuteNonQuery();
                    }
                    con.Close();
                }
            }
            else
            {
                MessageBox.Show("値を入力してください", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
