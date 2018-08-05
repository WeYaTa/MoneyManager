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
    public partial class FrmDeleteAccount : Form
    {
        User user = null;
        bool Boolean = false;

        public bool Run() {
            this.ShowDialog();
            return Boolean;
        }

        public FrmDeleteAccount(User import)
        {
            InitializeComponent();
            user = import;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (txtDelete.Text.Trim() == "")
            {
                MessageBox.Show("Please type the required string !", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtDelete.Text != "DELETE MY ACCOUNT")
            {
                MessageBox.Show("Confirmation string is wrong ! Remember to use capslock. ", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtDelete.Text == "DELETE MY ACCOUNT")
            {
                try
                {
                    using (var transdao = new TransactionDAO())
                    {
                        transdao.DeleteAllTransactionsByID(user.ID);
                    }
                    using (var userdao = new UserDAO())
                    {
                        userdao.Delete(user);
                    }

                    MessageBox.Show("Account Deleted !", this.Text, MessageBoxButtons.OK,MessageBoxIcon.Information);
                    Boolean = true;
                    this.Close();
                }
                catch (Exception ex)
                {

                    throw ex;
                }
            }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Boolean = false;
            this.Close();
        }
    }
}
