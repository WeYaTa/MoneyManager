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
    public partial class FrmManageProfile : Form
    {
        User user = null;
        bool logout = false;

        public bool Run() {
            this.ShowDialog();
            return logout;
        }

        public FrmManageProfile(User import)
        {
            InitializeComponent();
            user = import;
            txtNama.Text = user.Name;
            txtId.Text = user.ID;
            txtEmail.Text = user.Email;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmChangePassword form = new FrmChangePassword(user);
            logout = form.Run();
            if (logout)
            {
                this.Close();
            }
            else
            {
                this.Show();
            }
            
        }

        private void FrmManageProfile_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            logout = false;
            this.Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtNama.Text.Trim() == "" || txtEmail.Text.Trim() == "")
            {
                MessageBox.Show("Please fill in the required datas !", this.Text, MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            
            else if (lblSampingEmail.Text == "Invalid")
            {
                MessageBox.Show("Email is not valid or used by another account!", this.Text, MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            
            else
            {
                user.Name = txtNama.Text;
                user.Email = txtEmail.Text;
                try
                {
                    using (var userdao = new UserDAO())
                    {
                        userdao.Update(user);
                    }
                    MessageBox.Show("Update success !", this.Text, MessageBoxButtons.OK,MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                logout = true;
            }
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
                User validate = userdao.GetUserDataByEmail(txtEmail.Text);
                if (validate != null)
                {
                    if (!EmailIsValid(this.txtEmail.Text) || (validate.ID != user.ID))
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
                else
                {
                    if (!EmailIsValid(this.txtEmail.Text))
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
        }
    }
}
