namespace Shop.Accountant
{
    partial class FrmAccountsManager
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAccountsManager));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ExpandeAllBtn = new System.Windows.Forms.Button();
            this.CollapseBtn = new System.Windows.Forms.Button();
            this.TreeAccounts = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.txtAccountName = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtStatusAccountName = new System.Windows.Forms.TextBox();
            this.AccountCategoryBtn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FrishBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.DgvAccountDaily = new System.Windows.Forms.DataGridView();
            this.ColumnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAccountID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTotalIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTotalOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAccountDaily)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ExpandeAllBtn);
            this.groupBox1.Controls.Add(this.CollapseBtn);
            this.groupBox1.Controls.Add(this.TreeAccounts);
            this.groupBox1.Location = new System.Drawing.Point(12, 142);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(303, 297);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "شجرة الحسابات";
            // 
            // ExpandeAllBtn
            // 
            this.ExpandeAllBtn.Location = new System.Drawing.Point(174, 260);
            this.ExpandeAllBtn.Name = "ExpandeAllBtn";
            this.ExpandeAllBtn.Size = new System.Drawing.Size(119, 23);
            this.ExpandeAllBtn.TabIndex = 2;
            this.ExpandeAllBtn.Text = "فتــح";
            this.ExpandeAllBtn.UseVisualStyleBackColor = true;
            this.ExpandeAllBtn.Click += new System.EventHandler(this.ExpandeAllBtn_Click);
            // 
            // CollapseBtn
            // 
            this.CollapseBtn.Location = new System.Drawing.Point(18, 260);
            this.CollapseBtn.Name = "CollapseBtn";
            this.CollapseBtn.Size = new System.Drawing.Size(119, 23);
            this.CollapseBtn.TabIndex = 1;
            this.CollapseBtn.Text = "طي";
            this.CollapseBtn.UseVisualStyleBackColor = true;
            this.CollapseBtn.Click += new System.EventHandler(this.CollapseBtn_Click);
            // 
            // TreeAccounts
            // 
            this.TreeAccounts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TreeAccounts.FullRowSelect = true;
            this.TreeAccounts.Location = new System.Drawing.Point(18, 15);
            this.TreeAccounts.Name = "TreeAccounts";
            this.TreeAccounts.RightToLeftLayout = true;
            this.TreeAccounts.Size = new System.Drawing.Size(275, 239);
            this.TreeAccounts.TabIndex = 0;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "home.png");
            this.imageList1.Images.SetKeyName(1, "feed.png");
            this.imageList1.Images.SetKeyName(2, "featured.png");
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtDescription);
            this.groupBox2.Controls.Add(this.SaveBtn);
            this.groupBox2.Controls.Add(this.txtAccountName);
            this.groupBox2.Location = new System.Drawing.Point(22, 36);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(470, 100);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "أضافة حساب الى التصنيفات الاخرى";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(415, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "الوصف";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(401, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "اسم الحساب";
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtDescription.Location = new System.Drawing.Point(117, 55);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(278, 38);
            this.txtDescription.TabIndex = 8;
            // 
            // SaveBtn
            // 
            this.SaveBtn.Image = global::Shop.Properties.Resources.page_save;
            this.SaveBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SaveBtn.Location = new System.Drawing.Point(18, 21);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(93, 66);
            this.SaveBtn.TabIndex = 6;
            this.SaveBtn.Text = "حــــفط";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // txtAccountName
            // 
            this.txtAccountName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtAccountName.Location = new System.Drawing.Point(117, 21);
            this.txtAccountName.Name = "txtAccountName";
            this.txtAccountName.Size = new System.Drawing.Size(278, 22);
            this.txtAccountName.TabIndex = 7;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtBalance);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtStatusAccountName);
            this.groupBox3.Location = new System.Drawing.Point(512, 36);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(400, 90);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "تفــــــــاصيل الحســـاب";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(315, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "الرصـــــيد";
            // 
            // txtBalance
            // 
            this.txtBalance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtBalance.Location = new System.Drawing.Point(31, 55);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.ReadOnly = true;
            this.txtBalance.Size = new System.Drawing.Size(278, 22);
            this.txtBalance.TabIndex = 12;
            this.txtBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(315, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "اسم الحساب";
            // 
            // txtStatusAccountName
            // 
            this.txtStatusAccountName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtStatusAccountName.Location = new System.Drawing.Point(31, 24);
            this.txtStatusAccountName.Name = "txtStatusAccountName";
            this.txtStatusAccountName.ReadOnly = true;
            this.txtStatusAccountName.Size = new System.Drawing.Size(278, 22);
            this.txtStatusAccountName.TabIndex = 10;
            this.txtStatusAccountName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AccountCategoryBtn
            // 
            this.AccountCategoryBtn.Location = new System.Drawing.Point(765, 412);
            this.AccountCategoryBtn.Name = "AccountCategoryBtn";
            this.AccountCategoryBtn.Size = new System.Drawing.Size(147, 38);
            this.AccountCategoryBtn.TabIndex = 10;
            this.AccountCategoryBtn.Text = "أضافة تصنيفات جديدة";
            this.AccountCategoryBtn.UseVisualStyleBackColor = true;
            this.AccountCategoryBtn.Click += new System.EventHandler(this.AccountCategoryBtn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FrishBtn});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(924, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FrishBtn
            // 
            this.FrishBtn.Name = "FrishBtn";
            this.FrishBtn.Size = new System.Drawing.Size(99, 20);
            this.FrishBtn.Text = "تحــــديث البـيانات";
            this.FrishBtn.Click += new System.EventHandler(this.FrishBtn_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.DgvAccountDaily);
            this.groupBox4.Location = new System.Drawing.Point(333, 157);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(579, 249);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            // 
            // DgvAccountDaily
            // 
            this.DgvAccountDaily.AllowUserToAddRows = false;
            this.DgvAccountDaily.BackgroundColor = System.Drawing.Color.White;
            this.DgvAccountDaily.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvAccountDaily.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnID,
            this.ColumnAccountID,
            this.ColumnTotalIn,
            this.ColumnTotalOut,
            this.ColumnDescription,
            this.ColumnDate});
            this.DgvAccountDaily.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DgvAccountDaily.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DgvAccountDaily.Location = new System.Drawing.Point(6, 25);
            this.DgvAccountDaily.Name = "DgvAccountDaily";
            this.DgvAccountDaily.ReadOnly = true;
            this.DgvAccountDaily.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvAccountDaily.Size = new System.Drawing.Size(555, 214);
            this.DgvAccountDaily.TabIndex = 0;
            // 
            // ColumnID
            // 
            this.ColumnID.HeaderText = "Column1";
            this.ColumnID.Name = "ColumnID";
            this.ColumnID.ReadOnly = true;
            this.ColumnID.Visible = false;
            // 
            // ColumnAccountID
            // 
            this.ColumnAccountID.HeaderText = "الحساب";
            this.ColumnAccountID.Name = "ColumnAccountID";
            this.ColumnAccountID.ReadOnly = true;
            this.ColumnAccountID.Width = 190;
            // 
            // ColumnTotalIn
            // 
            this.ColumnTotalIn.HeaderText = "دخل ";
            this.ColumnTotalIn.Name = "ColumnTotalIn";
            this.ColumnTotalIn.ReadOnly = true;
            this.ColumnTotalIn.Width = 80;
            // 
            // ColumnTotalOut
            // 
            this.ColumnTotalOut.HeaderText = "خرج ";
            this.ColumnTotalOut.Name = "ColumnTotalOut";
            this.ColumnTotalOut.ReadOnly = true;
            this.ColumnTotalOut.Width = 80;
            // 
            // ColumnDescription
            // 
            this.ColumnDescription.HeaderText = "البيان";
            this.ColumnDescription.Name = "ColumnDescription";
            this.ColumnDescription.ReadOnly = true;
            this.ColumnDescription.Width = 180;
            // 
            // ColumnDate
            // 
            this.ColumnDate.HeaderText = "التاريخ";
            this.ColumnDate.Name = "ColumnDate";
            this.ColumnDate.ReadOnly = true;
            // 
            // FrmAccountsManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(924, 462);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.AccountCategoryBtn);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FrmAccountsManager";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmAccountsManager_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvAccountDaily)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TreeView TreeAccounts;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.TextBox txtAccountName;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtStatusAccountName;
        private System.Windows.Forms.Button AccountCategoryBtn;
        private System.Windows.Forms.Button ExpandeAllBtn;
        private System.Windows.Forms.Button CollapseBtn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FrishBtn;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView DgvAccountDaily;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAccountID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTotalIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTotalOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDate;
    }
}