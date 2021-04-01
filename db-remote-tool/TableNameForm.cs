using System;
using System.Windows.Forms;

namespace db_remote_tool
{
    public partial class TableNameForm : Form
    {
        private TablesEditorForm tableEditorForm;
        private string oldNameTable;

        public TableNameForm(TablesEditorForm TblEditorForm)
        {
            InitializeComponent();
            tableEditorForm = TblEditorForm;
        }

        public TableNameForm(TablesEditorForm TblEditorForm, string oldNameTbl)
        {
            InitializeComponent();
            tableEditorForm = TblEditorForm;
            oldNameTable = oldNameTbl;

            tbTblName.Text = oldNameTbl;

            this.Text = "Новое имя для " + oldNameTbl;
        }

        private void btnCreateTblName_Click(object sender, EventArgs e)
        {
            if (tbTblName.TextLength == 0)
            {
                MessageBox.Show("Введите название таблицы");
            }
            else 
            {
                if (oldNameTable != null)
                {
                    string queryRenameTbl = "ALTER TABLE " + oldNameTable + " RENAME TO " + tbTblName.Text;
                    tableEditorForm.SQLCmdExec(queryRenameTbl);
                }
                else
                {
                    tableEditorForm.CreateNewElemTablesList(tbTblName.Text);
                }

                this.Close();
            }
        }
    }
}
