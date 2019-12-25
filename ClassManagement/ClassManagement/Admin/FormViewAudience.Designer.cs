namespace ClassManagement.Admin {
	partial class FormViewAudience {
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
			this.dataGridView = new System.Windows.Forms.DataGridView();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolStripButtonAdd = new System.Windows.Forms.ToolStripButton();
			this.toolStripButtonEdit = new System.Windows.Forms.ToolStripButton();
			this.toolStripButtonShow = new System.Windows.Forms.ToolStripButton();
			this.toolStripButtonBlock = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.checkBoxBlock = new System.Windows.Forms.CheckBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// dataGridView
			// 
			this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView.Location = new System.Drawing.Point(13, 53);
			this.dataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.dataGridView.Name = "dataGridView";
			this.dataGridView.Size = new System.Drawing.Size(958, 608);
			this.dataGridView.TabIndex = 2;
			// 
			// toolStrip1
			// 
			this.toolStrip1.AutoSize = false;
			this.toolStrip1.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonAdd,
            this.toolStripButtonEdit,
            this.toolStripButtonShow,
            this.toolStripButtonBlock,
            this.toolStripSeparator1});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
			this.toolStrip1.Size = new System.Drawing.Size(984, 49);
			this.toolStrip1.TabIndex = 3;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// toolStripButtonAdd
			// 
			this.toolStripButtonAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripButtonAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonAdd.Name = "toolStripButtonAdd";
			this.toolStripButtonAdd.Size = new System.Drawing.Size(70, 46);
			this.toolStripButtonAdd.Text = "Добавить";
			this.toolStripButtonAdd.Click += new System.EventHandler(this.toolStripButtonAdd_Click);
			// 
			// toolStripButtonEdit
			// 
			this.toolStripButtonEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripButtonEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonEdit.Name = "toolStripButtonEdit";
			this.toolStripButtonEdit.Size = new System.Drawing.Size(100, 46);
			this.toolStripButtonEdit.Text = "Редактировать";
			this.toolStripButtonEdit.Click += new System.EventHandler(this.toolStripButtonEdit_Click);
			// 
			// toolStripButtonShow
			// 
			this.toolStripButtonShow.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripButtonShow.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonShow.Name = "toolStripButtonShow";
			this.toolStripButtonShow.Size = new System.Drawing.Size(71, 46);
			this.toolStripButtonShow.Text = "Показать ";
			this.toolStripButtonShow.Click += new System.EventHandler(this.toolStripButtonShow_Click);
			// 
			// toolStripButtonBlock
			// 
			this.toolStripButtonBlock.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripButtonBlock.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonBlock.Name = "toolStripButtonBlock";
			this.toolStripButtonBlock.Size = new System.Drawing.Size(104, 46);
			this.toolStripButtonBlock.Text = "Заблокировать";
			this.toolStripButtonBlock.Click += new System.EventHandler(this.toolStripButtonBlock_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 49);
			// 
			// checkBoxBlock
			// 
			this.checkBoxBlock.AutoSize = true;
			this.checkBoxBlock.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.checkBoxBlock.Location = new System.Drawing.Point(366, 13);
			this.checkBoxBlock.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.checkBoxBlock.Name = "checkBoxBlock";
			this.checkBoxBlock.Size = new System.Drawing.Size(213, 20);
			this.checkBoxBlock.TabIndex = 4;
			this.checkBoxBlock.Text = "Показать заблокирпованые";
			this.checkBoxBlock.UseVisualStyleBackColor = false;
			this.checkBoxBlock.CheckedChanged += new System.EventHandler(this.checkBoxBlock_CheckedChanged);
			// 
			// FormViewAudience
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(984, 672);
			this.Controls.Add(this.checkBoxBlock);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.dataGridView);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "FormViewAudience";
			this.Text = "FormViewAudience";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonEdit;
        private System.Windows.Forms.ToolStripButton toolStripButtonBlock;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.CheckBox checkBoxBlock;
        private System.Windows.Forms.ToolStripButton toolStripButtonAdd;
        private System.Windows.Forms.ToolStripButton toolStripButtonShow;
    }
}