namespace Zadanie_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            VendingMachine machine = new VendingMachine();

            machine.SelectProduct();  // Вставьте монету перед выбором напитка.
            machine.InsertCoin();      // Монета принята.
            machine.InsertCoin();      // Монета уже вставлена. Выберите напиток.
            machine.SelectProduct();   // Напиток выбран.
            machine.DispenseProduct(); // Ваш напиток готов! Заберите его.
            machine.DispenseProduct(); // Сначала вставьте монету и выберите напиток.
        }
    }
}
