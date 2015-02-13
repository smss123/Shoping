namespace Shop
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.الادارةToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UsersBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.EmployeesBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.SuppliersBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.CustomersBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.QuitBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.المشترياتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.أدارةالمشترياتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.أدرارةالمخازنللمشترياتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.الفواتيرToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripSeparator();
            this.StartTableBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.AddCategoriesBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.AddNewProductsBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.المبيعاتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.أدارةالمبيعاتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.أدارةالمخازنللمبيعاتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.الفواتيرToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.الحساباتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AccountsBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.DailyBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.StatisticesBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.الخدماتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.مفكرةتلفوناتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.الدفترToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.الحاسبةToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.DatabaseBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripSeparator();
            this.ShopBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.الادارةToolStripMenuItem,
            this.المشترياتToolStripMenuItem,
            this.المبيعاتToolStripMenuItem,
            this.الحساباتToolStripMenuItem,
            this.الخدماتToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(11, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(820, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // الادارةToolStripMenuItem
            // 
            this.الادارةToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UsersBtn,
            this.EmployeesBtn,
            this.SuppliersBtn,
            this.CustomersBtn,
            this.toolStripMenuItem1,
            this.QuitBtn});
            this.الادارةToolStripMenuItem.Name = "الادارةToolStripMenuItem";
            this.الادارةToolStripMenuItem.Size = new System.Drawing.Size(48, 19);
            this.الادارةToolStripMenuItem.Text = "الادارة";
            // 
            // UsersBtn
            // 
            this.UsersBtn.Name = "UsersBtn";
            this.UsersBtn.Size = new System.Drawing.Size(151, 22);
            this.UsersBtn.Text = "أدارة المستخدمين";
            this.UsersBtn.Click += new System.EventHandler(this.UsersBtn_Click);
            // 
            // EmployeesBtn
            // 
            this.EmployeesBtn.Name = "EmployeesBtn";
            this.EmployeesBtn.Size = new System.Drawing.Size(151, 22);
            this.EmployeesBtn.Text = "أدرارة الموظفين";
            this.EmployeesBtn.Click += new System.EventHandler(this.EmployeesBtn_Click);
            // 
            // SuppliersBtn
            // 
            this.SuppliersBtn.Name = "SuppliersBtn";
            this.SuppliersBtn.Size = new System.Drawing.Size(151, 22);
            this.SuppliersBtn.Text = "أدارة الموردين";
            this.SuppliersBtn.Click += new System.EventHandler(this.SuppliersBtn_Click);
            // 
            // CustomersBtn
            // 
            this.CustomersBtn.Name = "CustomersBtn";
            this.CustomersBtn.Size = new System.Drawing.Size(151, 22);
            this.CustomersBtn.Text = "أدارة العملاء";
            this.CustomersBtn.Click += new System.EventHandler(this.CustomersBtn_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(148, 6);
            // 
            // QuitBtn
            // 
            this.QuitBtn.Name = "QuitBtn";
            this.QuitBtn.Size = new System.Drawing.Size(151, 22);
            this.QuitBtn.Text = "أنهاء";
            this.QuitBtn.Click += new System.EventHandler(this.QuitBtn_Click);
            // 
            // المشترياتToolStripMenuItem
            // 
            this.المشترياتToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.أدارةالمشترياتToolStripMenuItem,
            this.أدرارةالمخازنللمشترياتToolStripMenuItem,
            this.toolStripMenuItem4,
            this.الفواتيرToolStripMenuItem,
            this.toolStripMenuItem7,
            this.StartTableBtn,
            this.AddCategoriesBtn,
            this.AddNewProductsBtn});
            this.المشترياتToolStripMenuItem.Name = "المشترياتToolStripMenuItem";
            this.المشترياتToolStripMenuItem.Size = new System.Drawing.Size(65, 19);
            this.المشترياتToolStripMenuItem.Text = "المشتريات";
            // 
            // أدارةالمشترياتToolStripMenuItem
            // 
            this.أدارةالمشترياتToolStripMenuItem.Name = "أدارةالمشترياتToolStripMenuItem";
            this.أدارةالمشترياتToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.أدارةالمشترياتToolStripMenuItem.Text = "أدارة المشتريات";
            // 
            // أدرارةالمخازنللمشترياتToolStripMenuItem
            // 
            this.أدرارةالمخازنللمشترياتToolStripMenuItem.Name = "أدرارةالمخازنللمشترياتToolStripMenuItem";
            this.أدرارةالمخازنللمشترياتToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.أدرارةالمخازنللمشترياتToolStripMenuItem.Text = "أدرارة المخازن للمشتريات";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(186, 6);
            // 
            // الفواتيرToolStripMenuItem
            // 
            this.الفواتيرToolStripMenuItem.Name = "الفواتيرToolStripMenuItem";
            this.الفواتيرToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.الفواتيرToolStripMenuItem.Text = "الفواتير";
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(186, 6);
            // 
            // StartTableBtn
            // 
            this.StartTableBtn.Name = "StartTableBtn";
            this.StartTableBtn.Size = new System.Drawing.Size(189, 22);
            this.StartTableBtn.Text = "بضاعه أول المده";
            this.StartTableBtn.Click += new System.EventHandler(this.StartTableBtn_Click);
            // 
            // AddCategoriesBtn
            // 
            this.AddCategoriesBtn.Name = "AddCategoriesBtn";
            this.AddCategoriesBtn.Size = new System.Drawing.Size(189, 22);
            this.AddCategoriesBtn.Text = "أدارة المنتجات";
            this.AddCategoriesBtn.Click += new System.EventHandler(this.AddCategoriesBtn_Click);
            // 
            // AddNewProductsBtn
            // 
            this.AddNewProductsBtn.Name = "AddNewProductsBtn";
            this.AddNewProductsBtn.Size = new System.Drawing.Size(189, 22);
            this.AddNewProductsBtn.Text = "أدارة التصنيفات";
            this.AddNewProductsBtn.Click += new System.EventHandler(this.AddNewProductsBtn_Click);
            // 
            // المبيعاتToolStripMenuItem
            // 
            this.المبيعاتToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.أدارةالمبيعاتToolStripMenuItem,
            this.أدارةالمخازنللمبيعاتToolStripMenuItem,
            this.toolStripMenuItem5,
            this.الفواتيرToolStripMenuItem1});
            this.المبيعاتToolStripMenuItem.Name = "المبيعاتToolStripMenuItem";
            this.المبيعاتToolStripMenuItem.Size = new System.Drawing.Size(55, 19);
            this.المبيعاتToolStripMenuItem.Text = "المبيعات";
            // 
            // أدارةالمبيعاتToolStripMenuItem
            // 
            this.أدارةالمبيعاتToolStripMenuItem.Name = "أدارةالمبيعاتToolStripMenuItem";
            this.أدارةالمبيعاتToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.أدارةالمبيعاتToolStripMenuItem.Text = "أدارة المبيعات";
            // 
            // أدارةالمخازنللمبيعاتToolStripMenuItem
            // 
            this.أدارةالمخازنللمبيعاتToolStripMenuItem.Name = "أدارةالمخازنللمبيعاتToolStripMenuItem";
            this.أدارةالمخازنللمبيعاتToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.أدارةالمخازنللمبيعاتToolStripMenuItem.Text = "أدارة المخازن للمبيعات";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(170, 6);
            // 
            // الفواتيرToolStripMenuItem1
            // 
            this.الفواتيرToolStripMenuItem1.Name = "الفواتيرToolStripMenuItem1";
            this.الفواتيرToolStripMenuItem1.Size = new System.Drawing.Size(173, 22);
            this.الفواتيرToolStripMenuItem1.Text = "الفواتير";
            // 
            // الحساباتToolStripMenuItem
            // 
            this.الحساباتToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AccountsBtn,
            this.DailyBtn,
            this.toolStripMenuItem3,
            this.StatisticesBtn});
            this.الحساباتToolStripMenuItem.Name = "الحساباتToolStripMenuItem";
            this.الحساباتToolStripMenuItem.Size = new System.Drawing.Size(61, 19);
            this.الحساباتToolStripMenuItem.Text = "الحسابات";
            // 
            // AccountsBtn
            // 
            this.AccountsBtn.Name = "AccountsBtn";
            this.AccountsBtn.Size = new System.Drawing.Size(152, 22);
            this.AccountsBtn.Text = "أدارة الحسابات";
            this.AccountsBtn.Click += new System.EventHandler(this.AccountsBtn_Click);
            // 
            // DailyBtn
            // 
            this.DailyBtn.Name = "DailyBtn";
            this.DailyBtn.Size = new System.Drawing.Size(152, 22);
            this.DailyBtn.Text = "الحسابات اليومية";
            this.DailyBtn.Click += new System.EventHandler(this.DailyBtn_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(149, 6);
            // 
            // StatisticesBtn
            // 
            this.StatisticesBtn.Name = "StatisticesBtn";
            this.StatisticesBtn.Size = new System.Drawing.Size(152, 22);
            this.StatisticesBtn.Text = "ميزان المراجعه";
            // 
            // الخدماتToolStripMenuItem
            // 
            this.الخدماتToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.مفكرةتلفوناتToolStripMenuItem,
            this.الدفترToolStripMenuItem,
            this.الحاسبةToolStripMenuItem,
            this.toolStripMenuItem2,
            this.DatabaseBtn,
            this.toolStripMenuItem6,
            this.ShopBtn});
            this.الخدماتToolStripMenuItem.Name = "الخدماتToolStripMenuItem";
            this.الخدماتToolStripMenuItem.Size = new System.Drawing.Size(54, 19);
            this.الخدماتToolStripMenuItem.Text = "الخدمات";
            // 
            // مفكرةتلفوناتToolStripMenuItem
            // 
            this.مفكرةتلفوناتToolStripMenuItem.Name = "مفكرةتلفوناتToolStripMenuItem";
            this.مفكرةتلفوناتToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.مفكرةتلفوناتToolStripMenuItem.Text = "مفكرة تلفونات";
            // 
            // الدفترToolStripMenuItem
            // 
            this.الدفترToolStripMenuItem.Name = "الدفترToolStripMenuItem";
            this.الدفترToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.الدفترToolStripMenuItem.Text = "الدفتر";
            // 
            // الحاسبةToolStripMenuItem
            // 
            this.الحاسبةToolStripMenuItem.Name = "الحاسبةToolStripMenuItem";
            this.الحاسبةToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.الحاسبةToolStripMenuItem.Text = "الحاسبة";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(169, 6);
            // 
            // DatabaseBtn
            // 
            this.DatabaseBtn.Name = "DatabaseBtn";
            this.DatabaseBtn.Size = new System.Drawing.Size(172, 22);
            this.DatabaseBtn.Text = "مراقــــــبة البـــــيانات";
            this.DatabaseBtn.Click += new System.EventHandler(this.DatabaseBtn_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(169, 6);
            // 
            // ShopBtn
            // 
            this.ShopBtn.Name = "ShopBtn";
            this.ShopBtn.Size = new System.Drawing.Size(172, 22);
            this.ShopBtn.Text = "البـــــانات الخاصة";
            this.ShopBtn.Click += new System.EventHandler(this.ShopBtn_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.statusStrip1.Location = new System.Drawing.Point(0, 553);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(26, 0, 1, 0);
            this.statusStrip1.Size = new System.Drawing.Size(820, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(820, 575);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem الادارةToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UsersBtn;
        private System.Windows.Forms.ToolStripMenuItem EmployeesBtn;
        private System.Windows.Forms.ToolStripMenuItem SuppliersBtn;
        private System.Windows.Forms.ToolStripMenuItem CustomersBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem QuitBtn;
        private System.Windows.Forms.ToolStripMenuItem المشترياتToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem أدارةالمشترياتToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem أدرارةالمخازنللمشترياتToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem المبيعاتToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem أدارةالمبيعاتToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem أدارةالمخازنللمبيعاتToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem الحساباتToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AccountsBtn;
        private System.Windows.Forms.ToolStripMenuItem DailyBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem الخدماتToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem مفكرةتلفوناتToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem الدفترToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem الحاسبةToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem DatabaseBtn;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem StatisticesBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem الفواتيرToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem الفواتيرToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem ShopBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem StartTableBtn;
        private System.Windows.Forms.ToolStripMenuItem AddCategoriesBtn;
        private System.Windows.Forms.ToolStripMenuItem AddNewProductsBtn;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}