using Command.DeviceControl;

namespace Command.Commands
{
    public class StereoOnForCd : ICommand
    {
        private readonly Stereo _stereo;
        public StereoOnForCd(Stereo stereo)
        {
            this._stereo = stereo;
        }

        public void Execute()
        {
            _stereo.On();
            _stereo.SetCd();
            _stereo.SetVolume(5);
        }

        public void Undo()
        {
            _stereo.Off();
        }
    }
}