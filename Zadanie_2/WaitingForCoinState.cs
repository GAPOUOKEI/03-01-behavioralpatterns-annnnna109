using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_2
{
    // Состояние ожидание монеты
    class WaitingForCoinState : IVendingMachineState
    {
        public void InsertCoin(VendingMachine machine)
        {
            Console.WriteLine("Монета принята.");
            machine.SetState(new WaitingForSelectionState());
        }

        public void SelectProduct(VendingMachine machine)
        {
            Console.WriteLine("Вставьте монету перед выбором напитка.");
        }

        public void DispenseProduct(VendingMachine machine)
        {
            Console.WriteLine("Сначала вставьте монету и выберите напиток.");
        }
    }
}
