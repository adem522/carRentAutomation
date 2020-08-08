namespace csharpProje1
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.MenuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.RentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.CarsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CarCategorysToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rentalInvoiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ınvoicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.EquipmentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EquipmentCategoriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DepartmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DepartmentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StaffsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.InsuranceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.InsuranceToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.PolicysToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.directionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrip1
            // 
            this.MenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem4,
            this.ToolStripMenuItem1,
            this.ToolStripMenuItem2,
            this.rentalInvoiceToolStripMenuItem,
            this.ToolStripMenuItem3,
            this.DepartmentToolStripMenuItem,
            this.InsuranceToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.MenuStrip1.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip1.Name = "MenuStrip1";
            this.MenuStrip1.Size = new System.Drawing.Size(800, 24);
            this.MenuStrip1.TabIndex = 2;
            this.MenuStrip1.Text = "MenuStrip1";
            // 
            // ToolStripMenuItem4
            // 
            this.ToolStripMenuItem4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RentsToolStripMenuItem});
            this.ToolStripMenuItem4.Name = "ToolStripMenuItem4";
            this.ToolStripMenuItem4.Size = new System.Drawing.Size(43, 20);
            this.ToolStripMenuItem4.Text = "Rent";
            // 
            // RentsToolStripMenuItem
            // 
            this.RentsToolStripMenuItem.ForeColor = System.Drawing.Color.Lime;
            this.RentsToolStripMenuItem.Name = "RentsToolStripMenuItem";
            this.RentsToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.RentsToolStripMenuItem.Text = "Rents";
            this.RentsToolStripMenuItem.Click += new System.EventHandler(this.RentsToolStripMenuItem_Click);
            // 
            // ToolStripMenuItem1
            // 
            this.ToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem5});
            this.ToolStripMenuItem1.Name = "ToolStripMenuItem1";
            this.ToolStripMenuItem1.Size = new System.Drawing.Size(71, 20);
            this.ToolStripMenuItem1.Text = "Customer";
            // 
            // ToolStripMenuItem5
            // 
            this.ToolStripMenuItem5.ForeColor = System.Drawing.Color.Lime;
            this.ToolStripMenuItem5.Name = "ToolStripMenuItem5";
            this.ToolStripMenuItem5.Size = new System.Drawing.Size(131, 22);
            this.ToolStripMenuItem5.Text = "Customers";
            this.ToolStripMenuItem5.Click += new System.EventHandler(this.ToolStripMenuItem5_Click);
            // 
            // ToolStripMenuItem2
            // 
            this.ToolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CarsToolStripMenuItem,
            this.CarCategorysToolStripMenuItem});
            this.ToolStripMenuItem2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ToolStripMenuItem2.Name = "ToolStripMenuItem2";
            this.ToolStripMenuItem2.Size = new System.Drawing.Size(37, 20);
            this.ToolStripMenuItem2.Text = "Car";
            // 
            // CarsToolStripMenuItem
            // 
            this.CarsToolStripMenuItem.ForeColor = System.Drawing.Color.Lime;
            this.CarsToolStripMenuItem.Name = "CarsToolStripMenuItem";
            this.CarsToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.CarsToolStripMenuItem.Text = "Cars";
            this.CarsToolStripMenuItem.Click += new System.EventHandler(this.CarsToolStripMenuItem_Click);
            // 
            // CarCategorysToolStripMenuItem
            // 
            this.CarCategorysToolStripMenuItem.Name = "CarCategorysToolStripMenuItem";
            this.CarCategorysToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.CarCategorysToolStripMenuItem.Text = "Car Categories";
            // 
            // rentalInvoiceToolStripMenuItem
            // 
            this.rentalInvoiceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ınvoicesToolStripMenuItem});
            this.rentalInvoiceToolStripMenuItem.Name = "rentalInvoiceToolStripMenuItem";
            this.rentalInvoiceToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.rentalInvoiceToolStripMenuItem.Text = "Rental Invoice";
            // 
            // ınvoicesToolStripMenuItem
            // 
            this.ınvoicesToolStripMenuItem.ForeColor = System.Drawing.Color.Lime;
            this.ınvoicesToolStripMenuItem.Name = "ınvoicesToolStripMenuItem";
            this.ınvoicesToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.ınvoicesToolStripMenuItem.Text = "Invoices";
            this.ınvoicesToolStripMenuItem.Click += new System.EventHandler(this.ınvoicesToolStripMenuItem_Click);
            // 
            // ToolStripMenuItem3
            // 
            this.ToolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EquipmentsToolStripMenuItem,
            this.EquipmentCategoriesToolStripMenuItem});
            this.ToolStripMenuItem3.Name = "ToolStripMenuItem3";
            this.ToolStripMenuItem3.Size = new System.Drawing.Size(77, 20);
            this.ToolStripMenuItem3.Text = "Equipment";
            // 
            // EquipmentsToolStripMenuItem
            // 
            this.EquipmentsToolStripMenuItem.ForeColor = System.Drawing.Color.Lime;
            this.EquipmentsToolStripMenuItem.Name = "EquipmentsToolStripMenuItem";
            this.EquipmentsToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.EquipmentsToolStripMenuItem.Text = "Equipments";
            this.EquipmentsToolStripMenuItem.Click += new System.EventHandler(this.EquipmentsToolStripMenuItem_Click);
            // 
            // EquipmentCategoriesToolStripMenuItem
            // 
            this.EquipmentCategoriesToolStripMenuItem.Name = "EquipmentCategoriesToolStripMenuItem";
            this.EquipmentCategoriesToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.EquipmentCategoriesToolStripMenuItem.Text = "Equipment Categories";
            // 
            // DepartmentToolStripMenuItem
            // 
            this.DepartmentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DepartmentsToolStripMenuItem,
            this.StaffsToolStripMenuItem});
            this.DepartmentToolStripMenuItem.Name = "DepartmentToolStripMenuItem";
            this.DepartmentToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.DepartmentToolStripMenuItem.Text = "Department";
            // 
            // DepartmentsToolStripMenuItem
            // 
            this.DepartmentsToolStripMenuItem.ForeColor = System.Drawing.Color.Lime;
            this.DepartmentsToolStripMenuItem.Name = "DepartmentsToolStripMenuItem";
            this.DepartmentsToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.DepartmentsToolStripMenuItem.Text = "Departments";
            this.DepartmentsToolStripMenuItem.Click += new System.EventHandler(this.DepartmentsToolStripMenuItem_Click);
            // 
            // StaffsToolStripMenuItem
            // 
            this.StaffsToolStripMenuItem.Name = "StaffsToolStripMenuItem";
            this.StaffsToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.StaffsToolStripMenuItem.Text = "Staffs";
            // 
            // InsuranceToolStripMenuItem
            // 
            this.InsuranceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.InsuranceToolStripMenuItem1,
            this.PolicysToolStripMenuItem});
            this.InsuranceToolStripMenuItem.Name = "InsuranceToolStripMenuItem";
            this.InsuranceToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.InsuranceToolStripMenuItem.Text = "Insurance";
            // 
            // InsuranceToolStripMenuItem1
            // 
            this.InsuranceToolStripMenuItem1.ForeColor = System.Drawing.Color.Lime;
            this.InsuranceToolStripMenuItem1.Name = "InsuranceToolStripMenuItem1";
            this.InsuranceToolStripMenuItem1.Size = new System.Drawing.Size(130, 22);
            this.InsuranceToolStripMenuItem1.Text = "Insurances";
            this.InsuranceToolStripMenuItem1.Click += new System.EventHandler(this.InsuranceToolStripMenuItem1_Click);
            // 
            // PolicysToolStripMenuItem
            // 
            this.PolicysToolStripMenuItem.Name = "PolicysToolStripMenuItem";
            this.PolicysToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.PolicysToolStripMenuItem.Text = "Policys";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.directionsToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // directionsToolStripMenuItem
            // 
            this.directionsToolStripMenuItem.ForeColor = System.Drawing.Color.Lime;
            this.directionsToolStripMenuItem.Name = "directionsToolStripMenuItem";
            this.directionsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.directionsToolStripMenuItem.Text = "Directions";
            this.directionsToolStripMenuItem.Click += new System.EventHandler(this.directionsToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MenuStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.MenuStrip1.ResumeLayout(false);
            this.MenuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.MenuStrip MenuStrip1;
        internal System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem4;
        internal System.Windows.Forms.ToolStripMenuItem RentsToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem1;
        internal System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem5;
        internal System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem2;
        internal System.Windows.Forms.ToolStripMenuItem CarsToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem CarCategorysToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem3;
        internal System.Windows.Forms.ToolStripMenuItem EquipmentsToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem EquipmentCategoriesToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem DepartmentToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem DepartmentsToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem StaffsToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem InsuranceToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem InsuranceToolStripMenuItem1;
        internal System.Windows.Forms.ToolStripMenuItem PolicysToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rentalInvoiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ınvoicesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem directionsToolStripMenuItem;
    }
}

