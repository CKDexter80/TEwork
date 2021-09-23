namespace Exercises.Classes
{
    public class Television
    {
        public bool IsOn { get; private set; } = false;
        public int CurrentChannel { get; private set; } = 3;
        public int CurrentVolume { get; private set; } = 2;

        public void TurnOff()
        {
            IsOn = false;
        }
        public void TurnOn()
        {
            IsOn = true;
            CurrentChannel = 3;
            CurrentVolume = 2;

        }
        public void ChangeChannel(int newChannel)
        {
            if (IsOn)
            {
                if (newChannel >= 3 || newChannel <= 18)
                {
                    CurrentChannel = newChannel;
                }
            }
        }
        public void ChannelUp()
        {
            if (IsOn)
            {
                if (CurrentChannel == 18)
                {
                    CurrentChannel = 3;
                }
                else
                {
                    CurrentChannel++;
                }
            }
        }
        public void ChannelDown()
        {
            if (IsOn)
            {
                if (CurrentChannel == 3)
                {
                    CurrentChannel = 18;
                }
                else
                {
                    CurrentChannel--;
                }
            }
        }
        public void RaiseVolume()
        {
            if (IsOn)
            {
                if (CurrentVolume > 0 && CurrentVolume < 10)
                {
                    CurrentVolume++;
                }
                else
                {
                    CurrentVolume = CurrentVolume;
                }
            }
        }
        public void LowerVolume()
        {
            if (IsOn)
            {
                if (CurrentVolume > 0 && CurrentVolume < 10)
                {
                    CurrentVolume--;
                }
                else
                {
                    CurrentVolume = CurrentVolume;
                }
            }
        }



    }
}
