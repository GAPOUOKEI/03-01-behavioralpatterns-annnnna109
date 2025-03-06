using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_2
{
    // Состояние ожидание выбора напитка
    class WaitingForSelectionState : IVendingMachineState
    {
        public void InsertCoin(VendingMachine machine)
        {
            Console.WriteLine("Монета уже вставлена. Выберите напиток.");
        }

        public void SelectProduct(VendingMachine machine)
        {
            Console.WriteLine("Напиток выбран.");
            machine.SetState(new DispensingState());
        }

        public void DispenseProduct(VendingMachine machine)
        {
            Console.WriteLine("Выберите напиток перед выдачей.");
        }
    }

}
