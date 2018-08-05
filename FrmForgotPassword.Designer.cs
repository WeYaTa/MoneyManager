namespace MoneyManager
{
    partial class FrmForgotPassword
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnEnter = new System.Windows.Forms.Button();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.Lbl_Question = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.radioButtonEmail = new System.Windows.Forms.RadioButton();
            this.radioButtonID = new System.Windows.Forms.RadioButton();
            this.lblEmailDesc = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblSampingEmail = new System.Windows.Forms.Label();
            this.lblSampingID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Silver;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Location = new System.Drawing.Point(212, 263);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 31);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnEnter
            // 
            this.btnEnter.BackColor = System.Drawing.Color.Silver;
            this.btnEnter.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEnter.FlatAppearance.BorderSize = 0;
            this.btnEnter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnEnter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnEnter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEnter.Location = new System.Drawing.Point(131, 263);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(75, 31);
            this.btnEnter.TabIndex = 3;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = false;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // txtAnswer
            // 
            this.txtAnswer.Enabled = false;
            this.txtAnswer.Location = new System.Drawing.Point(96, 217);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(342, 22);
            this.txtAnswer.TabIndex = 2;
            this.txtAnswer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAnswer_KeyPress);
            // 
            // Lbl_Question
            // 
            this.Lbl_Question.AutoSize = true;
            this.Lbl_Question.Enabled = false;
            this.Lbl_Question.Location = new System.Drawing.Point(12, 197);
            this.Lbl_Question.Name = "Lbl_Question";
            this.Lbl_Question.Size = new System.Drawing.Size(77, 17);
            this.Lbl_Question.TabIndex = 28;
            this.Lbl_Question.Text = "Question : ";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(95, 172);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(235, 22);
            this.txtID.TabIndex = 1;
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            this.txtID.Leave += new System.EventHandler(this.txtID_Leave);
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Enabled = false;
            this.lblQuestion.Location = new System.Drawing.Point(95, 197);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(119, 17);
            this.lblQuestion.TabIndex = 35;
            this.lblQuestion.Text = "{Safety Question}";
            this.lblQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Enabled = false;
            this.lblAnswer.Location = new System.Drawing.Point(12, 220);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(78, 17);
            this.lblAnswer.TabIndex = 36;
            this.lblAnswer.Text = "Answer    : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(359, 17);
            this.label3.TabIndex = 37;
            this.label3.Text = "Your new password will be sent to your confirmed email.";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Enabled = false;
            this.lblEmail.Location = new System.Drawing.Point(12, 69);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(70, 17);
            this.lblEmail.TabIndex = 38;
            this.lblEmail.Text = "Email     : ";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Enabled = false;
            this.lblID.Location = new System.Drawing.Point(12, 175);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(77, 17);
            this.lblID.TabIndex = 39;
            this.lblID.Text = "ID            : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(379, 25);
            this.label6.TabIndex = 40;
            this.label6.Text = "Please choose one of the methods below :";
            // 
            // radioButtonEmail
            // 
            this.radioButtonEmail.AutoSize = true;
            this.radioButtonEmail.Location = new System.Drawing.Point(12, 39);
            this.radioButtonEmail.Name = "radioButtonEmail";
            this.radioButtonEmail.Size = new System.Drawing.Size(83, 21);
            this.radioButtonEmail.TabIndex = 41;
            this.radioButtonEmail.TabStop = true;
            this.radioButtonEmail.Text = "By Email";
            this.radioButtonEmail.UseVisualStyleBackColor = true;
            this.radioButtonEmail.CheckedChanged += new System.EventHandler(this.radioButtonEmail_CheckedChanged);
            // 
            // radioButtonID
            // 
            this.radioButtonID.AutoSize = true;
            this.radioButtonID.Location = new System.Drawing.Point(8, 145);
            this.radioButtonID.Name = "radioButtonID";
            this.radioButtonID.Size = new System.Drawing.Size(339, 21);
            this.radioButtonID.TabIndex = 42;
            this.radioButtonID.TabStop = true;
            this.radioButtonID.Text = "By ID (Question you typed when you registered) :";
            this.radioButtonID.UseVisualStyleBackColor = true;
            this.radioButtonID.CheckedChanged += new System.EventHandler(this.radioButtonID_CheckedChanged);
            // 
            // lblEmailDesc
            // 
            this.lblEmailDesc.AutoSize = true;
            this.lblEmailDesc.Enabled = false;
            this.lblEmailDesc.Location = new System.Drawing.Point(12, 91);
            this.lblEmailDesc.Name = "lblEmailDesc";
            this.lblEmailDesc.Size = new System.Drawing.Size(359, 17);
            this.lblEmailDesc.TabIndex = 37;
            this.lblEmailDesc.Text = "Your new password will be sent to your confirmed email.";
            // 
            // txtEmail
            // 
            this.txtEmail.Enabled = false;
            this.txtEmail.Location = new System.Drawing.Point(96, 66);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(234, 22);
            this.txtEmail.TabIndex = 0;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // lblSampingEmail
            // 
            this.lblSampingEmail.AutoSize = true;
            this.lblSampingEmail.Location = new System.Drawing.Point(337, 70);
            this.lblSampingEmail.Name = "lblSampingEmail";
            this.lblSampingEmail.Size = new System.Drawing.Size(0, 17);
            this.lblSampingEmail.TabIndex = 44;
            // 
            // lblSampingID
            // 
            this.lblSampingID.AutoSize = true;
            this.lblSampingID.Location = new System.Drawing.Point(337, 176);
            this.lblSampingID.Name = "lblSampingID";
            this.lblSampingID.Size = new System.Drawing.Size(0, 17);
            this.lblSampingID.TabIndex = 45;
            this.lblSampingID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 306);
            this.Controls.Add(this.lblSampingID);
            this.Controls.Add(this.lblSampingEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.radioButtonID);
            this.Controls.Add(this.radioButtonEmail);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblEmailDesc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.Lbl_Question);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmForgotPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Forgot Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.Label Lbl_Question;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton radioButtonEmail;
        private System.Windows.Forms.RadioButton radioButtonID;
        private System.Windows.Forms.Label lblEmailDesc;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblSampingEmail;
        private System.Windows.Forms.Label lblSampingID;
    }
}