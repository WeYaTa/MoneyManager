namespace MoneyManager
{
    partial class FrmAddTransaction
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
            this.lblJudul = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBoxAmount = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.dtpAdd = new System.Windows.Forms.DateTimePicker();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCncl = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lblTextCount = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblJudul
            // 
            this.lblJudul.AutoSize = true;
            this.lblJudul.Font = new System.Drawing.Font("Ravie", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJudul.Location = new System.Drawing.Point(23, 19);
            this.lblJudul.Name = "lblJudul";
            this.lblJudul.Size = new System.Drawing.Size(402, 44);
            this.lblJudul.TabIndex = 0;
            this.lblJudul.Text = "Add Transaction";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Amount     :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Category   :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Date          :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Note          :";
            // 
            // txtBoxAmount
            // 
            this.txtBoxAmount.Location = new System.Drawing.Point(163, 75);
            this.txtBoxAmount.Name = "txtBoxAmount";
            this.txtBoxAmount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtBoxAmount.Size = new System.Drawing.Size(201, 22);
            this.txtBoxAmount.TabIndex = 5;
            this.txtBoxAmount.Text = "0";
            this.txtBoxAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBoxAmount.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtBoxAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "<select Category>"});
            this.comboBox1.Location = new System.Drawing.Point(136, 102);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.Enabled = false;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(272, 102);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 24);
            this.comboBox2.TabIndex = 7;
            // 
            // dtpAdd
            // 
            this.dtpAdd.Enabled = false;
            this.dtpAdd.Location = new System.Drawing.Point(136, 132);
            this.dtpAdd.Name = "dtpAdd";
            this.dtpAdd.Size = new System.Drawing.Size(257, 22);
            this.dtpAdd.TabIndex = 8;
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(136, 158);
            this.txtNote.MaxLength = 160;
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(257, 118);
            this.txtNote.TabIndex = 9;
            this.txtNote.TextChanged += new System.EventHandler(this.txtNote_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(133, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Rp.";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(163, 299);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 42);
            this.btnConfirm.TabIndex = 11;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCncl
            // 
            this.btnCncl.Location = new System.Drawing.Point(272, 299);
            this.btnCncl.Name = "btnCncl";
            this.btnCncl.Size = new System.Drawing.Size(75, 42);
            this.btnCncl.TabIndex = 12;
            this.btnCncl.Text = "Cancel";
            this.btnCncl.UseVisualStyleBackColor = true;
            this.btnCncl.Click += new System.EventHandler(this.btnCncl_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(361, 278);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "/160";
            // 
            // lblTextCount
            // 
            this.lblTextCount.AutoSize = true;
            this.lblTextCount.Location = new System.Drawing.Point(332, 278);
            this.lblTextCount.Name = "lblTextCount";
            this.lblTextCount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTextCount.Size = new System.Drawing.Size(16, 17);
            this.lblTextCount.TabIndex = 14;
            this.lblTextCount.Text = "0";
            this.lblTextCount.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(364, 78);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 17);
            this.label9.TabIndex = 15;
            this.label9.Text = ",00-";
            // 
            // FrmAddTransaction
            // 
            this.ClientSize = new System.Drawing.Size(459, 353);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblTextCount);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnCncl);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.dtpAdd);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtBoxAmount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblJudul);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmAddTransaction";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAddTransaction";
            this.Load += new System.EventHandler(this.FrmAddTransaction_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblJudul;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBoxAmount;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.DateTimePicker dtpAdd;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCncl;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblTextCount;
        private System.Windows.Forms.Label label9;
    }
}