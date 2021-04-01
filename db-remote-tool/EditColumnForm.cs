using System;
using System.Data;
using System.Windows.Forms;

namespace db_remote_tool
{
    public partial class EditColumnForm : Form
    {
        private DataGridView dgvTableInfo;
        private int rowNumber;

        public EditColumnForm(int rowNmb, DataGridView dgvTblInfo)
        {
            InitializeComponent();
            dgvTableInfo = dgvTblInfo;
            rowNumber = rowNmb;

            BindData();
        }

        private void BindData()
        {
            //если мы редактируем, а не создаём новый столбец, то загрузим данные о столбце в нынешнуюю форму
            if (dgvTableInfo.Rows[rowNumber].Cells[1].Value.ToString().Length > 0)
            {
                tbColName.Text = dgvTableInfo.Rows[rowNumber].Cells[1].Value.ToString();
                cmbColType.SelectedItem = dgvTableInfo.Rows[rowNumber].Cells[2].Value;
                cbColPk.Checked = Convert.ToBoolean(dgvTableInfo.Rows[rowNumber].Cells[5].Value);
            }
        }

        private void btnEditConfirm_Click(object sender, EventArgs e)
        {
            if (tbColName.Text.Length != 0 && cmbColType.SelectedItem != null)
            {
                /*если заполняется новая строка, то добавляем ещё одну пустую строку
                 * только придётся это делать через DataTable, т.к. есть привязка DataSource
                 * и напрямую нельзя добавлять пустую строку
                 */
                if (dgvTableInfo.Rows[rowNumber].Cells[0].Value.ToString().Length == 0)
                {
                    DataTable dataTableInfo_tmp = new DataTable();
                    dataTableInfo_tmp = (DataTable)dgvTableInfo.DataSource;

                    dataTableInfo_tmp.Rows.Add();

                    dgvTableInfo.DataSource = dataTableInfo_tmp;
                }

                dgvTableInfo.Rows[rowNumber].Cells[1].Value = tbColName.Text;
                dgvTableInfo.Rows[rowNumber].Cells[2].Value = cmbColType.SelectedItem;
                dgvTableInfo.Rows[rowNumber].Cells[5].Value = Convert.ToInt32(cbColPk.Checked);

                this.Close();
            }
            else
            {
                MessageBox.Show("Заполните все данные");
            }
        }
    }
}
