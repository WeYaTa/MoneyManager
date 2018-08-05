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
    public partial class FrmGraph : Form
    {
        List<string> listInSubCategory = new List<string>();
        List<string> listExSubCategory = new List<string>();
        List<Transaction> listTransaksi = null;
        List<Transaction> listfilter = null;

        User user = null;

        public FrmGraph(User import,List<string> comboIn, List<string> comboEx)
        {
            InitializeComponent();
            user = import;
            listInSubCategory = comboIn;
            listExSubCategory = comboEx;
            coBoxMonth.SelectedIndex = 0;
            
        }

        private void FrmGraph_Load(object sender, EventArgs e)
        {
            
            coBoxMonth.SelectedIndex = 0;
            
        }

        private void fillChart(List<Transaction> list)
        {
            incomeChart.Series["Income"].Points.Clear();
            expenseChart.Series["Expense"].Points.Clear();
            incomeChart.Titles.Clear();
            expenseChart.Titles.Clear();

           
            double[] arrayInAmount = new double[listInSubCategory.Count];
            double[] arrayExAmount = new double[listExSubCategory.Count];
            try
            {
                

                foreach (var item in list)
                {
                    if (item.Category == "Income")
                    {
                        for (int i = 0; i < listInSubCategory.Count; i++)
                        {
                            if (item.SubCategory == listInSubCategory.ElementAt(i))
                            {
                                arrayInAmount[i] += item.Amount;
                            }
                        }
                    }

                    else if (item.Category == "Expense")
                    {
                        for (int i = 0; i < listExSubCategory.Count; i++)
                        {
                            if (item.SubCategory == listExSubCategory.ElementAt(i))
                            {
                                arrayExAmount[i] += item.Amount;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

            // For Income Chart
            for (int i = 0; i < listInSubCategory.Count; i++)
            {
                if (arrayInAmount[i] != 0)
                    incomeChart.Series["Income"].Points.AddXY(listInSubCategory.ElementAt(i), arrayInAmount[i]);
                
            }
            incomeChart.Titles.Add("Income");

            // For Expense Chart
            for (int i = 0; i < listExSubCategory.Count; i++)
            {
                if (arrayExAmount[i] != 0)
                    expenseChart.Series["Expense"].Points.AddXY(listExSubCategory.ElementAt(i), arrayExAmount[i]);
                
            }
            expenseChart.Titles.Add("Expense");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            FrmGraph_Load(null,null);
        }

        private void coBoxMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            listfilter = new List<Transaction>();
            using (var transdao = new TransactionDAO())
            {
                listTransaksi = transdao.GetAllTransactionDataByID(user.ID.ToString());
                
            }

            foreach (var item in listTransaksi)
            {
                if (coBoxMonth.SelectedIndex == 0 && item.Date.Month == DateTime.Today.Month) listfilter.Add(item);

                else if (coBoxMonth.SelectedIndex == 1 && item.Date.Month == DateTime.Today.Month - 1) listfilter.Add(item);

                else if (coBoxMonth.SelectedIndex == 2 && item.Date.Month == DateTime.Today.Month - 2) listfilter.Add(item);
            }

            fillChart(listfilter);
        }
    }
}
