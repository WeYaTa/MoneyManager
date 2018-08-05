using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyManagerLibrary
{
    public class Transaction
    {
        public DateTime Date { get; set; }
        public string Category { get; set; }
        public string SubCategory { get; set; }
        public double Amount { get; set; }
        public string Note { get; set; }
        public string ID { get; set; }
        public int Nomor { get; set; }

        public Transaction(DateTime date, string cat, string sub, double amount, int num,string note = null ,string id = null )
        {
            Date = date;
            Category = cat;
            SubCategory = sub;
            Amount = amount;
            Nomor = num;
            Note = note;
            ID = id;
           
        }
    }
}
