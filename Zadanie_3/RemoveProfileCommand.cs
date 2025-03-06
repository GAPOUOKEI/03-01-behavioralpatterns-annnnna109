using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_3
{
    // Команда удаления профиля
    class RemoveProfileCommand : ICommand
    {
        private UserProfileManager _manager;
        private string _name;

        public RemoveProfileCommand(UserProfileManager manager, string name)
        {
            _manager = manager;
            _name = name;
        }

        public void Execute()
        {
            _manager.RemoveProfile(_name);
        }

        public void Undo()
        {
            _manager.AddProfile(_name);
        }
    }
}
