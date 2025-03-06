using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_2
{
    // Состояние выдача напитка
    class DispensingState : IVendingMachineState
    {
        public void InsertCoin(VendingMachine machine)
        {
            Console.WriteLine("Подождите, идет выдача напитка.");
        }

        public void SelectProduct(VendingMachine machine)
        {
            Console.WriteLine("Подождите, идет выдача напитка.");
        }

        public void DispenseProduct(VendingMachine machine)
        {
            Console.WriteLine("Ваш напиток готов! Заберите его.");
            machine.SetState(new WaitingForCoinState());
        }
    }
}
