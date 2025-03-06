namespace Zadanie_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UserProfileManager manager = new UserProfileManager();
            CommandInvoker invoker = new CommandInvoker();

            ICommand addUser1 = new AddProfileCommand(manager, "Алиса");
            ICommand addUser2 = new AddProfileCommand(manager, "Боб");
            ICommand removeUser1 = new RemoveProfileCommand(manager, "Алиса");

            invoker.ExecuteCommand(addUser1);
            invoker.ExecuteCommand(addUser2);
            manager.ShowProfiles();

            invoker.ExecuteCommand(removeUser1);
            manager.ShowProfiles();

            Console.WriteLine("Отмена последнего действия:");
            invoker.UndoLastCommand();
            manager.ShowProfiles();
        }
    }
}
