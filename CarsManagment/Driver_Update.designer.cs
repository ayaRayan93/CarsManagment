namespace CarsManagment
{
    partial class Driver_Update
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Driver_Update));
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panHeader = new System.Windows.Forms.Panel();
            this.panClose = new System.Windows.Forms.Panel();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.dTPWorkStartDate = new System.Windows.Forms.DateTimePicker();
            this.dTPBirthDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNationalID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLicese = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDriverName = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(68)))), ((int)(((byte)(53)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Neo Sans Arabic", 12F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(118, 202);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 40);
            this.button1.TabIndex = 6;
            this.button1.Text = "تعديل";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dTPWorkStartDate);
            this.panel1.Controls.Add(this.dTPBirthDate);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtNationalID);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtLicese);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtAddress);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtDriverName);
            this.panel1.Controls.Add(this.txtPhone);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panHeader);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(694, 277);
            this.panel1.TabIndex = 7;
            // 
            // panHeader
            // 
            this.panHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(169)))), ((int)(((byte)(41)))));
            this.panHeader.Controls.Add(this.panClose);
            this.panHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panHeader.Location = new System.Drawing.Point(0, 0);
            this.panHeader.Name = "panHeader";
            this.panHeader.Size = new System.Drawing.Size(692, 36);
            this.panHeader.TabIndex = 18;
            // 
            // panClose
            // 
            this.panClose.BackgroundImage = global::CarsManagment.Properties.Resources.Delete_52px;
            this.panClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.panClose.Location = new System.Drawing.Point(646, 0);
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
            // dTPWorkStartDate
            // 
            this.dTPWorkStartDate.Font = new System.Drawing.Font("Tahoma", 10F);
            this.dTPWorkStartDate.Location = new System.Drawing.Point(83, 158);
            this.dTPWorkStartDate.Name = "dTPWorkStartDate";
            this.dTPWorkStartDate.Size = new System.Drawing.Size(176, 24);
            this.dTPWorkStartDate.TabIndex = 46;
            // 
            // dTPBirthDate
            // 
            this.dTPBirthDate.Font = new System.Drawing.Font("Tahoma", 10F);
            this.dTPBirthDate.Location = new System.Drawing.Point(83, 87);
            this.dTPBirthDate.Name = "dTPBirthDate";
            this.dTPBirthDate.Size = new System.Drawing.Size(176, 24);
            this.dTPBirthDate.TabIndex = 43;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Neo Sans Arabic", 10F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(169)))), ((int)(((byte)(41)))));
            this.label6.Location = new System.Drawing.Point(572, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 17);
            this.label6.TabIndex = 51;
            this.label6.Text = "رقم البطاقة";
            // 
            // txtNationalID
            // 
            this.txtNationalID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNationalID.Font = new System.Drawing.Font("Tahoma", 14F);
            this.txtNationalID.Location = new System.Drawing.Point(395, 120);
            this.txtNationalID.Name = "txtNationalID";
            this.txtNationalID.Size = new System.Drawing.Size(176, 23);
            this.txtNationalID.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Neo Sans Arabic", 10F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(169)))), ((int)(((byte)(41)))));
            this.label1.Location = new System.Drawing.Point(260, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 17);
            this.label1.TabIndex = 50;
            this.label1.Text = "تاريخ استلام العمل";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Neo Sans Arabic", 10F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(169)))), ((int)(((byte)(41)))));
            this.label4.Location = new System.Drawing.Point(260, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 49;
            this.label4.Text = "بيان الرخصة";
            // 
            // txtLicese
            // 
            this.txtLicese.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLicese.Font = new System.Drawing.Font("Tahoma", 14F);
            this.txtLicese.Location = new System.Drawing.Point(83, 123);
            this.txtLicese.Name = "txtLicese";
            this.txtLicese.Size = new System.Drawing.Size(176, 23);
            this.txtLicese.TabIndex = 45;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Neo Sans Arabic", 10F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(169)))), ((int)(((byte)(41)))));
            this.label5.Location = new System.Drawing.Point(262, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 17);
            this.label5.TabIndex = 48;
            this.label5.Text = "تاريخ الميلاد";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Neo Sans Arabic", 10F);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(169)))), ((int)(((byte)(41)))));
            this.label8.Location = new System.Drawing.Point(572, 202);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 17);
            this.label8.TabIndex = 47;
            this.label8.Text = "العنوان";
            // 
            // txtAddress
            // 
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAddress.Font = new System.Drawing.Font("Tahoma", 14F);
            this.txtAddress.Location = new System.Drawing.Point(395, 197);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(176, 23);
            this.txtAddress.TabIndex = 42;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Neo Sans Arabic", 10F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(169)))), ((int)(((byte)(41)))));
            this.label3.Location = new System.Drawing.Point(572, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 44;
            this.label3.Text = "التلفون";
            // 
            // txtDriverName
            // 
            this.txtDriverName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDriverName.Font = new System.Drawing.Font("Tahoma", 14F);
            this.txtDriverName.Location = new System.Drawing.Point(395, 81);
            this.txtDriverName.Name = "txtDriverName";
            this.txtDriverName.Size = new System.Drawing.Size(176, 23);
            this.txtDriverName.TabIndex = 38;
            // 
            // txtPhone
            // 
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPhone.Font = new System.Drawing.Font("Tahoma", 14F);
            this.txtPhone.Location = new System.Drawing.Point(395, 158);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(176, 23);
            this.txtPhone.TabIndex = 40;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Neo Sans Arabic", 10F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(169)))), ((int)(((byte)(41)))));
            this.label2.Location = new System.Drawing.Point(574, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 41;
            this.label2.Text = "أسم السائق";
            // 
            // Driver_Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 277);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(68)))), ((int)(((byte)(154)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Driver_Update";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تسجيل مخزن";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panHeader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panHeader;
        private System.Windows.Forms.Panel panClose;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.DateTimePicker dTPWorkStartDate;
        private System.Windows.Forms.DateTimePicker dTPBirthDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNationalID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLicese;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDriverName;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label2;
    }
}

