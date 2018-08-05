namespace MoneyManager
{
    partial class FrmDetailTransaksi
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRange2 = new System.Windows.Forms.TextBox();
            this.checkBoxRange = new System.Windows.Forms.CheckBox();
            this.txtRange1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.checkBoxSubCat = new System.Windows.Forms.CheckBox();
            this.checkBoxCategory = new System.Windows.Forms.CheckBox();
            this.coBoxCategory = new System.Windows.Forms.ComboBox();
            this.coBoxSubCat = new System.Windows.Forms.ComboBox();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lblDate);
            this.splitContainer1.Panel1.Controls.Add(this.lblResult);
            this.splitContainer1.Panel1.Controls.Add(this.btnSearch);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.txtRange2);
            this.splitContainer1.Panel1.Controls.Add(this.checkBoxRange);
            this.splitContainer1.Panel1.Controls.Add(this.txtRange1);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.btnBack);
            this.splitContainer1.Panel1.Controls.Add(this.btnRefresh);
            this.splitContainer1.Panel1.Controls.Add(this.btnDelete);
            this.splitContainer1.Panel1.Controls.Add(this.btnEdit);
            this.splitContainer1.Panel1.Controls.Add(this.checkBoxSubCat);
            this.splitContainer1.Panel1.Controls.Add(this.checkBoxCategory);
            this.splitContainer1.Panel1.Controls.Add(this.coBoxCategory);
            this.splitContainer1.Panel1.Controls.Add(this.coBoxSubCat);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvData);
            this.splitContainer1.Size = new System.Drawing.Size(820, 561);
            this.splitContainer1.SplitterDistance = 194;
            this.splitContainer1.TabIndex = 0;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(3, 174);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(156, 17);
            this.lblDate.TabIndex = 37;
            this.lblDate.Text = "Transactions on Date : ";
            // 
            // lblResult
            // 
            this.lblResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblResult.Location = new System.Drawing.Point(688, 171);
            this.lblResult.Name = "lblResult";
            this.lblResult.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblResult.Size = new System.Drawing.Size(129, 23);
            this.lblResult.TabIndex = 36;
            this.lblResult.Text = "X Result";
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Location = new System.Drawing.Point(606, 135);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(202, 22);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Location = new System.Drawing.Point(313, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 17);
            this.label2.TabIndex = 34;
            this.label2.Text = "-";
            // 
            // txtRange2
            // 
            this.txtRange2.Enabled = false;
            this.txtRange2.Location = new System.Drawing.Point(328, 134);
            this.txtRange2.Name = "txtRange2";
            this.txtRange2.Size = new System.Drawing.Size(169, 22);
            this.txtRange2.TabIndex = 1;
            this.txtRange2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtRange2.TextChanged += new System.EventHandler(this.txtRange2_TextChanged);
            this.txtRange2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRange2_KeyPress);
            // 
            // checkBoxRange
            // 
            this.checkBoxRange.AutoSize = true;
            this.checkBoxRange.ForeColor = System.Drawing.Color.Gray;
            this.checkBoxRange.Location = new System.Drawing.Point(12, 136);
            this.checkBoxRange.Name = "checkBoxRange";
            this.checkBoxRange.Size = new System.Drawing.Size(124, 21);
            this.checkBoxRange.TabIndex = 32;
            this.checkBoxRange.Text = "Amount Range";
            this.checkBoxRange.UseVisualStyleBackColor = true;
            this.checkBoxRange.CheckedChanged += new System.EventHandler(this.checkBoxRange_CheckedChanged);
            // 
            // txtRange1
            // 
            this.txtRange1.Enabled = false;
            this.txtRange1.Location = new System.Drawing.Point(142, 134);
            this.txtRange1.Name = "txtRange1";
            this.txtRange1.Size = new System.Drawing.Size(169, 22);
            this.txtRange1.TabIndex = 0;
            this.txtRange1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtRange1.TextChanged += new System.EventHandler(this.txtRange1_TextChanged);
            this.txtRange1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRange1_KeyPress);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(820, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Filter Methods :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.Location = new System.Drawing.Point(710, 34);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(98, 36);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.Location = new System.Drawing.Point(606, 35);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(98, 36);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Location = new System.Drawing.Point(710, 84);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(98, 36);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete Row";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.Location = new System.Drawing.Point(606, 84);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(98, 36);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "Edit Row";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // checkBoxSubCat
            // 
            this.checkBoxSubCat.AutoSize = true;
            this.checkBoxSubCat.ForeColor = System.Drawing.Color.Gray;
            this.checkBoxSubCat.Location = new System.Drawing.Point(12, 93);
            this.checkBoxSubCat.Name = "checkBoxSubCat";
            this.checkBoxSubCat.Size = new System.Drawing.Size(112, 21);
            this.checkBoxSubCat.TabIndex = 26;
            this.checkBoxSubCat.Text = "SubCategory";
            this.checkBoxSubCat.UseVisualStyleBackColor = true;
            this.checkBoxSubCat.CheckedChanged += new System.EventHandler(this.checkBoxSubCat_CheckedChanged);
            // 
            // checkBoxCategory
            // 
            this.checkBoxCategory.AutoSize = true;
            this.checkBoxCategory.ForeColor = System.Drawing.Color.Gray;
            this.checkBoxCategory.Location = new System.Drawing.Point(12, 49);
            this.checkBoxCategory.Name = "checkBoxCategory";
            this.checkBoxCategory.Size = new System.Drawing.Size(87, 21);
            this.checkBoxCategory.TabIndex = 25;
            this.checkBoxCategory.Text = "Category";
            this.checkBoxCategory.UseVisualStyleBackColor = true;
            this.checkBoxCategory.CheckedChanged += new System.EventHandler(this.checkBoxCategory_CheckedChanged);
            // 
            // coBoxCategory
            // 
            this.coBoxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.coBoxCategory.Enabled = false;
            this.coBoxCategory.FormattingEnabled = true;
            this.coBoxCategory.Location = new System.Drawing.Point(142, 47);
            this.coBoxCategory.Name = "coBoxCategory";
            this.coBoxCategory.Size = new System.Drawing.Size(169, 24);
            this.coBoxCategory.TabIndex = 24;
            this.coBoxCategory.SelectedIndexChanged += new System.EventHandler(this.coBoxCategory_SelectedIndexChanged);
            // 
            // coBoxSubCat
            // 
            this.coBoxSubCat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.coBoxSubCat.Enabled = false;
            this.coBoxSubCat.FormattingEnabled = true;
            this.coBoxSubCat.Location = new System.Drawing.Point(142, 91);
            this.coBoxSubCat.Name = "coBoxSubCat";
            this.coBoxSubCat.Size = new System.Drawing.Size(169, 24);
            this.coBoxSubCat.TabIndex = 23;
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Category,
            this.SubCategory,
            this.Amount,
            this.Note});
            this.dgvData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvData.Location = new System.Drawing.Point(0, 0);
            this.dgvData.MultiSelect = false;
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.RowTemplate.Height = 24;
            this.dgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvData.Size = new System.Drawing.Size(820, 363);
            this.dgvData.TabIndex = 1;
            // 
            // Category
            // 
            this.Category.HeaderText = "Category";
            this.Category.Name = "Category";
            this.Category.ReadOnly = true;
            // 
            // SubCategory
            // 
            this.SubCategory.HeaderText = "SubCategory";
            this.SubCategory.Name = "SubCategory";
            this.SubCategory.ReadOnly = true;
            // 
            // Amount
            // 
            this.Amount.HeaderText = "Amount (Rp)";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            // 
            // Note
            // 
            this.Note.HeaderText = "Note";
            this.Note.Name = "Note";
            this.Note.ReadOnly = true;
            // 
            // FrmDetailTransaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 561);
            this.ControlBox = false;
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmDetailTransaksi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmDetailTransaksi";
            this.Load += new System.EventHandler(this.FrmDetailTransaksi_Load);
            this.Resize += new System.EventHandler(this.FrmDetailTransaksi_Resize);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.CheckBox checkBoxSubCat;
        private System.Windows.Forms.CheckBox checkBoxCategory;
        private System.Windows.Forms.ComboBox coBoxCategory;
        private System.Windows.Forms.ComboBox coBoxSubCat;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRange1;
        private System.Windows.Forms.CheckBox checkBoxRange;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRange2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Note;
    }
}