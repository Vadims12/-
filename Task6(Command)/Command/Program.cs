using System;
using Command.Commands;
using Command.DeviceControl;

namespace Command
{
    class Program
    {
        static void Main()
        {
            // Создание пульта дистанционного контроля. Кнопки не назначены.

            RemoteControl remoteControl = new RemoteControl();

            // Создание устройств

            CeilingFan ceilingFan = new CeilingFan();
            GarageDoor garageDoor = new GarageDoor();
            Light light = new Light();
            Stereo stereo = new Stereo();

            // Создание команд для пульта

            LightOnCommand onLight = new LightOnCommand(light);
            LightOffCommand offLight = new LightOffCommand(light);
            GarageDoorOpen openGarageDoor = new GarageDoorOpen(garageDoor);
            GarageDoorClose closeGarageDoor = new GarageDoorClose(garageDoor);
            CeilingFanHigh ceilingFanHigh = new CeilingFanHigh(ceilingFan);
            CeilingFanOff ceilingFanOff = new CeilingFanOff(ceilingFan);
            StereoOnForCd stereoOnForCd = new StereoOnForCd(stereo);
            StereoOff stereoOff = new StereoOff(stereo);

            // Биндим команды к слотам пульта

            remoteControl.SetCommand(0, onLight, offLight);
            remoteControl.SetCommand(1, openGarageDoor, closeGarageDoor);
            remoteControl.SetCommand(2, ceilingFanHigh, ceilingFanOff);
            remoteControl.SetCommand(3, stereoOnForCd, stereoOff);


        }
    }
}
