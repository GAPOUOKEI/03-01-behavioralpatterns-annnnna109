using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_2
{
    // Интерфейс состояния
    interface IVendingMachineState
    { 
        void InsertCoin(VendingMachine machine);
        void SelectProduct(VendingMachine machine);
        void DispenseProduct(VendingMachine machine);
    }
}
