using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture.Farming
{
    class Egg : ISellable
    {

        public string Name { get; } = "Egg";
        public decimal Price { get; } = .25M;
    }
}
