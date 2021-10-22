using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone
{
    public interface IWrite
    {
        int GetNumber();
        int GetNumber(int[] numbers);
        void Print(string message);
        void Welcome();
        void MainMenu();
    }
}
