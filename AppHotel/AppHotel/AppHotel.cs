using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppHotel
{
    internal class AppHotel // INVOCADOR
    {
        private List<ICommand> Commands = new List<ICommand>();

        public void añadirCommand(ICommand command)
        {
            Commands.Add(command);
        }

        public void removerCommand(ICommand command)
        {
            Commands.Remove(command);
        }

        public void ejecutarCommands()
        {
            foreach (var command in Commands)
            {
                command.Execute();
            }
        }
    }
}
