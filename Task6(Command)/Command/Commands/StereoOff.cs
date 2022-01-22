using Command.DeviceControl;

namespace Command.Commands
{
    public class StereoOff : ICommand
    {
        private readonly Stereo _stereo;

        public StereoOff(Stereo stereo)
        {
            this._stereo = stereo;
        }
        public void Execute()
        {
            _stereo.Off();
        }

        public void Undo()
        {
            _stereo.On();
        }
    }
}