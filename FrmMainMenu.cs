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
    public partial class FrmMainMenu : Form
    {
        User user = null;
        List<Transaction> TransactionList = null;
        List<string> ComboCat = new List<string>();
        List<string> ComboIncome = new List<string>();
        List<string> ComboExpense = new List<string>();
        List<TransactionHeader> listNonDetail = null;
        bool logout = false;

        public FrmMainMenu(User ImportedUser)
        {
            InitializeComponent();

            this.user = ImportedUser;
            lblHello.Text += user.Name.ToString();
            dgvData.AutoGenerateColumns = false;
            dgvData.ColumnHeadersDefaultCellStyle.Font = new Font(DataGridView.DefaultFont, FontStyle.Bold);
            dgvData.Columns["Income"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvData.Columns["Expense"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvData.Columns["Income"].DefaultCellStyle.Format = "n0";
            dgvData.Columns["Expense"].DefaultCellStyle.Format = "n0";
            dgvData.DataSource = null;

            // Category
            ComboCat.Add("<select>");
            ComboCat.Add("Income");
            ComboCat.Add("Expense");

            // Income Category
            ComboIncome.Add("Salary");
            ComboIncome.Add("Award");
            ComboIncome.Add("Interest Money");
            ComboIncome.Add("Gifts");
            ComboIncome.Add("Selling");
            ComboIncome.Add("Miscellaneous");

            // Expanse Category
            ComboExpense.Add("Friends & Lover");
            ComboExpense.Add("Food & Beverage");
            ComboExpense.Add("Bills & Utilities");
            ComboExpense.Add("Transportation");
            ComboExpense.Add("Shopping");
            ComboExpense.Add("Entertaintment");
            ComboExpense.Add("Travel");
            ComboExpense.Add("Health & Fitness");
            ComboExpense.Add("Gifts & Donation");
            ComboExpense.Add("Family");
            ComboExpense.Add("Education");
            ComboExpense.Add("Investment");
            ComboExpense.Add("Business");
            ComboExpense.Add("Insurance");
            ComboExpense.Add("Fees & Charges");
            ComboExpense.Add("Miscellaneous");
        }

        private void reportGraphToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FrmGraph(user, ComboIncome, ComboExpense).ShowDialog();
            this.Show();
        }

        private void FrmMainMenu_Load(object sender, EventArgs e)
        {

            double totalIncome = 0, totalExpense = 0;
            double thisMonthIncome = 0, thisMonthExpense = 0;

            try
            {
                using (var transdao = new TransactionDAO())
                {
                    TransactionList = transdao.GetAllTransactionDataByID(user.ID.ToString());
                    
                    listNonDetail = transdao.GetAllTransactionHeaderByID(user.ID.ToString());
                }

                
                
                foreach (var item in listNonDetail)
                {
                    if (item.Date.Month == DateTime.Today.Month)
                    {
                        thisMonthIncome += item.Income;
                        thisMonthExpense += item.Expense;
                    }
                    totalIncome += item.Income;
                    totalExpense += item.Expense;
                }

                
                lblIncome.Text =  "Income   :  Rp. " + thisMonthIncome.ToString("n0") + ",00-";
                lblExpense.Text = "Expense  :  Rp. " + thisMonthExpense.ToString("n0") + ",00-";
                lblTotal.Text = "Account Balance : Rp. " + (totalIncome - totalExpense).ToString("n0") + ",00-";

                coBoxMonth.SelectedIndex = 1;
                coBoxMonth.SelectedIndex = 0;
                this.dgvData.Columns[0].DataPropertyName = "Date";
                this.dgvData.Columns[1].DataPropertyName = "Income";
                this.dgvData.Columns[2].DataPropertyName = "Expense";


            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void expenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FrmAddTransaction(user, ComboIncome, ComboExpense).ShowDialog();
            this.Show();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            if (logout)
            {
                this.Hide();
                new FrmLogin().ShowDialog();
                this.Close();
            }
            else
            {
                DialogResult dialog = MessageBox.Show("Are you sure ?", "Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dialog == DialogResult.Yes)
                {
                    this.Hide();
                    new FrmLogin().ShowDialog();
                    this.Close();
                }
                else
                {
                    //back to menu
                }
            }
            

        }

        private void manageProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmManageProfile form = new FrmManageProfile(user);
            logout = form.Run();
            if (logout)
            {
                MessageBox.Show("Logging Out is required after updating data!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnLogOut_Click(null,null);
            }
            else
            {
                this.Show();
            }
            
        }

        private void FrmMainMenu_Resize(object sender, EventArgs e)
        {
            this.dgvData.Columns[0].Width = 15 * this.dgvData.Width / 100;
            this.dgvData.Columns[1].Width = 20 * this.dgvData.Width / 100;
            this.dgvData.Columns[2].Width = 20 * this.dgvData.Width / 100;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            coBoxMonth.SelectedIndex = 0;
            FrmMainMenu_Load(null, null);
        }

        private void coBoxMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<TransactionHeader> listfilter = new List<TransactionHeader>();

            dgvData.DataSource = null;

            foreach (var item in listNonDetail)
            {
                if (coBoxMonth.SelectedIndex == 0 && item.Date.Month == DateTime.Today.Month) listfilter.Add(item);

                else if (coBoxMonth.SelectedIndex == 1 && item.Date.Month == DateTime.Today.Month - 1) listfilter.Add(item);

                else if (coBoxMonth.SelectedIndex == 2 && item.Date.Month == DateTime.Today.Month - 2) listfilter.Add(item);
            }

            dgvData.DataSource = listfilter;

        }

        private void dgvData_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvData.CurrentCell.ColumnIndex == 0)
            {
                this.Hide();
                new FrmDetailTransaksi(user, DateTime.Parse(dgvData.CurrentCell.Value.ToString()).ToLongDateString(), ComboCat,ComboIncome,ComboExpense).ShowDialog();
                this.Show();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void balanceChartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FrmBalanceChart(user, listNonDetail).ShowDialog();
            this.Show();
        }

        private void deleteMyAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmDeleteAccount form = new FrmDeleteAccount(user);
            if (form.Run())
            {
                new FrmLogin().ShowDialog();
                this.Close();
            }
            else
            {
                this.Show();
            }
        }
    }


}
