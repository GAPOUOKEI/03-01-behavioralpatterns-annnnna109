using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleProject
{
    // Оплата наличными
    class CashPayment : PaymentProcessor
    {
        protected override void ValidatePaymentDetails()
        {
            Console.WriteLine("Подготовка к оплате наличными...");
        }

        protected override void DeductAmount()
        {
            Console.WriteLine("Получение наличных от клиента.");
        }

        protected override void SendReceipt()
        {
            Console.WriteLine("Выдача бумажного чека клиенту.");
        }
    }

}
