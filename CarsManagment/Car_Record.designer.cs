namespace CarsManagment
{
    partial class Car_Record
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Car_Record));
            this.txtCarNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCarValue = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panContent = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPremiumDepreciation = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDepreciationPeriod = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCarCapacity = new System.Windows.Forms.TextBox();
            this.txtOpenning_Account = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMeterReading = new System.Windows.Forms.TextBox();
            this.panHeader = new System.Windows.Forms.Panel();
            this.panClose = new System.Windows.Forms.Panel();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panContent.SuspendLayout();
            this.panHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCarNumber
            // 
            this.txtCarNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCarNumber.Font = new System.Drawing.Font("Tahoma", 14F);
            this.txtCarNumber.Location = new System.Drawing.Point(339, 80);
            this.txtCarNumber.Name = "txtCarNumber";
            this.txtCarNumber.Size = new System.Drawing.Size(176, 23);
            this.txtCarNumber.TabIndex = 0;
            this.txtCarNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBox_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Neo Sans Arabic", 10F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(169)))), ((int)(((byte)(41)))));
            this.label1.Location = new System.Drawing.Point(519, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "رقم السيارة";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Neo Sans Arabic", 10F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(169)))), ((int)(((byte)(41)))));
            this.label3.Location = new System.Drawing.Point(516, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "القيمة الحالية للسيارة";
            // 
            // txtCarValue
            // 
            this.txtCarValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCarValue.Font = new System.Drawing.Font("Tahoma", 14F);
            this.txtCarValue.Location = new System.Drawing.Point(339, 116);
            this.txtCarValue.Name = "txtCarValue";
            this.txtCarValue.Size = new System.Drawing.Size(176, 23);
            this.txtCarValue.TabIndex = 1;
            this.txtCarValue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBox_KeyDown);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(68)))), ((int)(((byte)(53)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Neo Sans Arabic", 12F);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(55, 263);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(141, 40);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "أضافة";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // panContent
            // 
            this.panContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.panContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panContent.Controls.Add(this.label7);
            this.panContent.Controls.Add(this.txtPremiumDepreciation);
            this.panContent.Controls.Add(this.label8);
            this.panContent.Controls.Add(this.txtDepreciationPeriod);
            this.panContent.Controls.Add(this.label4);
            this.panContent.Controls.Add(this.txtCarCapacity);
            this.panContent.Controls.Add(this.txtOpenning_Account);
            this.panContent.Controls.Add(this.label5);
            this.panContent.Controls.Add(this.label6);
            this.panContent.Controls.Add(this.txtMeterReading);
            this.panContent.Controls.Add(this.panHeader);
            this.panContent.Controls.Add(this.btnAdd);
            this.panContent.Controls.Add(this.label3);
            this.panContent.Controls.Add(this.txtCarNumber);
            this.panContent.Controls.Add(this.txtCarValue);
            this.panContent.Controls.Add(this.label1);
            this.panContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panContent.Location = new System.Drawing.Point(0, 0);
            this.panContent.Name = "panContent";
            this.panContent.Size = new System.Drawing.Size(655, 329);
            this.panContent.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Neo Sans Arabic", 10F);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(169)))), ((int)(((byte)(41)))));
            this.label7.Location = new System.Drawing.Point(226, 200);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 17);
            this.label7.TabIndex = 29;
            this.label7.Text = "قيسط الاهلاك";
            // 
            // txtPremiumDepreciation
            // 
            this.txtPremiumDepreciation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPremiumDepreciation.Font = new System.Drawing.Font("Tahoma", 14F);
            this.txtPremiumDepreciation.Location = new System.Drawing.Point(49, 197);
            this.txtPremiumDepreciation.Name = "txtPremiumDepreciation";
            this.txtPremiumDepreciation.Size = new System.Drawing.Size(176, 23);
            this.txtPremiumDepreciation.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Neo Sans Arabic", 10F);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(169)))), ((int)(((byte)(41)))));
            this.label8.Location = new System.Drawing.Point(516, 157);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 17);
            this.label8.TabIndex = 27;
            this.label8.Text = "فترة الاهلاك";
            // 
            // txtDepreciationPeriod
            // 
            this.txtDepreciationPeriod.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDepreciationPeriod.Font = new System.Drawing.Font("Tahoma", 14F);
            this.txtDepreciationPeriod.Location = new System.Drawing.Point(339, 152);
            this.txtDepreciationPeriod.Name = "txtDepreciationPeriod";
            this.txtDepreciationPeriod.Size = new System.Drawing.Size(176, 23);
            this.txtDepreciationPeriod.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Neo Sans Arabic", 10F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(169)))), ((int)(((byte)(41)))));
            this.label4.Location = new System.Drawing.Point(226, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 17);
            this.label4.TabIndex = 24;
            this.label4.Text = "رصيد بداية المدة";
            // 
            // txtCarCapacity
            // 
            this.txtCarCapacity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCarCapacity.Font = new System.Drawing.Font("Tahoma", 14F);
            this.txtCarCapacity.Location = new System.Drawing.Point(49, 80);
            this.txtCarCapacity.Name = "txtCarCapacity";
            this.txtCarCapacity.Size = new System.Drawing.Size(176, 23);
            this.txtCarCapacity.TabIndex = 3;
            // 
            // txtOpenning_Account
            // 
            this.txtOpenning_Account.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOpenning_Account.Font = new System.Drawing.Font("Tahoma", 14F);
            this.txtOpenning_Account.Location = new System.Drawing.Point(49, 158);
            this.txtOpenning_Account.Name = "txtOpenning_Account";
            this.txtOpenning_Account.Size = new System.Drawing.Size(176, 23);
            this.txtOpenning_Account.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Neo Sans Arabic", 10F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(169)))), ((int)(((byte)(41)))));
            this.label5.Location = new System.Drawing.Point(229, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 17);
            this.label5.TabIndex = 20;
            this.label5.Text = "سعة التحمل";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Neo Sans Arabic", 10F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(169)))), ((int)(((byte)(41)))));
            this.label6.Location = new System.Drawing.Point(228, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 17);
            this.label6.TabIndex = 23;
            this.label6.Text = "قراءة العداد";
            // 
            // txtMeterReading
            // 
            this.txtMeterReading.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMeterReading.Font = new System.Drawing.Font("Tahoma", 14F);
            this.txtMeterReading.Location = new System.Drawing.Point(49, 119);
            this.txtMeterReading.Name = "txtMeterReading";
            this.txtMeterReading.Size = new System.Drawing.Size(176, 23);
            this.txtMeterReading.TabIndex = 4;
            // 
            // panHeader
            // 
            this.panHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(169)))), ((int)(((byte)(41)))));
            this.panHeader.Controls.Add(this.panClose);
            this.panHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panHeader.Location = new System.Drawing.Point(0, 0);
            this.panHeader.Name = "panHeader";
            this.panHeader.Size = new System.Drawing.Size(653, 36);
            this.panHeader.TabIndex = 18;
            // 
            // panClose
            // 
            this.panClose.BackgroundImage = global::CarsManagment.Properties.Resources.Delete_52px;
            this.panClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.panClose.Location = new System.Drawing.Point(607, 0);
            this.panClose.Name = "panClose";
            this.panClose.Size = new System.Drawing.Size(46, 36);
            this.panClose.TabIndex = 0;
            this.panClose.Click += new System.EventHandler(this.panClose_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panHeader;
            this.bunifuDragControl1.Vertical = true;
            // 
            // Car_Record
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 329);
            this.Controls.Add(this.panContent);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(68)))), ((int)(((byte)(154)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Car_Record";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تسجيل مخزن";
            this.panContent.ResumeLayout(false);
            this.panContent.PerformLayout();
            this.panHeader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtCarNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCarValue;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel panContent;
        private System.Windows.Forms.Panel panHeader;
        private System.Windows.Forms.Panel panClose;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCarCapacity;
        private System.Windows.Forms.TextBox txtOpenning_Account;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMeterReading;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPremiumDepreciation;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDepreciationPeriod;
    }
}

