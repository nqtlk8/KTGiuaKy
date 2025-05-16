namespace KTGiuaKy
{
    partial class DislayTran
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.cId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cAcc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cDcrip = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cNote = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cId,
            this.cAcc,
            this.cTime,
            this.cDcrip,
            this.cNote});
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(21, 30);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(510, 329);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // cId
            // 
            this.cId.Text = "Mã giao dịch";
            // 
            // cAcc
            // 
            this.cAcc.Text = "Mã tài khoản";
            // 
            // cTime
            // 
            this.cTime.Text = "Thời gian";
            // 
            // cDcrip
            // 
            this.cDcrip.Text = "Mô tả";
            // 
            // cNote
            // 
            this.cNote.Text = "Ghi chú";
            // 
            // DislayTran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 371);
            this.Controls.Add(this.listView1);
            this.Name = "DislayTran";
            this.Text = "DislayTran";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader cId;
        private System.Windows.Forms.ColumnHeader cAcc;
        private System.Windows.Forms.ColumnHeader cTime;
        private System.Windows.Forms.ColumnHeader cDcrip;
        private System.Windows.Forms.ColumnHeader cNote;
    }
}