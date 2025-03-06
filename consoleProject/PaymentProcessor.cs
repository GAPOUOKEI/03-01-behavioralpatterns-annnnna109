using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleProject
{
    abstract class PaymentProcessor
    {
        public void ProcessPayment()
        {
            ValidatePaymentDetails();
            DeductAmount();
            SendReceipt();
        }

        protected abstract void ValidatePaymentDetails();
        protected abstract void DeductAmount();
        protected virtual void SendReceipt()
        {
            Console.WriteLine("Квитанция отправлена по электронной почте.");
        }
    }
}
