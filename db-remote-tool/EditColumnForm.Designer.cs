namespace db_remote_tool
{
    partial class EditColumnForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbColName = new System.Windows.Forms.TextBox();
            this.lblColName = new System.Windows.Forms.Label();
            this.lblColType = new System.Windows.Forms.Label();
            this.cmbColType = new System.Windows.Forms.ComboBox();
            this.lblColPk = new System.Windows.Forms.Label();
            this.btnEditConfirm = new System.Windows.Forms.Button();
            this.cbColPk = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // tbColName
            // 
            this.tbColName.Location = new System.Drawing.Point(12, 25);
            this.tbColName.Name = "tbColName";
            this.tbColName.Size = new System.Drawing.Size(100, 20);
            this.tbColName.TabIndex = 0;
            // 
            // lblColName
            // 
            this.lblColName.AutoSize = true;
            this.lblColName.Location = new System.Drawing.Point(33, 9);
            this.lblColName.Name = "lblColName";
            this.lblColName.Size = new System.Drawing.Size(57, 13);
            this.lblColName.TabIndex = 1;
            this.lblColName.Text = "Название";
            // 
            // lblColType
            // 
            this.lblColType.AutoSize = true;
            this.lblColType.Location = new System.Drawing.Point(140, 9);
            this.lblColType.Name = "lblColType";
            this.lblColType.Size = new System.Drawing.Size(66, 13);
            this.lblColType.TabIndex = 3;
            this.lblColType.Text = "Тип данных";
            // 
            // cmbColType
            // 
            this.cmbColType.FormattingEnabled = true;
            this.cmbColType.Items.AddRange(new object[] {
            "INTEGER",
            "TEXT",
            "DATE",
            "DOUBLE",
            "BOOLEAN"});
            this.cmbColType.Location = new System.Drawing.Point(118, 24);
            this.cmbColType.Name = "cmbColType";
            this.cmbColType.Size = new System.Drawing.Size(121, 21);
            this.cmbColType.TabIndex = 4;
            // 
            // lblColPk
            // 
            this.lblColPk.AutoSize = true;
            this.lblColPk.Location = new System.Drawing.Point(257, 9);
            this.lblColPk.Name = "lblColPk";
            this.lblColPk.Size = new System.Drawing.Size(92, 13);
            this.lblColPk.TabIndex = 5;
            this.lblColPk.Text = "Первичный ключ";
            // 
            // btnEditConfirm
            // 
            this.btnEditConfirm.Location = new System.Drawing.Point(143, 50);
            this.btnEditConfirm.Name = "btnEditConfirm";
            this.btnEditConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnEditConfirm.TabIndex = 7;
            this.btnEditConfirm.Text = "ОК";
            this.btnEditConfirm.UseVisualStyleBackColor = true;
            this.btnEditConfirm.Click += new System.EventHandler(this.btnEditConfirm_Click);
            // 
            // cbColPk
            // 
            this.cbColPk.AutoSize = true;
            this.cbColPk.Location = new System.Drawing.Point(293, 28);
            this.cbColPk.Name = "cbColPk";
            this.cbColPk.Size = new System.Drawing.Size(15, 14);
            this.cbColPk.TabIndex = 8;
            this.cbColPk.UseVisualStyleBackColor = true;
            // 
            // EditColumnForm
            // 
            this.AcceptButton = this.btnEditConfirm;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 85);
            this.Controls.Add(this.cbColPk);
            this.Controls.Add(this.btnEditConfirm);
            this.Controls.Add(this.lblColPk);
            this.Controls.Add(this.cmbColType);
            this.Controls.Add(this.lblColType);
            this.Controls.Add(this.lblColName);
            this.Controls.Add(this.tbColName);
            this.Name = "EditColumnForm";
            this.Text = "Изменение столбца";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbColName;
        private System.Windows.Forms.Label lblColName;
        private System.Windows.Forms.Label lblColType;
        private System.Windows.Forms.ComboBox cmbColType;
        private System.Windows.Forms.Label lblColPk;
        private System.Windows.Forms.Button btnEditConfirm;
        private System.Windows.Forms.CheckBox cbColPk;
    }
}