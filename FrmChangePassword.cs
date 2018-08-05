using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MoneyManagerLibrary;

namespace MoneyManager
{
    public partial class FrmChangePassword : Form
    {
        User user = null;
        bool logout = false;

        public bool Run()
        {
            this.ShowDialog();
            return logout;
        }

        public FrmChangePassword(User import)
        {
            InitializeComponent();
            user = import;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtRetypePass.Text.Trim() == "" || txtRetypePass.Text.Contains(" "))
            {
                Lbl_PassInfo.Text = "Invalid";
                Lbl_PassInfo.Visible = true;
                Lbl_PassInfo.ForeColor = Color.Red;
            }
            else
            {
                if (txtRetypePass.Text != txtPassword.Text)
                {

                    Lbl_PassInfo.Text = "Wrong";
                    Lbl_PassInfo.Visible = true;
                    Lbl_PassInfo.ForeColor = Color.Red;
                }
                else
                {
                    Lbl_PassInfo.Text = "Correct";
                    Lbl_PassInfo.Visible = true;
                    Lbl_PassInfo.ForeColor = Color.Green;
                }
            }
        }

        private void txtReType_TextChanged(object sender, EventArgs e)
        {
            if (txtRetypePass.Text != txtPassword.Text)
            {
                Lbl_PassInfo.Text = "Wrong";
                Lbl_PassInfo.Visible = true;
                Lbl_PassInfo.ForeColor = Color.Red;
            }
            else if (txtRetypePass.Text == txtPassword.Text)
            {
                Lbl_PassInfo.Text = "Correct";
                Lbl_PassInfo.Visible = true;
                Lbl_PassInfo.ForeColor = Color.Green;
            }
            if (txtPassword.Text == "")
            {
                lblSampingPass.Text = "";
            }

            else if (txtPassword.TextLength < 6 || txtPassword.Text.Trim() == "" || txtPassword.Text.Contains(" "))
            {
                lblSampingPass.Text = "Invalid";
                lblSampingPass.ForeColor = Color.Red;
                txtPassword.Focus();
            }
            else
            {
                lblSampingPass.Text = "Valid";
                lblSampingPass.ForeColor = Color.Green;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtOldPass.Text.Trim() == "" || txtPassword.Text.Trim() == "" || txtRetypePass.Text.Trim() == "")
            {
                MessageBox.Show("Fill in the required datas !", this.Text, MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else if (txtOldPass.Text != user.Password)
            {
                MessageBox.Show("Wrong old password !", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (lblSampingPass.Text == "Invalid")
            {
                MessageBox.Show("Invalid password! (No spaces, above 6 characters)", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (Lbl_PassInfo.Text == "Wrong")
            {
                MessageBox.Show("Retype pass invalid", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult dialog = MessageBox.Show("Confirm Changes?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    user.Password = txtPassword.Text;
                    using (var userdao = new UserDAO())
                    {
                        userdao.UpdatePassword(user);
                    }
                    logout = true;
                    this.Close();
                }
                else
                {
                    logout = false;
                }
            }
        }

        private void checkBoxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowPass.Checked == true)
            {
                txtPassword.PasswordChar = '\0';
                txtRetypePass.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
                txtRetypePass.PasswordChar = '*';
            }
        }
    }
}
