namespace FajrEnrollment.Forms
{
    partial class Main
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblNationalCode = new System.Windows.Forms.Label();
            this.lblCretiNumber = new System.Windows.Forms.Label();
            this.lblFatherName = new System.Windows.Forms.Label();
            this.lblActivityType = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.dgvMembers = new System.Windows.Forms.DataGridView();
            this.gcId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gcFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gcLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gcNationalCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gcFatherName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gcCertiNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gcActivityType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtNationalCode = new System.Windows.Forms.TextBox();
            this.txtFatherName = new System.Windows.Forms.TextBox();
            this.txtCretiNumber = new System.Windows.Forms.TextBox();
            this.cmbActivityType = new System.Windows.Forms.ComboBox();
            this.pnInfo = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembers)).BeginInit();
            this.pnInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(610, 14);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(25, 22);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "نام:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(419, 14);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(68, 22);
            this.lblLastName.TabIndex = 1;
            this.lblLastName.Text = "نام خانوادگی:";
            // 
            // lblNationalCode
            // 
            this.lblNationalCode.AutoSize = true;
            this.lblNationalCode.Location = new System.Drawing.Point(182, 14);
            this.lblNationalCode.Name = "lblNationalCode";
            this.lblNationalCode.Size = new System.Drawing.Size(46, 22);
            this.lblNationalCode.TabIndex = 2;
            this.lblNationalCode.Text = "کد ملی:";
            // 
            // lblCretiNumber
            // 
            this.lblCretiNumber.AutoSize = true;
            this.lblCretiNumber.Location = new System.Drawing.Point(610, 62);
            this.lblCretiNumber.Name = "lblCretiNumber";
            this.lblCretiNumber.Size = new System.Drawing.Size(43, 22);
            this.lblCretiNumber.TabIndex = 3;
            this.lblCretiNumber.Text = "ش ش:";
            // 
            // lblFatherName
            // 
            this.lblFatherName.AutoSize = true;
            this.lblFatherName.Location = new System.Drawing.Point(419, 62);
            this.lblFatherName.Name = "lblFatherName";
            this.lblFatherName.Size = new System.Drawing.Size(42, 22);
            this.lblFatherName.TabIndex = 4;
            this.lblFatherName.Text = "نام پدر:";
            // 
            // lblActivityType
            // 
            this.lblActivityType.AutoSize = true;
            this.lblActivityType.Location = new System.Drawing.Point(185, 62);
            this.lblActivityType.Name = "lblActivityType";
            this.lblActivityType.Size = new System.Drawing.Size(61, 22);
            this.lblActivityType.TabIndex = 5;
            this.lblActivityType.Text = "نوع فعالیت:";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("B Mitra", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnSave.Location = new System.Drawing.Point(5, 107);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(125, 31);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "ثبت";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("B Mitra", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnEdit.Location = new System.Drawing.Point(136, 107);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(139, 31);
            this.btnEdit.TabIndex = 8;
            this.btnEdit.Text = "اصلاح";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("B Mitra", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnExit.Location = new System.Drawing.Point(548, 107);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(115, 31);
            this.btnExit.TabIndex = 10;
            this.btnExit.TabStop = false;
            this.btnExit.Text = "خروج";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // dgvMembers
            // 
            this.dgvMembers.AllowUserToAddRows = false;
            this.dgvMembers.AllowUserToDeleteRows = false;
            this.dgvMembers.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvMembers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("B Mitra", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMembers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMembers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gcId,
            this.gcFirstName,
            this.gcLastName,
            this.gcNationalCode,
            this.gcFatherName,
            this.gcCertiNumber,
            this.gcActivityType});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("B Mitra", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMembers.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMembers.Location = new System.Drawing.Point(5, 144);
            this.dgvMembers.MultiSelect = false;
            this.dgvMembers.Name = "dgvMembers";
            this.dgvMembers.ReadOnly = true;
            this.dgvMembers.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("B Mitra", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMembers.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvMembers.RowHeadersVisible = false;
            this.dgvMembers.RowHeadersWidth = 50;
            this.dgvMembers.RowTemplate.Height = 30;
            this.dgvMembers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMembers.ShowCellErrors = false;
            this.dgvMembers.ShowCellToolTips = false;
            this.dgvMembers.ShowEditingIcon = false;
            this.dgvMembers.ShowRowErrors = false;
            this.dgvMembers.Size = new System.Drawing.Size(657, 312);
            this.dgvMembers.TabIndex = 9;
            this.dgvMembers.TabStop = false;
            this.dgvMembers.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvMembers_CellFormatting);
            this.dgvMembers.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvMembers_CellMouseClick);
            // 
            // gcId
            // 
            this.gcId.DataPropertyName = "Id";
            this.gcId.FillWeight = 60F;
            this.gcId.HeaderText = "شناسه";
            this.gcId.Name = "gcId";
            this.gcId.ReadOnly = true;
            this.gcId.Width = 60;
            // 
            // gcFirstName
            // 
            this.gcFirstName.DataPropertyName = "FirstName";
            this.gcFirstName.FillWeight = 75F;
            this.gcFirstName.HeaderText = "نام";
            this.gcFirstName.Name = "gcFirstName";
            this.gcFirstName.ReadOnly = true;
            this.gcFirstName.Width = 75;
            // 
            // gcLastName
            // 
            this.gcLastName.DataPropertyName = "LastName";
            this.gcLastName.FillWeight = 110F;
            this.gcLastName.HeaderText = "نام خانوادگی";
            this.gcLastName.Name = "gcLastName";
            this.gcLastName.ReadOnly = true;
            this.gcLastName.Width = 110;
            // 
            // gcNationalCode
            // 
            this.gcNationalCode.DataPropertyName = "NationalCode";
            this.gcNationalCode.FillWeight = 90F;
            this.gcNationalCode.HeaderText = "کد ملی";
            this.gcNationalCode.Name = "gcNationalCode";
            this.gcNationalCode.ReadOnly = true;
            this.gcNationalCode.Width = 90;
            // 
            // gcFatherName
            // 
            this.gcFatherName.DataPropertyName = "FatherName";
            this.gcFatherName.FillWeight = 75F;
            this.gcFatherName.HeaderText = "نام پدر";
            this.gcFatherName.Name = "gcFatherName";
            this.gcFatherName.ReadOnly = true;
            this.gcFatherName.Width = 75;
            // 
            // gcCertiNumber
            // 
            this.gcCertiNumber.DataPropertyName = "CertiNumber";
            this.gcCertiNumber.FillWeight = 70F;
            this.gcCertiNumber.HeaderText = "ش ش";
            this.gcCertiNumber.Name = "gcCertiNumber";
            this.gcCertiNumber.ReadOnly = true;
            this.gcCertiNumber.Width = 70;
            // 
            // gcActivityType
            // 
            this.gcActivityType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.gcActivityType.DataPropertyName = "ActivityType";
            this.gcActivityType.HeaderText = "نوع فعالیت";
            this.gcActivityType.Name = "gcActivityType";
            this.gcActivityType.ReadOnly = true;
            // 
            // txtFirstName
            // 
            this.txtFirstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtFirstName.Location = new System.Drawing.Point(493, 10);
            this.txtFirstName.MaxLength = 300;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(114, 30);
            this.txtFirstName.TabIndex = 1;
            this.txtFirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtLastName
            // 
            this.txtLastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtLastName.Location = new System.Drawing.Point(237, 10);
            this.txtLastName.MaxLength = 300;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(179, 30);
            this.txtLastName.TabIndex = 2;
            this.txtLastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNationalCode
            // 
            this.txtNationalCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtNationalCode.Location = new System.Drawing.Point(7, 10);
            this.txtNationalCode.MaxLength = 10;
            this.txtNationalCode.Name = "txtNationalCode";
            this.txtNationalCode.Size = new System.Drawing.Size(172, 30);
            this.txtNationalCode.TabIndex = 3;
            this.txtNationalCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtFatherName
            // 
            this.txtFatherName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtFatherName.Location = new System.Drawing.Point(252, 58);
            this.txtFatherName.MaxLength = 300;
            this.txtFatherName.Name = "txtFatherName";
            this.txtFatherName.Size = new System.Drawing.Size(164, 30);
            this.txtFatherName.TabIndex = 5;
            this.txtFatherName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCretiNumber
            // 
            this.txtCretiNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtCretiNumber.Location = new System.Drawing.Point(493, 58);
            this.txtCretiNumber.MaxLength = 15;
            this.txtCretiNumber.Name = "txtCretiNumber";
            this.txtCretiNumber.Size = new System.Drawing.Size(114, 30);
            this.txtCretiNumber.TabIndex = 4;
            this.txtCretiNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cmbActivityType
            // 
            this.cmbActivityType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbActivityType.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbActivityType.ForeColor = System.Drawing.Color.DarkRed;
            this.cmbActivityType.FormattingEnabled = true;
            this.cmbActivityType.Items.AddRange(new object[] {
            "کوهنوردی",
            "شنا",
            "سوارکاری"});
            this.cmbActivityType.Location = new System.Drawing.Point(7, 58);
            this.cmbActivityType.Name = "cmbActivityType";
            this.cmbActivityType.Size = new System.Drawing.Size(172, 30);
            this.cmbActivityType.TabIndex = 6;
            // 
            // pnInfo
            // 
            this.pnInfo.BackColor = System.Drawing.Color.Gainsboro;
            this.pnInfo.Controls.Add(this.txtCretiNumber);
            this.pnInfo.Controls.Add(this.txtLastName);
            this.pnInfo.Controls.Add(this.txtFatherName);
            this.pnInfo.Controls.Add(this.lblFirstName);
            this.pnInfo.Controls.Add(this.txtFirstName);
            this.pnInfo.Controls.Add(this.lblFatherName);
            this.pnInfo.Controls.Add(this.txtNationalCode);
            this.pnInfo.Controls.Add(this.lblCretiNumber);
            this.pnInfo.Controls.Add(this.lblActivityType);
            this.pnInfo.Controls.Add(this.lblNationalCode);
            this.pnInfo.Controls.Add(this.lblLastName);
            this.pnInfo.Controls.Add(this.cmbActivityType);
            this.pnInfo.Location = new System.Drawing.Point(5, 5);
            this.pnInfo.Name = "pnInfo";
            this.pnInfo.Size = new System.Drawing.Size(657, 98);
            this.pnInfo.TabIndex = 0;
            this.pnInfo.TabStop = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("B Mitra", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnDelete.Location = new System.Drawing.Point(281, 107);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(139, 31);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "حذف";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(667, 461);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dgvMembers);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.pnInfo);
            this.Font = new System.Drawing.Font("B Mitra", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "برنامه ثبت نام در گروه ورزشی فجر نیر";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembers)).EndInit();
            this.pnInfo.ResumeLayout(false);
            this.pnInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblNationalCode;
        private System.Windows.Forms.Label lblCretiNumber;
        private System.Windows.Forms.Label lblFatherName;
        private System.Windows.Forms.Label lblActivityType;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridView dgvMembers;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtNationalCode;
        private System.Windows.Forms.TextBox txtFatherName;
        private System.Windows.Forms.TextBox txtCretiNumber;
        private System.Windows.Forms.ComboBox cmbActivityType;
        private System.Windows.Forms.Panel pnInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcId;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcNationalCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcFatherName;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcCertiNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcActivityType;
        private System.Windows.Forms.Button btnDelete;

    }
}

