using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MoneyManagerLibrary;

namespace MoneyManager
{
    public partial class FrmAddTransaction : Form
    {
        bool EditMode = false;
        List<string> ComboB1 = new List<string>();
        List<string> ComboIncome = null;
        List<string> ComboExpense = null;
        Transaction Edit = null;
        double[] InCat = { 20_000_000, 10_000_000, 2_000_000, 2_000_000, 500_000, 1_000_000 };
        double[] ExCat = {1_000_000, 1_000_000, 1_000_000, 200_000, 500_000, 500_000, 1_000_000, 250_000,
                          100_000, 1_000_000, 2_500_000, 20_000_000, 10_000_000, 20_000_000, 1_000_000, 1_000_000};
        User user = null;

        public FrmAddTransaction(User ImportUser, List<string> comboin, List<string> comboex, bool editmode = false,Transaction edit = null)
        {
            InitializeComponent();
            user = ImportUser;
            // Category
            ComboB1.Add("<Select>");
            ComboB1.Add("Income");
            ComboB1.Add("Expense");
            comboBox1.DataSource = ComboB1;
            ComboIncome = comboin;
            ComboExpense = comboex;
            EditMode = editmode;

            if (EditMode)
            {
                txtBoxAmount.Text = edit.Amount.ToString("n0");
                comboBox1.SelectedItem = edit.Category.ToString();
                comboBox2.SelectedItem = edit.SubCategory.ToString();
                dtpAdd.Text = edit.Date.ToString();
                dtpAdd.Enabled = false;
                txtNote.Text = edit.Note.ToString();
                lblJudul.Text = "Edit Transaction";
                Edit = edit;
            }
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // ComboBox2 DataSource base on ComboBox1 DataSource
            if (comboBox1.SelectedIndex.Equals(0))
            {
                comboBox2.DataSource = null;
                comboBox2.Enabled = false;
            }
            else if (comboBox1.SelectedIndex.Equals(1))
            {
                comboBox2.DataSource = ComboIncome;
                comboBox2.Enabled = true;
            }
            else if (comboBox1.SelectedIndex.Equals(2))
            {
                comboBox2.DataSource = ComboExpense;
                comboBox2.Enabled = true; ;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Number Validation
            if (char.IsNumber(e.KeyChar) || e.KeyChar == (char)8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                // Convert 1000 => 1.000
                if (this.txtBoxAmount.Text.Trim() != "")
                {
                    if (double.TryParse(this.txtBoxAmount.Text, out double result))
                    {
                        this.txtBoxAmount.Text = result.ToString("n0");
                        this.txtBoxAmount.SelectionStart = this.txtBoxAmount.Text.Length;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                MessageBox.Show("Please select a category !", "Invalid Category", MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                if (!EditMode)
                {
                    double amount = double.Parse(this.txtBoxAmount.Text.Trim('.'));
                    try
                    {
                        if ((comboBox1.SelectedIndex == 1 && amount > InCat[comboBox2.SelectedIndex]) || (comboBox1.SelectedIndex == 2 && amount > ExCat[comboBox2.SelectedIndex]))
                        {
                            DialogResult x = MessageBox.Show("This amount seems to big for you! \n Proceed right away?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (x == DialogResult.Yes)
                            {
                                using (var transdao = new TransactionDAO())
                                {
                                    transdao.Insert(new Transaction(dtpAdd.Value, comboBox1.Text, comboBox2.Text, amount, 0, txtNote.Text, user.ID.ToString()));
                                }
                                MessageBox.Show("Transaction has been successfuly added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else
                        {
                            using (var transdao = new TransactionDAO())
                            {
                                transdao.Insert(new Transaction(dtpAdd.Value, comboBox1.Text, comboBox2.Text, amount, 0, txtNote.Text, user.ID.ToString()));
                            }
                            MessageBox.Show("Transaction has been successfuly added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }
                else
                {
                    try
                    {
                        using (var transdao = new TransactionDAO())
                        {
                            DialogResult = MessageBox.Show("Confirm changes?", "Update Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (DialogResult == DialogResult.Yes)
                            {
                                Edit.Amount = Double.Parse(txtBoxAmount.Text);
                                Edit.Category = comboBox1.SelectedItem.ToString();
                                Edit.SubCategory = comboBox2.SelectedItem.ToString();
                                Edit.Note = txtNote.Text;
                                transdao.Update(Edit);
                                MessageBox.Show("Update Success !", "Update Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                    catch (Exception ex)
                    {

                        throw ex;
                    }
                }
            }

        }

        private void btnCncl_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNote_TextChanged(object sender, EventArgs e)
        {
            int count = txtNote.TextLength;
            this.lblTextCount.Text = count.ToString();
        }

        private void FrmAddTransaction_Load(object sender, EventArgs e)
        {

        }
    }
}
