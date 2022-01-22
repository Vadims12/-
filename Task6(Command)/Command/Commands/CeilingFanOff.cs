using Command.DeviceControl;

namespace Command.Commands
{
    public class CeilingFanOff : ICommand
    {
        private readonly CeilingFan _ceilingFan;

        private int prevSpeed;

        public CeilingFanOff(CeilingFan ceilingFan)
        {
            this._ceilingFan = ceilingFan;
        }

        public void Execute()
        {
            _ceilingFan.Off();
        }
        public void Undo()
        {
            if (prevSpeed == _ceilingFan.high)
            {
                _ceilingFan.High();
            }
            else if (prevSpeed == _ceilingFan.medium)
            {
                _ceilingFan.Medium();
            }
            else if (prevSpeed == _ceilingFan.low)
            {
                _ceilingFan.Low();
            }
            else if (prevSpeed == _ceilingFan.off)
            {
                _ceilingFan.Low();
            }
        }
    }
}