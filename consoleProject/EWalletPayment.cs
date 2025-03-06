using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleProject
{
    // Оплата электронным кошельком
    class EWalletPayment : PaymentProcessor
    {
        protected override void ValidatePaymentDetails()
        {
            Console.WriteLine("Проверка баланса электронного кошелька...");
        }

        protected override void DeductAmount()
        {
            Console.WriteLine("Оплата через электронный кошелек завершена.");
        }
    }
}
