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
    public partial class FrmDetailTransaksi : Form
    {
        User user = null;
        string Date;
        List<Transaction> ListTransaction = null;
        List<Transaction> listAwal = null;
        List<string> ComboIn = null;
        List<string> ComboEx = null;

        public FrmDetailTransaksi(User import, string date, List<string> cat, List<string> comboin, List<string> comboex)
        {
            InitializeComponent();
            user = import;
            Date = date;
            dgvData.AutoGenerateColumns = false;
            dgvData.ColumnHeadersDefaultCellStyle.Font = new Font(DataGridView.DefaultFont, FontStyle.Bold);
            dgvData.Columns["Amount"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvData.Columns["Amount"].DefaultCellStyle.Format = "n0";
            dgvData.DataSource = null;
            coBoxCategory.DataSource = cat;
            ComboIn = comboin;
            ComboEx = comboex;
            lblDate.Text = "Transactions on : " + Date;
        }

        private void FrmDetailTransaksi_Load(object sender, EventArgs e)
        {
            
            this.listAwal = new List<Transaction>();
            try
            {
                using (var transdao = new TransactionDAO())
                {
                    ListTransaction = transdao.GetAllTransactionDataByID(user.ID.ToString());
                }

                foreach (var item in ListTransaction)
                {
                    if (item.Date == DateTime.Parse(Date))
                    {
                        listAwal.Add(item);
                    }
                }

                dgvData.DataSource = listAwal;
                this.dgvData.Columns[0].DataPropertyName = "Category";
                this.dgvData.Columns[1].DataPropertyName = "SubCategory";
                this.dgvData.Columns[2].DataPropertyName = "Amount";
                this.dgvData.Columns[3].DataPropertyName = "Note";

                lblResult.Text = "Results : " + dgvData.Rows.Count.ToString() + " Row(s)";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmDetailTransaksi_Resize(object sender, EventArgs e)
        {
            this.dgvData.Columns[0].Width = 15 * this.dgvData.Width / 100;
            this.dgvData.Columns[1].Width = 20 * this.dgvData.Width / 100;
            this.dgvData.Columns[2].Width = 20 * this.dgvData.Width / 100;
            this.dgvData.Columns[3].Width = 45 * this.dgvData.Width / 100;
        }

        private void checkBoxCategory_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxCategory.Checked == true)
            {
                checkBoxCategory.ForeColor = Color.Black;
                coBoxCategory.Enabled = true;
            }
            else
            {
                checkBoxSubCat.Checked = false;
                checkBoxCategory.ForeColor = Color.Gray;
                coBoxCategory.Enabled = false;
            }
        }

        private void checkBoxSubCat_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSubCat.Checked == true)
            {
                checkBoxCategory.Checked = true;
                checkBoxSubCat.ForeColor = Color.Black;
                coBoxSubCat.Enabled = true;
            }
            else
            {
                checkBoxSubCat.ForeColor = Color.Gray;
                coBoxSubCat.Enabled = false;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            FrmDetailTransaksi_Resize(null, null);
            lblDate.Text = "Transactions on : " + Date;
            coBoxCategory.SelectedIndex = 0;
            checkBoxCategory.Checked = false;
            checkBoxRange.Checked = false;
            checkBoxSubCat.Checked = false;
            txtRange1.Clear();
            txtRange2.Clear();
            FrmDetailTransaksi_Load(null,null);
        }

        private void checkBoxRange_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxRange.Checked == true)
            {
                txtRange1.Enabled = true;
                txtRange2.Enabled = true;
                label2.Enabled = true;
                checkBoxRange.ForeColor = Color.Black;
            }
            else
            {
                txtRange1.Enabled = false;
                txtRange2.Enabled = false;
                label2.Enabled = false;
                checkBoxRange.ForeColor = Color.Gray;
            }
        }

        private void coBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (coBoxCategory.SelectedItem.ToString() == "Income")
            {
                coBoxSubCat.DataSource = ComboIn;
            }
            else if (coBoxCategory.SelectedItem.ToString() == "Expense")
            {
                coBoxSubCat.DataSource = ComboEx;
            }
            else
            {
                coBoxSubCat.DataSource = null;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (checkBoxRange.Checked == true && txtRange1.Text.Trim() != "" && txtRange2.Text.Trim() != "" && Double.Parse(txtRange1.Text) > Double.Parse(txtRange2.Text))
            {
                MessageBox.Show("Range should start with smaller number", "Invalid Range",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {

                dgvData.DataSource = null;
                List<Transaction> listFilter = new List<Transaction>();

                if (checkBoxCategory.Checked == true && checkBoxSubCat.Checked == false && checkBoxRange.Checked == false)
                {
                    foreach (var item in listAwal)
                    {
                        if (item.Category == coBoxCategory.SelectedItem.ToString())
                        {
                            listFilter.Add(item);
                        }
                    }
                    dgvData.DataSource = listFilter;
                }
                else if (checkBoxSubCat.Checked == true && checkBoxRange.Checked == false)
                {
                    foreach (var item in listAwal)
                    {
                        if (item.SubCategory == coBoxSubCat.SelectedItem.ToString())
                        {
                            listFilter.Add(item);
                        }
                    }
                    dgvData.DataSource = listFilter;
                }
                else if (checkBoxCategory.Checked == false && checkBoxSubCat.Checked == false && checkBoxRange.Checked == true)
                {
                    using (var transdao = new TransactionDAO())
                    {
                        listFilter = transdao.GetTransactionsByRange(DateTime.Parse(Date), user.ID, Double.Parse(txtRange1.Text), Double.Parse(txtRange2.Text));
                    }
                    dgvData.DataSource = listFilter;
                }
                else if (checkBoxCategory.Checked == true && checkBoxSubCat.Checked == false && checkBoxRange.Checked == true)
                {
                    List<Transaction> list = new List<Transaction>();
                    using (var transdao = new TransactionDAO())
                    {
                        listFilter = transdao.GetTransactionsByRange(DateTime.Parse(Date), user.ID, Double.Parse(txtRange1.Text), Double.Parse(txtRange2.Text));
                    }

                    foreach (var item in listFilter)
                    {
                        if (item.Category == coBoxCategory.SelectedItem.ToString())
                        {
                            list.Add(item);
                        }
                    }
                    dgvData.DataSource = list;
                }
                else if (checkBoxSubCat.Checked == true && checkBoxRange.Checked == true)
                {
                    List<Transaction> list = new List<Transaction>();
                    using (var transdao = new TransactionDAO())
                    {
                        listFilter = transdao.GetTransactionsByRange(DateTime.Parse(Date), user.ID, Double.Parse(txtRange1.Text), Double.Parse(txtRange2.Text));
                    }

                    foreach (var item in listFilter)
                    {
                        if (item.SubCategory == coBoxSubCat.SelectedItem.ToString())
                        {
                            list.Add(item);
                        }
                    }
                    dgvData.DataSource = list;
                }
                else
                {

                    dgvData.DataSource = listAwal;
                    MessageBox.Show("Please input the criteria you want to find ! (Use the checkboxes)", "Search", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                lblResult.Text = "Results : " + dgvData.Rows.Count.ToString() + " Row(s)";

            }
        }

        private void txtRange1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                // Convert 1000 => 1.000
                if (this.txtRange1.Text.Trim() != "")
                {
                    if (double.TryParse(this.txtRange1.Text, out double result))
                    {
                        this.txtRange1.Text = result.ToString("n0");
                        this.txtRange1.SelectionStart = this.txtRange1.Text.Length;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void txtRange2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                // Convert 1000 => 1.000
                if (this.txtRange2.Text.Trim() != "")
                {
                    if (double.TryParse(this.txtRange2.Text, out double result))
                    {
                        this.txtRange2.Text = result.ToString("n0");
                        this.txtRange2.SelectionStart = this.txtRange2.Text.Length;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void txtRange1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtRange2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                using (var transdao = new TransactionDAO())
                {
                    if (dgvData.SelectedRows != null)
                    {
                        DataGridViewRow row = dgvData.CurrentRow;
                        foreach (var item in listAwal)
                        {
                            if (item.SubCategory.ToString() == row.Cells[1].Value.ToString() && item.Amount.ToString() == row.Cells[2].Value.ToString() && item.Note.ToString() == row.Cells[3].Value.ToString())
                            {
                                DialogResult = MessageBox.Show("Are you sure you want to delete this transaction ?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                if (DialogResult == DialogResult.Yes)
                                {
                                    transdao.Delete(item);
                                }
                                break;
                            }
                        }
                        
                    }
                }
                FrmDetailTransaksi_Load(null,null);

            }
            catch (Exception ex)
            {

                throw ex;
            }
            
            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                using (var transdao = new TransactionDAO())
                {
                    if (dgvData.SelectedRows != null)
                    {
                        DataGridViewRow row = dgvData.CurrentRow;
                        foreach (var item in listAwal)
                        {
                            if (item.SubCategory.ToString() == row.Cells[1].Value.ToString() && item.Amount.ToString() == row.Cells[2].Value.ToString() && item.Note.ToString() == row.Cells[3].Value.ToString())
                            {
                                this.Hide();
                                new FrmAddTransaction(user,ComboIn,ComboEx,true,item).ShowDialog();
                                this.Show(); 
                            }
                        }
                        
                    }
                }
                FrmDetailTransaksi_Load(null, null);

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
