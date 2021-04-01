using System.Drawing;

namespace db_remote_tool
{
    partial class TablesEditorForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.TablesList = new System.Windows.Forms.ListBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.btnSaveTbl = new System.Windows.Forms.Button();
            this.btnDelTbl = new System.Windows.Forms.Button();
            this.btnNewTbl = new System.Windows.Forms.Button();
            this.dgvTableInfo = new System.Windows.Forms.DataGridView();
            this.btnRenameTbl = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTableInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.TablesList);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(700, 356);
            this.splitContainer1.SplitterDistance = 232;
            this.splitContainer1.TabIndex = 0;
            // 
            // TablesList
            // 
            this.TablesList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TablesList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TablesList.FormattingEnabled = true;
            this.TablesList.ItemHeight = 20;
            this.TablesList.Location = new System.Drawing.Point(0, 0);
            this.TablesList.Name = "TablesList";
            this.TablesList.Size = new System.Drawing.Size(232, 356);
            this.TablesList.TabIndex = 0;
            this.TablesList.SelectedIndexChanged += new System.EventHandler(this.TablesList_SelectedIndexChanged);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.btnRenameTbl);
            this.splitContainer2.Panel1.Controls.Add(this.btnSaveTbl);
            this.splitContainer2.Panel1.Controls.Add(this.btnDelTbl);
            this.splitContainer2.Panel1.Controls.Add(this.btnNewTbl);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.AutoScroll = true;
            this.splitContainer2.Panel2.Controls.Add(this.dgvTableInfo);
            this.splitContainer2.Size = new System.Drawing.Size(464, 356);
            this.splitContainer2.SplitterDistance = 60;
            this.splitContainer2.TabIndex = 0;
            // 
            // btnSaveTbl
            // 
            this.btnSaveTbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSaveTbl.Location = new System.Drawing.Point(241, 4);
            this.btnSaveTbl.Name = "btnSaveTbl";
            this.btnSaveTbl.Size = new System.Drawing.Size(94, 54);
            this.btnSaveTbl.TabIndex = 2;
            this.btnSaveTbl.Text = "Сохранить";
            this.btnSaveTbl.UseVisualStyleBackColor = true;
            this.btnSaveTbl.Click += new System.EventHandler(this.btnSaveTbl_Click);
            // 
            // btnDelTbl
            // 
            this.btnDelTbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDelTbl.Location = new System.Drawing.Point(137, 3);
            this.btnDelTbl.Name = "btnDelTbl";
            this.btnDelTbl.Size = new System.Drawing.Size(98, 54);
            this.btnDelTbl.TabIndex = 1;
            this.btnDelTbl.Text = "Удалить таблицу";
            this.btnDelTbl.UseVisualStyleBackColor = true;
            this.btnDelTbl.Click += new System.EventHandler(this.btnDelTbl_Click);
            // 
            // btnNewTbl
            // 
            this.btnNewTbl.AutoSize = true;
            this.btnNewTbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnNewTbl.Location = new System.Drawing.Point(0, 3);
            this.btnNewTbl.Name = "btnNewTbl";
            this.btnNewTbl.Size = new System.Drawing.Size(131, 54);
            this.btnNewTbl.TabIndex = 0;
            this.btnNewTbl.Text = "Создать таблицу";
            this.btnNewTbl.UseVisualStyleBackColor = true;
            this.btnNewTbl.Click += new System.EventHandler(this.btnNewTbl_Click);
            // 
            // dgvTableInfo
            // 
            this.dgvTableInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTableInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTableInfo.Location = new System.Drawing.Point(0, 0);
            this.dgvTableInfo.Name = "dgvTableInfo";
            this.dgvTableInfo.ReadOnly = true;
            this.dgvTableInfo.Size = new System.Drawing.Size(464, 292);
            this.dgvTableInfo.TabIndex = 0;
            this.dgvTableInfo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTableInfo_CellClick);
            this.dgvTableInfo.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvTableInfo_DataBindingComplete);
            // 
            // btnRenameTbl
            // 
            this.btnRenameTbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRenameTbl.Location = new System.Drawing.Point(338, 4);
            this.btnRenameTbl.Name = "btnRenameTbl";
            this.btnRenameTbl.Size = new System.Drawing.Size(123, 54);
            this.btnRenameTbl.TabIndex = 3;
            this.btnRenameTbl.Text = "Переименовать таблицу";
            this.btnRenameTbl.UseVisualStyleBackColor = true;
            this.btnRenameTbl.Click += new System.EventHandler(this.btnRenameTbl_Click);
            // 
            // TablesEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 356);
            this.Controls.Add(this.splitContainer1);
            this.Name = "TablesEditorForm";
            this.Text = "Редактор таблиц";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TablesEditor_FormClosing);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTableInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListBox TablesList;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button btnSaveTbl;
        private System.Windows.Forms.Button btnDelTbl;
        private System.Windows.Forms.Button btnNewTbl;
        private System.Windows.Forms.DataGridView dgvTableInfo;
        private System.Windows.Forms.Button btnRenameTbl;
    }
}

