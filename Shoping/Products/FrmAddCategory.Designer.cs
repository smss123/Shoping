namespace Shop.Accountant
{
    partial class FrmAddCategory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddCategory));
            this.GroupAdd = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtCategoryName = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CollapseAllBtn = new System.Windows.Forms.Button();
            this.ExpanedAllBtn = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.GroupEdit = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.EditBtn = new System.Windows.Forms.Button();
            this.txtEditDescription = new System.Windows.Forms.TextBox();
            this.txtEditName = new System.Windows.Forms.TextBox();
            this.DgvCategories = new System.Windows.Forms.DataGridView();
            this.ColID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.GroupAdd.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.GroupEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCategories)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupAdd
            // 
            this.GroupAdd.Controls.Add(this.label2);
            this.GroupAdd.Controls.Add(this.label1);
            this.GroupAdd.Controls.Add(this.SaveBtn);
            this.GroupAdd.Controls.Add(this.txtDescription);
            this.GroupAdd.Controls.Add(this.txtCategoryName);
            this.GroupAdd.Location = new System.Drawing.Point(14, 3);
            this.GroupAdd.Name = "GroupAdd";
            this.GroupAdd.Size = new System.Drawing.Size(333, 125);
            this.GroupAdd.TabIndex = 0;
            this.GroupAdd.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(249, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "الوصف";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(243, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "التصنيف";
            // 
            // SaveBtn
            // 
            this.SaveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveBtn.Image = global::Shop.Properties.Resources.page_save;
            this.SaveBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SaveBtn.Location = new System.Drawing.Point(21, 80);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(204, 33);
            this.SaveBtn.TabIndex = 2;
            this.SaveBtn.Text = "جفظ";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtDescription.Location = new System.Drawing.Point(21, 47);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtDescription.Size = new System.Drawing.Size(204, 27);
            this.txtDescription.TabIndex = 1;
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtCategoryName.Location = new System.Drawing.Point(21, 19);
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtCategoryName.Size = new System.Drawing.Size(204, 22);
            this.txtCategoryName.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CollapseAllBtn);
            this.groupBox2.Controls.Add(this.ExpanedAllBtn);
            this.groupBox2.Controls.Add(this.treeView1);
            this.groupBox2.Location = new System.Drawing.Point(14, 134);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(333, 162);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // CollapseAllBtn
            // 
            this.CollapseAllBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CollapseAllBtn.Image = global::Shop.Properties.Resources.upcoming_work;
            this.CollapseAllBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CollapseAllBtn.Location = new System.Drawing.Point(13, 123);
            this.CollapseAllBtn.Name = "CollapseAllBtn";
            this.CollapseAllBtn.Size = new System.Drawing.Size(145, 33);
            this.CollapseAllBtn.TabIndex = 2;
            this.CollapseAllBtn.Text = "أخفاء الكل";
            this.CollapseAllBtn.UseVisualStyleBackColor = true;
            this.CollapseAllBtn.Click += new System.EventHandler(this.CollapseAllBtn_Click);
            // 
            // ExpanedAllBtn
            // 
            this.ExpanedAllBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExpanedAllBtn.Image = global::Shop.Properties.Resources.category;
            this.ExpanedAllBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ExpanedAllBtn.Location = new System.Drawing.Point(164, 123);
            this.ExpanedAllBtn.Name = "ExpanedAllBtn";
            this.ExpanedAllBtn.Size = new System.Drawing.Size(145, 33);
            this.ExpanedAllBtn.TabIndex = 1;
            this.ExpanedAllBtn.Text = "أظهار الكل";
            this.ExpanedAllBtn.UseVisualStyleBackColor = true;
            this.ExpanedAllBtn.Click += new System.EventHandler(this.ExpanedAllBtn_Click);
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.treeView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.treeView1.Location = new System.Drawing.Point(13, 22);
            this.treeView1.Name = "treeView1";
            this.treeView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.treeView1.RightToLeftLayout = true;
            this.treeView1.Size = new System.Drawing.Size(296, 95);
            this.treeView1.TabIndex = 0;
            this.treeView1.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseDoubleClick);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Delicious.ico");
            this.imageList1.Images.SetKeyName(1, "RSS reader.ico");
            this.imageList1.Images.SetKeyName(2, "Stumbleupon.ico");
            // 
            // GroupEdit
            // 
            this.GroupEdit.Controls.Add(this.label3);
            this.GroupEdit.Controls.Add(this.label4);
            this.GroupEdit.Controls.Add(this.EditBtn);
            this.GroupEdit.Controls.Add(this.txtEditDescription);
            this.GroupEdit.Controls.Add(this.txtEditName);
            this.GroupEdit.Location = new System.Drawing.Point(20, 302);
            this.GroupEdit.Name = "GroupEdit";
            this.GroupEdit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.GroupEdit.Size = new System.Drawing.Size(327, 125);
            this.GroupEdit.TabIndex = 2;
            this.GroupEdit.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(238, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "الوصف";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(232, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "التصنيف";
            // 
            // EditBtn
            // 
            this.EditBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EditBtn.Image = global::Shop.Properties.Resources.config;
            this.EditBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.EditBtn.Location = new System.Drawing.Point(22, 81);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(204, 33);
            this.EditBtn.TabIndex = 7;
            this.EditBtn.Text = "تعديل";
            this.EditBtn.UseVisualStyleBackColor = true;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // txtEditDescription
            // 
            this.txtEditDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtEditDescription.Location = new System.Drawing.Point(22, 47);
            this.txtEditDescription.Multiline = true;
            this.txtEditDescription.Name = "txtEditDescription";
            this.txtEditDescription.Size = new System.Drawing.Size(204, 27);
            this.txtEditDescription.TabIndex = 6;
            // 
            // txtEditName
            // 
            this.txtEditName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtEditName.Location = new System.Drawing.Point(22, 19);
            this.txtEditName.Name = "txtEditName";
            this.txtEditName.Size = new System.Drawing.Size(204, 22);
            this.txtEditName.TabIndex = 5;
            // 
            // DgvCategories
            // 
            this.DgvCategories.AllowUserToAddRows = false;
            this.DgvCategories.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.DgvCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvCategories.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColID,
            this.ColName,
            this.ColDelete,
            this.ColEdit});
            this.DgvCategories.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DgvCategories.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.DgvCategories.Location = new System.Drawing.Point(353, 12);
            this.DgvCategories.Name = "DgvCategories";
            this.DgvCategories.ReadOnly = true;
            this.DgvCategories.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DgvCategories.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvCategories.Size = new System.Drawing.Size(377, 411);
            this.DgvCategories.TabIndex = 3;
            this.DgvCategories.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvCategories_CellClick);
            // 
            // ColID
            // 
            this.ColID.HeaderText = "ID";
            this.ColID.Name = "ColID";
            this.ColID.ReadOnly = true;
            this.ColID.Visible = false;
            this.ColID.Width = 150;
            // 
            // ColName
            // 
            this.ColName.HeaderText = "التصنيف";
            this.ColName.Name = "ColName";
            this.ColName.ReadOnly = true;
            this.ColName.Width = 170;
            // 
            // ColDelete
            // 
            this.ColDelete.HeaderText = "";
            this.ColDelete.Name = "ColDelete";
            this.ColDelete.ReadOnly = true;
            this.ColDelete.Text = "حذف";
            this.ColDelete.UseColumnTextForButtonValue = true;
            this.ColDelete.Width = 50;
            // 
            // ColEdit
            // 
            this.ColEdit.HeaderText = "";
            this.ColEdit.Name = "ColEdit";
            this.ColEdit.ReadOnly = true;
            this.ColEdit.Text = "تعديل";
            this.ColEdit.UseColumnTextForButtonValue = true;
            // 
            // FrmAddCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(742, 435);
            this.Controls.Add(this.DgvCategories);
            this.Controls.Add(this.GroupEdit);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.GroupAdd);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmAddCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmAddCategory_Load);
            this.GroupAdd.ResumeLayout(false);
            this.GroupAdd.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.GroupEdit.ResumeLayout(false);
            this.GroupEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCategories)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupAdd;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtCategoryName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button CollapseAllBtn;
        private System.Windows.Forms.Button ExpanedAllBtn;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.GroupBox GroupEdit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.TextBox txtEditDescription;
        private System.Windows.Forms.TextBox txtEditName;
        private System.Windows.Forms.DataGridView DgvCategories;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColName;
        private System.Windows.Forms.DataGridViewButtonColumn ColDelete;
        private System.Windows.Forms.DataGridViewButtonColumn ColEdit;
    }
}