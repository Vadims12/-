using System;

namespace Command.Commands
{
    public class NoCommand : ICommand
    {
        public void Execute() { }

        public void Undo() { }
    }
}