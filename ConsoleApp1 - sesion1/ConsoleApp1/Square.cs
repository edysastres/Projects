using System;

namespace ConsoleApp1
{
    //SESSION 2

    class Square : Shape
    {
        float side;

        public Square()
        {

        }

        public Square(string name)
        {
            base.SetName(name);
        }
        public Square(float side)
        {
            this.side = side;
            float area = side * side;
            base.SetArea(area);
            float perimeter = side * 4;
            base.SetPerimeter(perimeter);
        }

        public Square(string name, float side)
        {
            base.SetName(name);
            this.side = side;
            float area = side * side;
            base.SetArea(area);
            float perimeter = side * 4;
            base.SetPerimeter(perimeter);
        }
    }
}