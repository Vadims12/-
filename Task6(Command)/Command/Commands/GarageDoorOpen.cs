using Command.DeviceControl;

namespace Command.Commands
{
    public class GarageDoorOpen : ICommand
    {
        private readonly GarageDoor _garageDoor;
        public GarageDoorOpen(GarageDoor garageDoor)
        {
            this._garageDoor = garageDoor;
        }
        public void Execute()
        {
            _garageDoor.LightOn();
            _garageDoor.Up();
        }

        public void Undo()
        {
            _garageDoor.LightOff();
            _garageDoor.Down();
        }
    }
}