using Command.DeviceControl;

namespace Command.Commands
{
    public class CeilingFanHigh : ICommand
    {
        private readonly CeilingFan _ceilingFan;

        private int prevSpeed;
        public CeilingFanHigh(CeilingFan ceilingFan)
        {
            this._ceilingFan = ceilingFan;
        }

        public void Execute()
        {
            prevSpeed = _ceilingFan.GetSpeed();
            _ceilingFan.High();
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