namespace Shop.Products
{
    partial class FrmProductsManager
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.AddNewProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.FrishBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.DgvProducts = new System.Windows.Forms.DataGridView();
            this.ColID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDescrip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DgvProducts);
            this.groupBox1.Location = new System.Drawing.Point(12, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(566, 368);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "قـــــــــائمة المنتجــــــــات الموجــــــوده";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddNewProduct,
            this.FrishBtn});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(599, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // AddNewProduct
            // 
            this.AddNewProduct.Name = "AddNewProduct";
            this.AddNewProduct.Size = new System.Drawing.Size(138, 20);
            this.AddNewProduct.Text = "أضــــــــافة منـــج جـــــديد";
            this.AddNewProduct.Click += new System.EventHandler(this.AddNewProduct_Click);
            // 
            // FrishBtn
            // 
            this.FrishBtn.Name = "FrishBtn";
            this.FrishBtn.Size = new System.Drawing.Size(141, 20);
            this.FrishBtn.Text = "تحــــــــــديث البـــــــــيانات";
            this.FrishBtn.Click += new System.EventHandler(this.FrishBtn_Click);
            // 
            // DgvProducts
            // 
            this.DgvProducts.AllowUserToAddRows = false;
            this.DgvProducts.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.DgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColID,
            this.ColProduct,
            this.ColDescrip,
            this.ColEdit,
            this.ColDelete});
            this.DgvProducts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DgvProducts.GridColor = System.Drawing.Color.Fuchsia;
            this.DgvProducts.Location = new System.Drawing.Point(6, 21);
            this.DgvProducts.Name = "DgvProducts";
            this.DgvProducts.ReadOnly = true;
            this.DgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvProducts.Size = new System.Drawing.Size(541, 326);
            this.DgvProducts.TabIndex = 0;
            this.DgvProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvProducts_CellClick);
            // 
            // ColID
            // 
            this.ColID.HeaderText = "ID";
            this.ColID.Name = "ColID";
            this.ColID.ReadOnly = true;
            this.ColID.Visible = false;
            // 
            // ColProduct
            // 
            this.ColProduct.HeaderText = "المنتج";
            this.ColProduct.Name = "ColProduct";
            this.ColProduct.ReadOnly = true;
            this.ColProduct.Width = 190;
            // 
            // ColDescrip
            // 
            this.ColDescrip.HeaderText = "الوصف";
            this.ColDescrip.Name = "ColDescrip";
            this.ColDescrip.ReadOnly = true;
            this.ColDescrip.Width = 190;
            // 
            // ColEdit
            // 
            this.ColEdit.HeaderText = "";
            this.ColEdit.Name = "ColEdit";
            this.ColEdit.ReadOnly = true;
            this.ColEdit.Text = "تعديل";
            this.ColEdit.UseColumnTextForButtonValue = true;
            this.ColEdit.Width = 50;
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
            // FrmProductsManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(599, 442);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FrmProductsManager";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmProductsManager_Load);
            this.groupBox1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem AddNewProduct;
        private System.Windows.Forms.ToolStripMenuItem FrishBtn;
        private System.Windows.Forms.DataGridView DgvProducts;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDescrip;
        private System.Windows.Forms.DataGridViewButtonColumn ColEdit;
        private System.Windows.Forms.DataGridViewButtonColumn ColDelete;
    }
}