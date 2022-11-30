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
    }
}
