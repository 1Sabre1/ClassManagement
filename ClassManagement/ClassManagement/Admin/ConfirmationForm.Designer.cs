namespace ClassManagement {
	partial class ConfirmationForm {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.Column_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnTeachers = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnStatus = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.dataGridView2 = new System.Windows.Forms.DataGridView();
			this.BT_denial = new System.Windows.Forms.Button();
			this.BT_confirm = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.comboBoxUsers = new System.Windows.Forms.ComboBox();
			this.checkBoxUsers = new System.Windows.Forms.CheckBox();
			this.checkBoxDate = new System.Windows.Forms.CheckBox();
			this.comboBoxCategories = new System.Windows.Forms.ComboBox();
			this.checkBoxCategories = new System.Windows.Forms.CheckBox();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.buttonSerch = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.comboBoxLessonNumber = new System.Windows.Forms.ComboBox();
			this.checkBoxLessonNumber = new System.Windows.Forms.CheckBox();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.tabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(759, 584);
			this.tabControl1.TabIndex = 1;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.dataGridView1);
			this.tabPage1.Location = new System.Drawing.Point(4, 25);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(751, 555);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Новые уведомления";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_Date,
            this.ColumnTime,
            this.ColumnCount,
            this.ColumnNumber,
            this.ColumnTeachers,
            this.ColumnStatus});
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView1.Location = new System.Drawing.Point(3, 3);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(745, 549);
			this.dataGridView1.TabIndex = 0;
			// 
			// Column_Date
			// 
			this.Column_Date.HeaderText = "Дата занятия";
			this.Column_Date.Name = "Column_Date";
			this.Column_Date.Width = 120;
			// 
			// ColumnTime
			// 
			this.ColumnTime.HeaderText = "Время";
			this.ColumnTime.Name = "ColumnTime";
			// 
			// ColumnCount
			// 
			this.ColumnCount.HeaderText = "К-во студентов";
			this.ColumnCount.Name = "ColumnCount";
			this.ColumnCount.Width = 160;
			// 
			// ColumnNumber
			// 
			this.ColumnNumber.HeaderText = "№ ауд.";
			this.ColumnNumber.Name = "ColumnNumber";
			// 
			// ColumnTeachers
			// 
			this.ColumnTeachers.HeaderText = "Преподаватель";
			this.ColumnTeachers.Name = "ColumnTeachers";
			this.ColumnTeachers.Width = 120;
			// 
			// ColumnStatus
			// 
			this.ColumnStatus.HeaderText = "Статус";
			this.ColumnStatus.Name = "ColumnStatus";
			this.ColumnStatus.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.ColumnStatus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.dataGridView2);
			this.tabPage2.Location = new System.Drawing.Point(4, 25);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(751, 555);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "История";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// dataGridView2
			// 
			this.dataGridView2.AllowUserToDeleteRows = false;
			this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView2.Location = new System.Drawing.Point(3, 3);
			this.dataGridView2.Name = "dataGridView2";
			this.dataGridView2.Size = new System.Drawing.Size(745, 549);
			this.dataGridView2.TabIndex = 1;
			// 
			// BT_denial
			// 
			this.BT_denial.AutoSize = true;
			this.BT_denial.Location = new System.Drawing.Point(287, 590);
			this.BT_denial.Name = "BT_denial";
			this.BT_denial.Size = new System.Drawing.Size(150, 26);
			this.BT_denial.TabIndex = 2;
			this.BT_denial.Text = "Отклонить";
			this.BT_denial.UseVisualStyleBackColor = true;
			this.BT_denial.Click += new System.EventHandler(this.BT_denial_Click);
			// 
			// BT_confirm
			// 
			this.BT_confirm.AutoSize = true;
			this.BT_confirm.Location = new System.Drawing.Point(443, 590);
			this.BT_confirm.Name = "BT_confirm";
			this.BT_confirm.Size = new System.Drawing.Size(150, 26);
			this.BT_confirm.TabIndex = 3;
			this.BT_confirm.Text = "Подтвердить";
			this.BT_confirm.UseVisualStyleBackColor = true;
			this.BT_confirm.Click += new System.EventHandler(this.BT_confirm_Click);
			// 
			// button3
			// 
			this.button3.AutoSize = true;
			this.button3.Location = new System.Drawing.Point(599, 590);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(150, 26);
			this.button3.TabIndex = 4;
			this.button3.Text = "Объеденить";
			this.button3.UseVisualStyleBackColor = true;
			// 
			// comboBoxUsers
			// 
			this.comboBoxUsers.FormattingEnabled = true;
			this.comboBoxUsers.Location = new System.Drawing.Point(776, 51);
			this.comboBoxUsers.Name = "comboBoxUsers";
			this.comboBoxUsers.Size = new System.Drawing.Size(177, 24);
			this.comboBoxUsers.TabIndex = 103;
			// 
			// checkBoxUsers
			// 
			this.checkBoxUsers.AutoSize = true;
			this.checkBoxUsers.Location = new System.Drawing.Point(776, 28);
			this.checkBoxUsers.Name = "checkBoxUsers";
			this.checkBoxUsers.Size = new System.Drawing.Size(131, 20);
			this.checkBoxUsers.TabIndex = 102;
			this.checkBoxUsers.Text = "Преподователь";
			this.checkBoxUsers.UseVisualStyleBackColor = true;
			this.checkBoxUsers.CheckedChanged += new System.EventHandler(this.checkBoxUsers_CheckedChanged);
			// 
			// checkBoxDate
			// 
			this.checkBoxDate.AutoSize = true;
			this.checkBoxDate.Location = new System.Drawing.Point(776, 143);
			this.checkBoxDate.Name = "checkBoxDate";
			this.checkBoxDate.Size = new System.Drawing.Size(59, 20);
			this.checkBoxDate.TabIndex = 100;
			this.checkBoxDate.Text = "Дата";
			this.checkBoxDate.UseVisualStyleBackColor = true;
			this.checkBoxDate.CheckedChanged += new System.EventHandler(this.checkBoxDate_CheckedChanged);
			// 
			// comboBoxCategories
			// 
			this.comboBoxCategories.FormattingEnabled = true;
			this.comboBoxCategories.Location = new System.Drawing.Point(776, 104);
			this.comboBoxCategories.Name = "comboBoxCategories";
			this.comboBoxCategories.Size = new System.Drawing.Size(177, 24);
			this.comboBoxCategories.TabIndex = 98;
			// 
			// checkBoxCategories
			// 
			this.checkBoxCategories.AutoSize = true;
			this.checkBoxCategories.Location = new System.Drawing.Point(776, 81);
			this.checkBoxCategories.Name = "checkBoxCategories";
			this.checkBoxCategories.Size = new System.Drawing.Size(109, 20);
			this.checkBoxCategories.TabIndex = 97;
			this.checkBoxCategories.Text = "Тип занятий";
			this.checkBoxCategories.UseVisualStyleBackColor = true;
			this.checkBoxCategories.CheckedChanged += new System.EventHandler(this.checkBoxCategories_CheckedChanged);
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Location = new System.Drawing.Point(776, 166);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(177, 22);
			this.dateTimePicker1.TabIndex = 96;
			// 
			// buttonSerch
			// 
			this.buttonSerch.Location = new System.Drawing.Point(776, 277);
			this.buttonSerch.Name = "buttonSerch";
			this.buttonSerch.Size = new System.Drawing.Size(80, 29);
			this.buttonSerch.TabIndex = 92;
			this.buttonSerch.Text = "OK";
			this.buttonSerch.UseVisualStyleBackColor = true;
			this.buttonSerch.Click += new System.EventHandler(this.buttonSerch_Click);
			// 
			// buttonCancel
			// 
			this.buttonCancel.Location = new System.Drawing.Point(873, 277);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(80, 29);
			this.buttonCancel.TabIndex = 93;
			this.buttonCancel.Text = "Cancel";
			this.buttonCancel.UseVisualStyleBackColor = true;
			// 
			// comboBoxLessonNumber
			// 
			this.comboBoxLessonNumber.FormattingEnabled = true;
			this.comboBoxLessonNumber.Location = new System.Drawing.Point(776, 232);
			this.comboBoxLessonNumber.Name = "comboBoxLessonNumber";
			this.comboBoxLessonNumber.Size = new System.Drawing.Size(177, 24);
			this.comboBoxLessonNumber.TabIndex = 105;
			// 
			// checkBoxLessonNumber
			// 
			this.checkBoxLessonNumber.AutoSize = true;
			this.checkBoxLessonNumber.Location = new System.Drawing.Point(776, 209);
			this.checkBoxLessonNumber.Name = "checkBoxLessonNumber";
			this.checkBoxLessonNumber.Size = new System.Drawing.Size(106, 20);
			this.checkBoxLessonNumber.TabIndex = 104;
			this.checkBoxLessonNumber.Text = "Номер пары";
			this.checkBoxLessonNumber.UseVisualStyleBackColor = true;
			this.checkBoxLessonNumber.CheckedChanged += new System.EventHandler(this.checkBoxLessonNumber_CheckedChanged);
			// 
			// ConfirmationForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(975, 628);
			this.Controls.Add(this.comboBoxLessonNumber);
			this.Controls.Add(this.checkBoxLessonNumber);
			this.Controls.Add(this.comboBoxUsers);
			this.Controls.Add(this.checkBoxUsers);
			this.Controls.Add(this.checkBoxDate);
			this.Controls.Add(this.comboBoxCategories);
			this.Controls.Add(this.checkBoxCategories);
			this.Controls.Add(this.dateTimePicker1);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonSerch);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.BT_confirm);
			this.Controls.Add(this.BT_denial);
			this.Controls.Add(this.tabControl1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "ConfirmationForm";
			this.Text = "Запросы";
			this.Load += new System.EventHandler(this.ConfirmationForm_Load);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.tabPage2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button BT_denial;
        private System.Windows.Forms.Button BT_confirm;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox comboBoxUsers;
        private System.Windows.Forms.CheckBox checkBoxUsers;
        private System.Windows.Forms.CheckBox checkBoxDate;
        private System.Windows.Forms.ComboBox comboBoxCategories;
        private System.Windows.Forms.CheckBox checkBoxCategories;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button buttonSerch;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.ComboBox comboBoxLessonNumber;
        private System.Windows.Forms.CheckBox checkBoxLessonNumber;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column_Date;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTime;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCount;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNumber;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTeachers;
		private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnStatus;
	}
}