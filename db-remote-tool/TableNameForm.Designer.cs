namespace db_remote_tool
{
    partial class TableNameForm
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
            this.lbTblName = new System.Windows.Forms.Label();
            this.tbTblName = new System.Windows.Forms.TextBox();
            this.btnTblName = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbTblName
            // 
            this.lbTblName.AutoSize = true;
            this.lbTblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbTblName.Location = new System.Drawing.Point(12, 22);
            this.lbTblName.Name = "lbTblName";
            this.lbTblName.Size = new System.Drawing.Size(242, 22);
            this.lbTblName.TabIndex = 0;
            this.lbTblName.Text = "Введите название таблицы";
            // 
            // tbTblName
            // 
            this.tbTblName.Location = new System.Drawing.Point(29, 66);
            this.tbTblName.Name = "tbTblName";
            this.tbTblName.Size = new System.Drawing.Size(209, 20);
            this.tbTblName.TabIndex = 1;
            // 
            // btnTblName
            // 
            this.btnTblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTblName.Location = new System.Drawing.Point(82, 113);
            this.btnTblName.Name = "btnTblName";
            this.btnTblName.Size = new System.Drawing.Size(99, 23);
            this.btnTblName.TabIndex = 2;
            this.btnTblName.Text = "ОК";
            this.btnTblName.UseVisualStyleBackColor = true;
            this.btnTblName.Click += new System.EventHandler(this.btnCreateTblName_Click);
            // 
            // NewTableForm
            // 
            this.AcceptButton = this.btnTblName;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 158);
            this.Controls.Add(this.btnTblName);
            this.Controls.Add(this.tbTblName);
            this.Controls.Add(this.lbTblName);
            this.Name = "NewTableForm";
            this.Text = "Название таблицы";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTblName;
        private System.Windows.Forms.TextBox tbTblName;
        private System.Windows.Forms.Button btnTblName;
    }
}