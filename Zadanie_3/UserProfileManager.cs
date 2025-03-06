using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_3
{
    // управление профилями пользователей
    class UserProfileManager
    {
        private List<string> profiles = new List<string>();

        public void AddProfile(string name)
        {
            profiles.Add(name);
            Console.WriteLine($"Профиль {name} добавлен.");
        }

        public void RemoveProfile(string name)
        {
            profiles.Remove(name);
            Console.WriteLine($"Профиль {name} удален.");
        }

        public void ShowProfiles()
        {
            Console.WriteLine("Список профилей:");
            foreach (var profile in profiles)
            {
                Console.WriteLine("- " + profile);
            }
        }
    }
}
