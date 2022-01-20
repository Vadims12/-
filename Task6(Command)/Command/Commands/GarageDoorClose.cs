using Command.DeviceControl;

namespace Command.Commands
{
    public class GarageDoorClose : ICommand
    {
        private readonly GarageDoor _garageDoor;
        public GarageDoorClose(GarageDoor garageDoor)
        {
            this._garageDoor = garageDoor;
        }

        public void Execute()
        {
            _garageDoor.LightOff();
            _garageDoor.Down();
        }

        public void Undo()
        {
            _garageDoor.LightOn();
            _garageDoor.Up();
        }
    }
}