using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_2
{
    // Класс торгового автомата
    class VendingMachine
    {
        private IVendingMachineState _state;

        public VendingMachine()
        {
            _state = new WaitingForCoinState();
        }

        public void SetState(IVendingMachineState state)
        {
            _state = state;
        }

        public void InsertCoin()
        {
            _state.InsertCoin(this);
        }

        public void SelectProduct()
        {
            _state.SelectProduct(this);
        }

        public void DispenseProduct()
        {
            _state.DispenseProduct(this);
        }
    }
}
