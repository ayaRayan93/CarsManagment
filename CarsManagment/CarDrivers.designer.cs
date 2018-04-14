namespace CarsManagment
{
    partial class CarDrivers
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panHeader = new System.Windows.Forms.Panel();
            this.panClose = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labStoreName = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.tableLayoutPanel20 = new System.Windows.Forms.TableLayoutPanel();
            this.btnDeleteCarDriver = new System.Windows.Forms.Button();
            this.dataGridViewCarDrivers = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comDrivers = new System.Windows.Forms.ComboBox();
            this.panHeader.SuspendLayout();
            this.tableLayoutPanel20.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCarDrivers)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panHeader
            // 
            this.panHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(182)))), ((int)(((byte)(92)))));
            this.panHeader.Controls.Add(this.panClose);
            this.panHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panHeader.Location = new System.Drawing.Point(0, 0);
            this.panHeader.Name = "panHeader";
            this.panHeader.Size = new System.Drawing.Size(573, 36);
            this.panHeader.TabIndex = 23;
            // 
            // panClose
            // 
            this.panClose.BackgroundImage = global::CarsManagment.Properties.Resources.Delete_52px;
            this.panClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.panClose.Location = new System.Drawing.Point(527, 0);
            this.panClose.Name = "panClose";
            this.panClose.Size = new System.Drawing.Size(46, 36);
            this.panClose.TabIndex = 0;
            this.panClose.Click += new System.EventHandler(this.panClose_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(68)))), ((int)(((byte)(53)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Neo Sans Arabic", 12F);
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAdd.Location = new System.Drawing.Point(276, 175);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(84, 36);
            this.btnAdd.TabIndex = 22;
            this.btnAdd.Text = "اضافة";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(182)))), ((int)(((byte)(92)))));
            this.label1.Location = new System.Drawing.Point(456, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 19);
            this.label1.TabIndex = 21;
            this.label1.Text = ": السائق";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(182)))), ((int)(((byte)(92)))));
            this.label2.Location = new System.Drawing.Point(456, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 19);
            this.label2.TabIndex = 24;
            this.label2.Text = ": رقم العربية";
            // 
            // labStoreName
            // 
            this.labStoreName.AutoSize = true;
            this.labStoreName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labStoreName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(68)))), ((int)(((byte)(53)))));
            this.labStoreName.Location = new System.Drawing.Point(277, 92);
            this.labStoreName.Name = "labStoreName";
            this.labStoreName.Size = new System.Drawing.Size(0, 19);
            this.labStoreName.TabIndex = 25;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panHeader;
            this.bunifuDragControl1.Vertical = true;
            // 
            // tableLayoutPanel20
            // 
            this.tableLayoutPanel20.ColumnCount = 1;
            this.tableLayoutPanel20.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel20.Controls.Add(this.btnDeleteCarDriver, 0, 1);
            this.tableLayoutPanel20.Controls.Add(this.dataGridViewCarDrivers, 0, 0);
            this.tableLayoutPanel20.Location = new System.Drawing.Point(12, 42);
            this.tableLayoutPanel20.Name = "tableLayoutPanel20";
            this.tableLayoutPanel20.RowCount = 2;
            this.tableLayoutPanel20.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel20.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel20.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel20.Size = new System.Drawing.Size(234, 288);
            this.tableLayoutPanel20.TabIndex = 26;
            // 
            // btnDeleteCarDriver
            // 
            this.btnDeleteCarDriver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(68)))), ((int)(((byte)(53)))));
            this.btnDeleteCarDriver.FlatAppearance.BorderSize = 0;
            this.btnDeleteCarDriver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteCarDriver.Font = new System.Drawing.Font("Neo Sans Arabic", 12F);
            this.btnDeleteCarDriver.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDeleteCarDriver.Location = new System.Drawing.Point(3, 247);
            this.btnDeleteCarDriver.Name = "btnDeleteCarDriver";
            this.btnDeleteCarDriver.Size = new System.Drawing.Size(84, 36);
            this.btnDeleteCarDriver.TabIndex = 28;
            this.btnDeleteCarDriver.Text = "حذف";
            this.btnDeleteCarDriver.UseVisualStyleBackColor = false;
            this.btnDeleteCarDriver.Click += new System.EventHandler(this.btnDeleteCarDriver_Click);
            // 
            // dataGridViewCarDrivers
            // 
            this.dataGridViewCarDrivers.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridViewCarDrivers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCarDrivers.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridViewCarDrivers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewCarDrivers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(182)))), ((int)(((byte)(92)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCarDrivers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewCarDrivers.ColumnHeadersHeight = 25;
            this.dataGridViewCarDrivers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewCarDrivers.DoubleBuffered = true;
            this.dataGridViewCarDrivers.EnableHeadersVisualStyles = false;
            this.dataGridViewCarDrivers.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(182)))), ((int)(((byte)(92)))));
            this.dataGridViewCarDrivers.HeaderForeColor = System.Drawing.Color.White;
            this.dataGridViewCarDrivers.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewCarDrivers.Name = "dataGridViewCarDrivers";
            this.dataGridViewCarDrivers.ReadOnly = true;
            this.dataGridViewCarDrivers.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridViewCarDrivers.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewCarDrivers.Size = new System.Drawing.Size(228, 238);
            this.dataGridViewCarDrivers.TabIndex = 4;
            this.dataGridViewCarDrivers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCarDrivers_CellClick);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.comDrivers);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(573, 337);
            this.panel1.TabIndex = 27;
            // 
            // comDrivers
            // 
            this.comDrivers.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comDrivers.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comDrivers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comDrivers.Font = new System.Drawing.Font("Tahoma", 10F);
            this.comDrivers.FormattingEnabled = true;
            this.comDrivers.Location = new System.Drawing.Point(280, 132);
            this.comDrivers.Name = "comDrivers";
            this.comDrivers.Size = new System.Drawing.Size(169, 24);
            this.comDrivers.TabIndex = 0;
            // 
            // CarDrivers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 337);
            this.Controls.Add(this.tableLayoutPanel20);
            this.Controls.Add(this.labStoreName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panHeader);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CarDrivers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StorePlaces";
            this.Load += new System.EventHandler(this.CarDrivers_Load);
            this.panHeader.ResumeLayout(false);
            this.tableLayoutPanel20.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCarDrivers)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panHeader;
        private System.Windows.Forms.Panel panClose;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labStoreName;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel20;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dataGridViewCarDrivers;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDeleteCarDriver;
        private System.Windows.Forms.ComboBox comDrivers;
    }
}