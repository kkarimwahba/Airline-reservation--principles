using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace signup
{
    public class Payment
    {
        public decimal Amount { get; set; }
        public string cardNum { get; set; }
        public string cvv { get; set; }
        public string cardholderName { get; set; }
        public string ExpireDate { get; set; }

        public Payment(decimal amount, string cardNum, string cvv, string cardholderName, string expireDate)
        {
            Amount = amount;
            cardNum = cardNum;
            cvv = cvv;
            cardholderName = cardholderName;
            ExpireDate = expireDate;
        }

        public void ProcessPayment()
        {
            // Code to process the payment goes here
        }
    }

}
