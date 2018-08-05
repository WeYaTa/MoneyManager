using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoneyManager
{
    public partial class FrmChangePassword : Form
    {
        public FrmChangePassword()
        {
            InitializeComponent();
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
    }
}
