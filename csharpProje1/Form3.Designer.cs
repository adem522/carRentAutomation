namespace csharpProje1
{
    partial class rentTable
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.equipmentButton = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.brandCombobox = new System.Windows.Forms.ComboBox();
            this.pickUpLocationCombobox = new System.Windows.Forms.ComboBox();
            this.dropOffLocationCombobox = new System.Windows.Forms.ComboBox();
            this.equipmentCombobox = new System.Windows.Forms.ComboBox();
            this.insuranceCombobox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.modelCombobox = new System.Windows.Forms.ComboBox();
            this.carCategoryComboBox = new System.Windows.Forms.ComboBox();
            this.plateCombobox = new System.Windows.Forms.ComboBox();
            this.locationButton = new System.Windows.Forms.Button();
            this.insuranceButton = new System.Windows.Forms.Button();
            this.modifyButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.insertButton = new System.Windows.Forms.Button();
            this.departmentButton = new System.Windows.Forms.Button();
            this.departmentCombobox = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.customerSearchButton = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.carSearchButton = new System.Windows.Forms.Button();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 288);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(776, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Lime;
            this.button1.Location = new System.Drawing.Point(320, 90);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Customers";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.Color.Lime;
            this.button2.Location = new System.Drawing.Point(686, 117);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Cars";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // equipmentButton
            // 
            this.equipmentButton.ForeColor = System.Drawing.Color.Lime;
            this.equipmentButton.Location = new System.Drawing.Point(320, 225);
            this.equipmentButton.Name = "equipmentButton";
            this.equipmentButton.Size = new System.Drawing.Size(75, 23);
            this.equipmentButton.TabIndex = 3;
            this.equipmentButton.Text = "Equipments";
            this.equipmentButton.UseVisualStyleBackColor = true;
            this.equipmentButton.Click += new System.EventHandler(this.equipmentButton_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(178, 7);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(178, 37);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.ShowUpDown = true;
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Start Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "End Date";
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Location = new System.Drawing.Point(178, 66);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.ShowUpDown = true;
            this.dateTimePicker3.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker3.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Delivery Date";
            // 
            // comboBox1
            // 
            this.comboBox1.AllowDrop = true;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(178, 92);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 8;
            // 
            // brandCombobox
            // 
            this.brandCombobox.FormattingEnabled = true;
            this.brandCombobox.Location = new System.Drawing.Point(305, 119);
            this.brandCombobox.Name = "brandCombobox";
            this.brandCombobox.Size = new System.Drawing.Size(121, 21);
            this.brandCombobox.TabIndex = 8;
            this.brandCombobox.SelectedIndexChanged += new System.EventHandler(this.brandCombobox_SelectedIndexChanged);
            // 
            // pickUpLocationCombobox
            // 
            this.pickUpLocationCombobox.FormattingEnabled = true;
            this.pickUpLocationCombobox.Location = new System.Drawing.Point(178, 146);
            this.pickUpLocationCombobox.Name = "pickUpLocationCombobox";
            this.pickUpLocationCombobox.Size = new System.Drawing.Size(121, 21);
            this.pickUpLocationCombobox.TabIndex = 8;
            // 
            // dropOffLocationCombobox
            // 
            this.dropOffLocationCombobox.FormattingEnabled = true;
            this.dropOffLocationCombobox.Location = new System.Drawing.Point(178, 173);
            this.dropOffLocationCombobox.Name = "dropOffLocationCombobox";
            this.dropOffLocationCombobox.Size = new System.Drawing.Size(121, 21);
            this.dropOffLocationCombobox.TabIndex = 8;
            // 
            // equipmentCombobox
            // 
            this.equipmentCombobox.FormattingEnabled = true;
            this.equipmentCombobox.Location = new System.Drawing.Point(178, 227);
            this.equipmentCombobox.Name = "equipmentCombobox";
            this.equipmentCombobox.Size = new System.Drawing.Size(121, 21);
            this.equipmentCombobox.TabIndex = 8;
            // 
            // insuranceCombobox
            // 
            this.insuranceCombobox.FormattingEnabled = true;
            this.insuranceCombobox.Location = new System.Drawing.Point(178, 254);
            this.insuranceCombobox.Name = "insuranceCombobox";
            this.insuranceCombobox.Size = new System.Drawing.Size(121, 21);
            this.insuranceCombobox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Customer";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Car";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Pick up location";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 235);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Equipment";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 181);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Drop off location";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 262);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Insurance";
            // 
            // modelCombobox
            // 
            this.modelCombobox.FormattingEnabled = true;
            this.modelCombobox.Location = new System.Drawing.Point(432, 119);
            this.modelCombobox.Name = "modelCombobox";
            this.modelCombobox.Size = new System.Drawing.Size(121, 21);
            this.modelCombobox.TabIndex = 8;
            this.modelCombobox.SelectedIndexChanged += new System.EventHandler(this.modelCombobox_SelectedIndexChanged);
            // 
            // carCategoryComboBox
            // 
            this.carCategoryComboBox.FormattingEnabled = true;
            this.carCategoryComboBox.Location = new System.Drawing.Point(178, 119);
            this.carCategoryComboBox.Name = "carCategoryComboBox";
            this.carCategoryComboBox.Size = new System.Drawing.Size(121, 21);
            this.carCategoryComboBox.TabIndex = 8;
            this.carCategoryComboBox.SelectedIndexChanged += new System.EventHandler(this.carCategoryComboBox_SelectedIndexChanged);
            // 
            // plateCombobox
            // 
            this.plateCombobox.FormattingEnabled = true;
            this.plateCombobox.Location = new System.Drawing.Point(559, 119);
            this.plateCombobox.Name = "plateCombobox";
            this.plateCombobox.Size = new System.Drawing.Size(121, 21);
            this.plateCombobox.TabIndex = 8;
            // 
            // locationButton
            // 
            this.locationButton.ForeColor = System.Drawing.Color.Lime;
            this.locationButton.Location = new System.Drawing.Point(320, 169);
            this.locationButton.Name = "locationButton";
            this.locationButton.Size = new System.Drawing.Size(75, 23);
            this.locationButton.TabIndex = 3;
            this.locationButton.Text = "Locations";
            this.locationButton.UseVisualStyleBackColor = true;
            this.locationButton.Click += new System.EventHandler(this.locationButton_Click);
            // 
            // insuranceButton
            // 
            this.insuranceButton.ForeColor = System.Drawing.Color.Lime;
            this.insuranceButton.Location = new System.Drawing.Point(320, 252);
            this.insuranceButton.Name = "insuranceButton";
            this.insuranceButton.Size = new System.Drawing.Size(75, 23);
            this.insuranceButton.TabIndex = 3;
            this.insuranceButton.Text = "Insurances";
            this.insuranceButton.UseVisualStyleBackColor = true;
            this.insuranceButton.Click += new System.EventHandler(this.insuranceButton_Click);
            // 
            // modifyButton
            // 
            this.modifyButton.ForeColor = System.Drawing.Color.Lime;
            this.modifyButton.Location = new System.Drawing.Point(537, 235);
            this.modifyButton.Name = "modifyButton";
            this.modifyButton.Size = new System.Drawing.Size(75, 23);
            this.modifyButton.TabIndex = 3;
            this.modifyButton.Text = "Modify";
            this.modifyButton.UseVisualStyleBackColor = true;
            this.modifyButton.Click += new System.EventHandler(this.modifyButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.ForeColor = System.Drawing.Color.Lime;
            this.deleteButton.Location = new System.Drawing.Point(618, 235);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // insertButton
            // 
            this.insertButton.ForeColor = System.Drawing.Color.Lime;
            this.insertButton.Location = new System.Drawing.Point(456, 235);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(75, 23);
            this.insertButton.TabIndex = 3;
            this.insertButton.Text = "Insert";
            this.insertButton.UseVisualStyleBackColor = true;
            this.insertButton.Click += new System.EventHandler(this.insertButton_Click);
            // 
            // departmentButton
            // 
            this.departmentButton.ForeColor = System.Drawing.Color.Lime;
            this.departmentButton.Location = new System.Drawing.Point(320, 198);
            this.departmentButton.Name = "departmentButton";
            this.departmentButton.Size = new System.Drawing.Size(75, 23);
            this.departmentButton.TabIndex = 3;
            this.departmentButton.Text = "Departments";
            this.departmentButton.UseVisualStyleBackColor = true;
            this.departmentButton.Click += new System.EventHandler(this.departmentButton_Click);
            // 
            // departmentCombobox
            // 
            this.departmentCombobox.FormattingEnabled = true;
            this.departmentCombobox.Location = new System.Drawing.Point(178, 200);
            this.departmentCombobox.Name = "departmentCombobox";
            this.departmentCombobox.Size = new System.Drawing.Size(121, 21);
            this.departmentCombobox.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 208);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Departments";
            // 
            // customerSearchButton
            // 
            this.customerSearchButton.ForeColor = System.Drawing.Color.Lime;
            this.customerSearchButton.Location = new System.Drawing.Point(278, 442);
            this.customerSearchButton.Name = "customerSearchButton";
            this.customerSearchButton.Size = new System.Drawing.Size(75, 23);
            this.customerSearchButton.TabIndex = 3;
            this.customerSearchButton.Text = "Search";
            this.customerSearchButton.UseVisualStyleBackColor = true;
            this.customerSearchButton.Click += new System.EventHandler(this.customerSearchButton_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(136, 444);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(17, 452);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(113, 13);
            this.label11.TabIndex = 9;
            this.label11.Text = "Search With Customer";
            // 
            // carSearchButton
            // 
            this.carSearchButton.ForeColor = System.Drawing.Color.Lime;
            this.carSearchButton.Location = new System.Drawing.Point(278, 469);
            this.carSearchButton.Name = "carSearchButton";
            this.carSearchButton.Size = new System.Drawing.Size(75, 23);
            this.carSearchButton.TabIndex = 3;
            this.carSearchButton.Text = "Search";
            this.carSearchButton.UseVisualStyleBackColor = true;
            this.carSearchButton.Click += new System.EventHandler(this.carSearchButton_Click);
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(136, 471);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 8;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(17, 479);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(85, 13);
            this.label12.TabIndex = 9;
            this.label12.Text = "Search With Car";
            // 
            // button3
            // 
            this.button3.ForeColor = System.Drawing.Color.Lime;
            this.button3.Location = new System.Drawing.Point(648, 445);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Search";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.ForeColor = System.Drawing.Color.Lime;
            this.button4.Location = new System.Drawing.Point(648, 471);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "Search";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(506, 444);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 21);
            this.comboBox4.TabIndex = 8;
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(506, 471);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(121, 21);
            this.comboBox5.TabIndex = 8;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(387, 450);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(119, 13);
            this.label13.TabIndex = 9;
            this.label13.Text = "Search With Equipment";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(387, 479);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(116, 13);
            this.label14.TabIndex = 9;
            this.label14.Text = "Search With Insurance";
            // 
            // button5
            // 
            this.button5.ForeColor = System.Drawing.Color.Lime;
            this.button5.Location = new System.Drawing.Point(729, 445);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(49, 47);
            this.button5.TabIndex = 10;
            this.button5.Text = "R";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // rentTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 512);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.departmentCombobox);
            this.Controls.Add(this.comboBox5);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.insuranceCombobox);
            this.Controls.Add(this.carCategoryComboBox);
            this.Controls.Add(this.equipmentCombobox);
            this.Controls.Add(this.dropOffLocationCombobox);
            this.Controls.Add(this.pickUpLocationCombobox);
            this.Controls.Add(this.plateCombobox);
            this.Controls.Add(this.modelCombobox);
            this.Controls.Add(this.brandCombobox);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.insertButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.locationButton);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.departmentButton);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.carSearchButton);
            this.Controls.Add(this.customerSearchButton);
            this.Controls.Add(this.modifyButton);
            this.Controls.Add(this.insuranceButton);
            this.Controls.Add(this.equipmentButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "rentTable";
            this.Text = "Rent";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button equipmentButton;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox brandCombobox;
        private System.Windows.Forms.ComboBox pickUpLocationCombobox;
        private System.Windows.Forms.ComboBox dropOffLocationCombobox;
        private System.Windows.Forms.ComboBox equipmentCombobox;
        private System.Windows.Forms.ComboBox insuranceCombobox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox modelCombobox;
        private System.Windows.Forms.ComboBox carCategoryComboBox;
        private System.Windows.Forms.ComboBox plateCombobox;
        private System.Windows.Forms.Button locationButton;
        private System.Windows.Forms.Button insuranceButton;
        private System.Windows.Forms.Button modifyButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button insertButton;
        private System.Windows.Forms.Button departmentButton;
        private System.Windows.Forms.ComboBox departmentCombobox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button customerSearchButton;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button carSearchButton;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button5;
    }
}