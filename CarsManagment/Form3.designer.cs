namespace CarIncome
{
    partial class Form3
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
            this.comCarNumber = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPermissionNumber = new System.Windows.Forms.TextBox();
            this.btnAddPermission = new System.Windows.Forms.Button();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNoCarton = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNoSets = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNoPanio = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNoComp = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNoColumns = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNolone = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtNoDocks = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblSub = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtMeterNow = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lblMeter = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // comCarNumber
            // 
            this.comCarNumber.Font = new System.Drawing.Font("Tahoma", 10F);
            this.comCarNumber.FormattingEnabled = true;
            this.comCarNumber.Location = new System.Drawing.Point(377, 46);
            this.comCarNumber.Name = "comCarNumber";
            this.comCarNumber.Size = new System.Drawing.Size(121, 24);
            this.comCarNumber.TabIndex = 20;
            this.comCarNumber.SelectedIndexChanged += new System.EventHandler(this.comCarNumber_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label5.Location = new System.Drawing.Point(504, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = "رقم السيارة";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.dateTimePicker1.Location = new System.Drawing.Point(77, 43);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(161, 24);
            this.dateTimePicker1.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label1.Location = new System.Drawing.Point(269, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "التاريخ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label2.Location = new System.Drawing.Point(539, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 23;
            this.label2.Text = "رقم الاذن";
            // 
            // txtPermissionNumber
            // 
            this.txtPermissionNumber.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtPermissionNumber.Location = new System.Drawing.Point(370, 116);
            this.txtPermissionNumber.Name = "txtPermissionNumber";
            this.txtPermissionNumber.Size = new System.Drawing.Size(147, 24);
            this.txtPermissionNumber.TabIndex = 24;
            this.txtPermissionNumber.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_MouseClick);
            this.txtPermissionNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPermissionNumber_KeyDown);
            // 
            // btnAddPermission
            // 
            this.btnAddPermission.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnAddPermission.Location = new System.Drawing.Point(443, 156);
            this.btnAddPermission.Name = "btnAddPermission";
            this.btnAddPermission.Size = new System.Drawing.Size(58, 23);
            this.btnAddPermission.TabIndex = 25;
            this.btnAddPermission.Text = "اضافه";
            this.btnAddPermission.UseVisualStyleBackColor = true;
            this.btnAddPermission.Click += new System.EventHandler(this.btnAddPermission_Click);
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtAddress.Location = new System.Drawing.Point(151, 223);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(366, 24);
            this.txtAddress.TabIndex = 27;
            this.txtAddress.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_MouseClick);
            this.txtAddress.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMovable_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label3.Location = new System.Drawing.Point(539, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 26;
            this.label3.Text = "العنوان";
            // 
            // txtNoCarton
            // 
            this.txtNoCarton.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtNoCarton.Location = new System.Drawing.Point(351, 267);
            this.txtNoCarton.Name = "txtNoCarton";
            this.txtNoCarton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtNoCarton.Size = new System.Drawing.Size(147, 24);
            this.txtNoCarton.TabIndex = 29;
            this.txtNoCarton.Text = "0";
            this.txtNoCarton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_MouseClick);
            this.txtNoCarton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMovable_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label4.Location = new System.Drawing.Point(520, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 17);
            this.label4.TabIndex = 28;
            this.label4.Text = "عدد الكراتين";
            // 
            // txtNoSets
            // 
            this.txtNoSets.Location = new System.Drawing.Point(294, 30);
            this.txtNoSets.Name = "txtNoSets";
            this.txtNoSets.Size = new System.Drawing.Size(147, 24);
            this.txtNoSets.TabIndex = 31;
            this.txtNoSets.Text = "0";
            this.txtNoSets.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_MouseClick);
            this.txtNoSets.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMovable_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(463, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 17);
            this.label6.TabIndex = 30;
            this.label6.Text = "عدد الاطقم";
            // 
            // txtNoPanio
            // 
            this.txtNoPanio.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtNoPanio.Location = new System.Drawing.Point(77, 267);
            this.txtNoPanio.Name = "txtNoPanio";
            this.txtNoPanio.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtNoPanio.Size = new System.Drawing.Size(147, 24);
            this.txtNoPanio.TabIndex = 37;
            this.txtNoPanio.Text = "0";
            this.txtNoPanio.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_MouseClick);
            this.txtNoPanio.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMovable_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label7.Location = new System.Drawing.Point(246, 267);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 17);
            this.label7.TabIndex = 36;
            this.label7.Text = "عدد البانيوهات";
            // 
            // txtNoComp
            // 
            this.txtNoComp.Location = new System.Drawing.Point(24, 65);
            this.txtNoComp.Name = "txtNoComp";
            this.txtNoComp.Size = new System.Drawing.Size(147, 24);
            this.txtNoComp.TabIndex = 35;
            this.txtNoComp.Text = "0";
            this.txtNoComp.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_MouseClick);
            this.txtNoComp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMovable_KeyDown);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(193, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 17);
            this.label8.TabIndex = 34;
            // 
            // txtNoColumns
            // 
            this.txtNoColumns.Location = new System.Drawing.Point(24, 33);
            this.txtNoColumns.Name = "txtNoColumns";
            this.txtNoColumns.Size = new System.Drawing.Size(147, 24);
            this.txtNoColumns.TabIndex = 33;
            this.txtNoColumns.Text = "0";
            this.txtNoColumns.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_MouseClick);
            this.txtNoColumns.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMovable_KeyDown);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(193, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 17);
            this.label9.TabIndex = 32;
            this.label9.Text = "عدد العواميد";
            // 
            // txtNolone
            // 
            this.txtNolone.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtNolone.Location = new System.Drawing.Point(385, 546);
            this.txtNolone.Name = "txtNolone";
            this.txtNolone.Size = new System.Drawing.Size(147, 24);
            this.txtNolone.TabIndex = 41;
            this.txtNolone.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_MouseClick);
            this.txtNolone.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMovable_KeyDown);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label11.Location = new System.Drawing.Point(554, 546);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 17);
            this.label11.TabIndex = 40;
            this.label11.Text = "النولون";
            // 
            // txtNoDocks
            // 
            this.txtNoDocks.Location = new System.Drawing.Point(294, 65);
            this.txtNoDocks.Name = "txtNoDocks";
            this.txtNoDocks.Size = new System.Drawing.Size(147, 24);
            this.txtNoDocks.TabIndex = 39;
            this.txtNoDocks.Text = "0";
            this.txtNoDocks.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_MouseClick);
            this.txtNoDocks.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMovable_KeyDown);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(463, 63);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 17);
            this.label12.TabIndex = 38;
            this.label12.Text = "عدد الاحواض";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(189, 68);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(103, 17);
            this.label13.TabIndex = 44;
            this.label13.Text = "عدد الكومبنيشن";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label10.Location = new System.Drawing.Point(554, 586);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 17);
            this.label10.TabIndex = 42;
            this.label10.Text = "ملاحظات";
            // 
            // txtNote
            // 
            this.txtNote.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtNote.Location = new System.Drawing.Point(297, 586);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(235, 56);
            this.txtNote.TabIndex = 43;
            this.txtNote.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_MouseClick);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnAdd.Location = new System.Drawing.Point(105, 622);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(88, 42);
            this.btnAdd.TabIndex = 45;
            this.btnAdd.Text = "اضافه";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNoComp);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txtNoSets);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtNoColumns);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtNoDocks);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.groupBox1.Location = new System.Drawing.Point(65, 296);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(563, 100);
            this.groupBox1.TabIndex = 46;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "صحي";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dataGridView1.Location = new System.Drawing.Point(105, 89);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(193, 117);
            this.dataGridView1.TabIndex = 47;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "رقم الاذن";
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnDelete.Location = new System.Drawing.Point(379, 156);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(58, 23);
            this.btnDelete.TabIndex = 48;
            this.btnDelete.Text = "حذف";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnBack.Location = new System.Drawing.Point(12, 622);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(85, 42);
            this.btnBack.TabIndex = 49;
            this.btnBack.Text = "رجوع";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblSub);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.txtMeterNow);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.lblMeter);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 10F);
            this.groupBox2.Location = new System.Drawing.Point(65, 402);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(563, 122);
            this.groupBox2.TabIndex = 50;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "العداد";
            // 
            // lblSub
            // 
            this.lblSub.AutoSize = true;
            this.lblSub.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblSub.Location = new System.Drawing.Point(86, 87);
            this.lblSub.Name = "lblSub";
            this.lblSub.Size = new System.Drawing.Size(0, 17);
            this.lblSub.TabIndex = 13;
            this.lblSub.Visible = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label14.Location = new System.Drawing.Point(193, 90);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(68, 17);
            this.label14.TabIndex = 12;
            this.label14.Text = "فرق العداد";
            // 
            // txtMeterNow
            // 
            this.txtMeterNow.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtMeterNow.Location = new System.Drawing.Point(346, 83);
            this.txtMeterNow.Name = "txtMeterNow";
            this.txtMeterNow.Size = new System.Drawing.Size(121, 24);
            this.txtMeterNow.TabIndex = 11;
            this.txtMeterNow.Visible = false;
            this.txtMeterNow.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_MouseClick);
            this.txtMeterNow.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMeterNow_KeyDown);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label15.Location = new System.Drawing.Point(473, 86);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(71, 17);
            this.label15.TabIndex = 10;
            this.label15.Text = "قراءة العداد";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label16.Location = new System.Drawing.Point(468, 34);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(76, 17);
            this.label16.TabIndex = 9;
            this.label16.Text = "قراءة سابقة";
            // 
            // lblMeter
            // 
            this.lblMeter.AutoSize = true;
            this.lblMeter.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblMeter.Location = new System.Drawing.Point(365, 34);
            this.lblMeter.Name = "lblMeter";
            this.lblMeter.Size = new System.Drawing.Size(0, 17);
            this.lblMeter.TabIndex = 8;
            this.lblMeter.Visible = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 687);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtNolone);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtNoPanio);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtNoCarton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAddPermission);
            this.Controls.Add(this.txtPermissionNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comCarNumber);
            this.Controls.Add(this.label5);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تسجيل الايرادات";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form3_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comCarNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPermissionNumber;
        private System.Windows.Forms.Button btnAddPermission;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNoCarton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNoSets;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNoPanio;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNoComp;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNoColumns;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNolone;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtNoDocks;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblSub;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtMeterNow;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblMeter;
    }
}

