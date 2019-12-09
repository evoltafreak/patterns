using System;

namespace DesignPatterns.Command
{
    public interface Command
    {
        void execute();
    }

    // Light class and its corresponding command 
    // classes 
    public class Light
    {
        public void on()
        {
            Console.WriteLine("Light is on");
        }

        public void off()
        {
            Console.WriteLine("Light is off");
        }
    }

    public class LightOnCommand : Command
    {
        Light light;

        // The constructor is passed the light it 
        // is going to control. 
        public LightOnCommand(Light light)
        {
            this.light = light;
        }

        public void execute()
        {
            light.on();
        }
    }

    public class LightOffCommand : Command
    {
        Light light;

        public LightOffCommand(Light light)
        {
            this.light = light;
        }

        public void execute()
        {
            light.off();
        }
    }

    // Stereo and its command classes 
    public class Stereo
    {
        public void on()
        {
            Console.WriteLine("Stereo is on");
        }

        public void off()
        {
            Console.WriteLine("Stereo is off");
        }

        public void setCD()
        {
            Console.WriteLine("Stereo is set " +
                              "for CD input");
        }

        public void setDVD()
        {
            Console.WriteLine("Stereo is set" +
                              " for DVD input");
        }

        public void setRadio()
        {
            Console.WriteLine("Stereo is set" +
                              " for Radio");
        }

        public void setVolume(int volume)
        {
            // code to set the volume 
            Console.WriteLine("Stereo volume set"
                              + " to " + volume);
        }
    }

    public class StereoOffCommand : Command
    {
        Stereo stereo;

        public StereoOffCommand(Stereo stereo)
        {
            this.stereo = stereo;
        }

        public void execute()
        {
            stereo.off();
        }
    }

    public class StereoOnWithCDCommand : Command
    {
        Stereo stereo;

        public StereoOnWithCDCommand(Stereo stereo)
        {
            this.stereo = stereo;
        }

        public void execute()
        {
            stereo.on();
            stereo.setCD();
            stereo.setVolume(11);
        }
    }

    // A Simple remote control with one button 
    public class SimpleRemoteControl
    {
        Command slot; // only one button 

        public SimpleRemoteControl()
        {
        }

        public void setCommand(Command command)
        {
            // set the command the remote will 
            // execute 
            slot = command;
        }

        public void buttonWasPressed()
        {
            slot.execute();
        }
    }
}