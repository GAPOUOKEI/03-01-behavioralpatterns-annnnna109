namespace consoleProject
{
    /*
     * ФИО студента: Астафьева Анна Владимировна
     * номер варианта: №1
     * условие задачи (скопировать из листа задания): 
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            PaymentProcessor cardPayment = new CardPayment();
            cardPayment.ProcessPayment();

            Console.WriteLine();

            PaymentProcessor eWalletPayment = new EWalletPayment();
            eWalletPayment.ProcessPayment();

            Console.WriteLine();

            PaymentProcessor cashPayment = new CashPayment();
            cashPayment.ProcessPayment();

        }
    }
}