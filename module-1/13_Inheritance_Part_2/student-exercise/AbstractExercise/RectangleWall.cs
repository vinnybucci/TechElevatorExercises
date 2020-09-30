using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractExercise
{
    class RectangleWall : Wall
    {
        public int Length { get; }
        public int Height { get; }

        public override int GetArea()
        {
            throw new NotImplementedException();
        }

        //  public RectangleWall(string name, string color, int length, int height) 
        //{
        //    Length = length;
        //    Height = height;


    }

    //public string ToString()
    //{
    //    return;
    //}
    //public override int GetArea()
    //{
    //    return GetArea(Length*Height);
    //}
}

