namespace Shop.Customers
{
    partial class FrmCustomersManager
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FrishBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.DgvCustomers = new System.Windows.Forms.DataGridView();
            this.Column1ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAccount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColumnDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SaveBtn);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtPhone);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Location = new System.Drawing.Point(12, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(681, 93);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "البــــانات الاساسية";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DgvCustomers);
            this.groupBox2.Location = new System.Drawing.Point(12, 140);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(681, 323);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "قــــــــائمة العــــملاء";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtName.Location = new System.Drawing.Point(367, 21);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(222, 22);
            this.txtName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(613, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "الاسم";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(314, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "العنوان";
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtAddress.Location = new System.Drawing.Point(19, 21);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(271, 22);
            this.txtAddress.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(613, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "التلفون";
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtPhone.Location = new System.Drawing.Point(367, 49);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(222, 22);
            this.txtPhone.TabIndex = 4;
            // 
            // SaveBtn
            // 
            this.SaveBtn.Image = global::Shop.Properties.Resources.page_save;
            this.SaveBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SaveBtn.Location = new System.Drawing.Point(19, 49);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(78, 38);
            this.SaveBtn.TabIndex = 6;
            this.SaveBtn.Text = "حــــــــفظ";
            this.SaveBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FrishBtn});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(705, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FrishBtn
            // 
            this.FrishBtn.Name = "FrishBtn";
            this.FrishBtn.Size = new System.Drawing.Size(125, 20);
            this.FrishBtn.Text = "تحــــــديث البـــــــــانات";
            this.FrishBtn.Click += new System.EventHandler(this.FrishBtn_Click);
            // 
            // DgvCustomers
            // 
            this.DgvCustomers.AllowUserToAddRows = false;
            this.DgvCustomers.BackgroundColor = System.Drawing.Color.White;
            this.DgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvCustomers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1ID,
            this.ColumnName,
            this.ColumnAddress,
            this.ColumnPhone,
            this.ColumnAccount,
            this.ColumnEdit,
            this.ColumnDelete});
            this.DgvCustomers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DgvCustomers.GridColor = System.Drawing.Color.Lime;
            this.DgvCustomers.Location = new System.Drawing.Point(19, 30);
            this.DgvCustomers.Name = "DgvCustomers";
            this.DgvCustomers.ReadOnly = true;
            this.DgvCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvCustomers.Size = new System.Drawing.Size(656, 271);
            this.DgvCustomers.TabIndex = 0;
            // 
            // Column1ID
            // 
            this.Column1ID.HeaderText = "ColumnID";
            this.Column1ID.Name = "Column1ID";
            this.Column1ID.ReadOnly = true;
            this.Column1ID.Visible = false;
            // 
            // ColumnName
            // 
            this.ColumnName.HeaderText = "الاسم";
            this.ColumnName.Name = "ColumnName";
            this.ColumnName.ReadOnly = true;
            // 
            // ColumnAddress
            // 
            this.ColumnAddress.HeaderText = "العنوان";
            this.ColumnAddress.Name = "ColumnAddress";
            this.ColumnAddress.ReadOnly = true;
            // 
            // ColumnPhone
            // 
            this.ColumnPhone.HeaderText = "التلفون";
            this.ColumnPhone.Name = "ColumnPhone";
            this.ColumnPhone.ReadOnly = true;
            // 
            // ColumnAccount
            // 
            this.ColumnAccount.HeaderText = "الحساب";
            this.ColumnAccount.Name = "ColumnAccount";
            this.ColumnAccount.ReadOnly = true;
            // 
            // ColumnEdit
            // 
            this.ColumnEdit.HeaderText = "";
            this.ColumnEdit.Name = "ColumnEdit";
            this.ColumnEdit.ReadOnly = true;
            this.ColumnEdit.Text = "تعديل";
            // 
            // ColumnDelete
            // 
            this.ColumnDelete.HeaderText = "";
            this.ColumnDelete.Name = "ColumnDelete";
            this.ColumnDelete.ReadOnly = true;
            this.ColumnDelete.Text = "حذف";
            // 
            // FrmCustomersManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(705, 487);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FrmCustomersManager";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmCustomersManager_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCustomers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FrishBtn;
        private System.Windows.Forms.DataGridView DgvCustomers;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAccount;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnEdit;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnDelete;
    }
}