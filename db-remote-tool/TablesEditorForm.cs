using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace db_remote_tool
{
    public partial class TablesEditorForm : Form
    {
        private SQLiteConnection dbConn;

        public TablesEditorForm(SQLiteConnection dbConnInAuth)
        {
            dbConn = dbConnInAuth;
            InitializeComponent();
            BindData();
        }

        private void BindData()
        {
            //очистим TablesList - если до этого он был заполнен
            TablesList.DataSource = null;

            //отметим в качестве ключа и значения столбец name, а затем укажем в listbox источник данных
            TablesList.ValueMember = "name";
            TablesList.DisplayMember = "name";
            TablesList.DataSource = GetTablesInfo();
        }

        /// <summary>
        /// Перегрузка обновления списка таблиц, если происходит добавление новой таблицы
        /// </summary>
        /// <param name="newTblName">Название новой таблицы</param>
        private void BindData(string newTblName)
        {
            //очистим TablesList
            TablesList.DataSource = null;

            //отметим в качестве ключа и значения столбец name, а затем укажем в listbox источник данных
            TablesList.ValueMember = "name";
            TablesList.DisplayMember = "name";

            DataTable tblNames = GetTablesInfo();
            tblNames.Rows.Add(newTblName);

            TablesList.DataSource = tblNames;
        }

        private DataTable GetTablesInfo()
        {
            DataTable dTablesList = new DataTable();

            try
            {
                string sqlQueryGetTables = "SELECT name FROM sqlite_master WHERE type='table'";
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(sqlQueryGetTables, dbConn);
                adapter.Fill(dTablesList);
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
                Application.Exit();
            }

            return dTablesList;
        }

        private void btnNewTbl_Click(object sender, EventArgs e)
        {
            TableNameForm newTableForm = new TableNameForm(this);
            newTableForm.ShowDialog();
        }

        private void TablesEditor_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void TablesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
             * если происходит выбор элемента новой таблицы, то ничего не делаем, 
             * иначе подгружаем информацию об уже существующей таблице
             */

            if (TablesList.SelectedValue != null)
            {
                //очистим dgvTableInfo - если до этого он был заполнен
                dgvTableInfo.Refresh();
                dgvTableInfo.DataSource = GetTableInfo();
            }
        }

        private DataTable GetTableInfo()
        {
            DataTable dTableInfo = new DataTable();

            try
            {
                string sqlQueryTableInfo = "PRAGMA table_info(" + TablesList.SelectedValue.ToString() + ")";
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(sqlQueryTableInfo, dbConn);
                adapter.Fill(dTableInfo);
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
                Application.Exit();
            }

            return dTableInfo;
        }

        private void dgvTableInfo_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            //скроем некоторые столбцы в редакторе таблицы
            this.dgvTableInfo.Columns["dflt_value"].Visible = false;
            this.dgvTableInfo.Columns["notnull"].Visible = false;
            this.dgvTableInfo.Columns["cid"].Visible = false;
        }

        public void CreateNewElemTablesList(string tblName)
        {
            BindData(tblName);
            TablesList.SetSelected(TablesList.Items.Count - 1, true);
        }

        private void btnSaveTbl_Click(object sender, EventArgs e)
        {
            string sqlQueryCreateTbl = "CREATE TABLE " + TablesList.SelectedValue.ToString() + " (";

            string col_name;
            string col_type;
            bool col_isPk;

            //Пройдёмся по всем заполненным данным
            for (int i = 0; i <= dgvTableInfo.Rows.Count - 2; i++)
            {
                col_name = dgvTableInfo.Rows[i].Cells[1].Value.ToString();

                //не берём в расчёт незаполненные строки
                if (col_name.Length != 0)
                {
                    col_type = dgvTableInfo.Rows[i].Cells[2].Value.ToString();
                    col_isPk = Convert.ToBoolean(dgvTableInfo.Rows[i].Cells[5].Value);

                    if (i != 0)
                    {
                        sqlQueryCreateTbl += ", ";
                    }

                    sqlQueryCreateTbl += col_name + " " + col_type + " ";

                    if (col_isPk)
                    {
                        sqlQueryCreateTbl += "PRIMARY KEY";
                    }
                }
            }
            sqlQueryCreateTbl += ");";

            SQLCmdExec(sqlQueryCreateTbl);
        }

        private void btnDelTbl_Click(object sender, EventArgs e)
        {
            string sqlQueryTblDel = "DROP TABLE " + TablesList.SelectedValue.ToString();

            SQLCmdExec(sqlQueryTblDel);
        }

        private void dgvTableInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //индекс у названия столбцов в DataGridView -1, события клика по нему мы не учитываем
            if (e.RowIndex >= 0)
            {
                EditColumnForm editColumnForm = new EditColumnForm(e.RowIndex, dgvTableInfo);
                editColumnForm.ShowDialog();
            }
        }

        public void SQLCmdExec(string query)
        {
            try
            {
                SQLiteCommand sqlCmd = new SQLiteCommand
                {
                    Connection = dbConn,
                    CommandText = query
                };
                sqlCmd.ExecuteNonQuery();

                BindData();
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        private void btnRenameTbl_Click(object sender, EventArgs e)
        {
            TableNameForm tableNameForm = new TableNameForm(this, TablesList.SelectedValue.ToString());
            tableNameForm.ShowDialog();
        }
    }
}
