using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace db_remote_tool
{
    public partial class AuthForm : Form
    {
        private string dbFileName;
        private SQLiteConnection dbConn;

        public AuthForm()
        {
            InitializeComponent();
        }

        private void Auth_Load(object sender, EventArgs e)
        {
            dbConn = new SQLiteConnection();

            dbFileName = "testDB.db";
        }

        private void btnAuth_Click(object sender, EventArgs e)
        {
            if (tbUser.Text.Length == 0 || tbPassword.Text.Length == 0)
            {
                MessageBox.Show("Заполните все поля");
            }
            else
            {
                try
                {
                    dbConn = new SQLiteConnection("Data Source=" + dbFileName + ";Version=3;");
                    dbConn.Open();

                    DataTable dTableUsers = new DataTable();

                    string sqlQueryUsers = "SELECT * FROM Accounts WHERE user_name = '" + tbUser.Text + 
                                                                  "' AND user_password='" + tbPassword.Text +
                                                                  "' AND isAdmin = true";

                    SQLiteDataAdapter adapter = new SQLiteDataAdapter(sqlQueryUsers, dbConn);
                    adapter.Fill(dTableUsers);

                    if (dTableUsers.Rows.Count < 1)
                    {
                        MessageBox.Show("Неверный логин/пароль, либо у вас отсутствуют права администратора");
                    }
                    else
                    {
                        TablesEditorForm tablesEditor = new TablesEditorForm(dbConn);
                        tablesEditor.Show();

                        this.Hide();
                    }
                }
                catch (SQLiteException ex)
                {
                    MessageBox.Show("Ошибка: " + ex.Message);
                }
            }
        }
    }
}
