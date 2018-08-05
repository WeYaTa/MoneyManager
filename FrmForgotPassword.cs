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
using System.Text.RegularExpressions;

namespace MoneyManager
{
    public partial class FrmForgotPassword : Form
    {
        public FrmForgotPassword()
        {
            InitializeComponent();
        }

        private void radioButtonEmail_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonEmail.Checked == true)
            {
                txtEmail.Enabled = true;
                lblEmail.Enabled = true;
                lblEmailDesc.Enabled = true;
                //
                txtAnswer.Enabled = false;
                txtID.Enabled = false;
                lblID.Enabled = false;
                lblQuestion.Enabled = false;
                Lbl_Question.Enabled = false;
                lblAnswer.Enabled = false;
                lblSampingID.Text = "";
            }
        }

        private void radioButtonID_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonID.Checked == true)
            {
                txtEmail.Enabled = false;
                lblEmail.Enabled = false;
                lblEmailDesc.Enabled = false;
                lblSampingEmail.Text = "";
                //
                txtAnswer.Enabled = true;
                txtID.Enabled = true;
                lblID.Enabled = true;
                lblQuestion.Enabled = true;
                Lbl_Question.Enabled = true;
                lblAnswer.Enabled = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool EmailIsValid(string emailAddr)
        {
            string emailPattern1 = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
            Regex regex = new Regex(emailPattern1);
            Match match = regex.Match(emailAddr);
            return match.Success;
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            using (var userdao = new UserDAO())
            {
                if (!EmailIsValid(this.txtEmail.Text) || userdao.GetUserDataByEmail(this.txtEmail.Text) == null)
                {
                    lblSampingEmail.Text = "Invalid";
                    lblSampingEmail.ForeColor = Color.Red;
                }

                else
                {
                    lblSampingEmail.Text = "Valid";
                    lblSampingEmail.ForeColor = Color.Green;
                }
            }
        }

        private void txtID_Leave(object sender, EventArgs e)
        {
            try
            {
                using (var userdao = new UserDAO())
                {
                    User f = userdao.GetUserDataByID(txtID.Text.Trim());
                    if (lblSampingID.Text == "Valid")
                    {
                        if (f.Question.Trim() != "")
                        {
                            lblQuestion.Text = f.Question.Trim();
                        }
                        else
                        {
                            MessageBox.Show("No Safety Question found !", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtID.Clear();
                            lblQuestion.Text = "{Safety Question}";
                        }
                    }
                }
                
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            using (var userdao = new UserDAO())
            {
                if (userdao.GetUserDataByID(txtID.Text.Trim()) == null)
                {
                    lblSampingID.Text = "Invalid";
                    lblSampingID.ForeColor = Color.Red;
                    txtID.Focus();
                }
                else
                {
                    if (txtID.TextLength < 6 || txtID.Text.Trim() == "" || txtID.Text.Contains(" "))
                    {
                        lblSampingID.Text = "Invalid";
                        lblSampingID.ForeColor = Color.Red;
                        txtID.Focus();
                    }
                    else
                    {
                        lblSampingID.Text = "Valid";
                        lblSampingID.ForeColor = Color.Green;
                    }

                }
            }
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (radioButtonID.Checked == true)
            {
                try
                {
                    User user = null;
                    using (var userdao = new UserDAO())
                    {
                        user = userdao.GetUserDataByID(txtID.Text);
                        if (user == null)
                        {
                            MessageBox.Show("ID not found !", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            if (txtAnswer.Text == user.Answer.ToString())
                            {
                                MessageBox.Show("Your password : " + user.Password, "Verification Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                userdao.Dispose();
                                btnCancel_Click(null, null);
                            }
                            else
                            {
                                MessageBox.Show("Wrong Answer!", "Verification Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {

                    throw ex;
                }
            }
            else if (radioButtonEmail.Checked == true)
            {
                if (lblSampingEmail.Text != "Valid")
                {
                    MessageBox.Show("Email not found !",this.Text, MessageBoxButtons.OK,MessageBoxIcon.Information);
                    txtEmail.Clear();
                }
                else
                {
                    MessageBox.Show("Email has been sent !", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            
        }

        private void txtAnswer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnEnter_Click(null, null);
            }
        }
    }
}
