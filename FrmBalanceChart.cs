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
    public partial class FrmBalanceChart : Form
    {
        List<TransactionHeader> listTransaksi = null;
        List<DateAmount> listfilter = null;
        User user = null;

        public FrmBalanceChart(User import, List<TransactionHeader> list)
        {
            InitializeComponent();
            user = import;
            listTransaksi = list;

        }

        private void FrmBalanceChart_Load(object sender, EventArgs e)
        {
            try
            {

                listfilter = new List<DateAmount>();
                DateTime d = DateTime.Now;
                double a = 0;
                foreach (var item in listTransaksi)
                {
                    if (item.Date.Month == DateTime.Today.Month)
                    {
                        d = item.Date;
                        a += (item.Income - item.Expense);
                        listfilter.Add(new DateAmount
                        {
                            Date = d,
                            Amount = a
                        });
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            chart1.DataSource = listfilter;

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    public class DateAmount
    {
        public DateTime Date { get; set; }
        public double Amount { get; set; }
    }
}
