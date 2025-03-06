using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_3
{
    // команда добавления профиля
    class AddProfileCommand : ICommand
    {
        private UserProfileManager _manager;
        private string _name;

        public AddProfileCommand(UserProfileManager manager, string name)
        {
            _manager = manager;
            _name = name;
        }

        public void Execute()
        {
            _manager.AddProfile(_name);
        }

        public void Undo()
        {
            _manager.RemoveProfile(_name);
        }
    }
}
