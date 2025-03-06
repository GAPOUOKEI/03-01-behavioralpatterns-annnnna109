using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleProject
{
    // Оплата картой
    class CardPayment : PaymentProcessor
    {
        protected override void ValidatePaymentDetails()
        {
            Console.WriteLine("Валидация данных карты...");
        }

        protected override void DeductAmount()
        {
            Console.WriteLine("Списание суммы с банковской карты...");
        }
    }
}
