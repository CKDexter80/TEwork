using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture.Farming
{
    public interface ISing
    {
        string Name { get; }
        string MakeSound();
    }
}
