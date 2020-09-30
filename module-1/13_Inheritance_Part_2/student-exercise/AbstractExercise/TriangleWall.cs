using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractExercise
{
    class TriangleWall
    {
        public int Base { get; }
        public int Height { get; }
        public TriangleWall(string name, string color, int @base, int height)
        {
            Base = @base;
            Height = height;
        }

    }
}
