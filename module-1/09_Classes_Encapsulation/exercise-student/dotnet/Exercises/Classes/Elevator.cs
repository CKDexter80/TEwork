namespace Exercises.Classes
{
    public class Elevator
    {
        public Elevator (int numberOfLevels)
        {
            NumberOfLevels = numberOfLevels;
        }

        public int CurrentLevel { get; private set; } = 1;
        public int NumberOfLevels { get; private set; }
        public bool DoorIsOpen { get; private set; }

        public void OpenDoor()
        {
            DoorIsOpen = true;
        }
        public void CloseDoor()
        {
            DoorIsOpen = false;
        }
        public void GoUp(int desiredFloor)
        {
            if (!DoorIsOpen)
            {
                if (desiredFloor > CurrentLevel)
                {
                    if (desiredFloor <= NumberOfLevels)
                    {
                        CurrentLevel = desiredFloor;
                    }
                }
            }
            
        }
        public void GoDown(int desiredFloor)
        {
            if (!DoorIsOpen)
            {
                if (desiredFloor > 1 && desiredFloor < CurrentLevel)
                {
                    CurrentLevel = desiredFloor;
                }
                else
                {
                    CurrentLevel = 1;
                }
            }
        }

    }
}
