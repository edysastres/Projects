using System;

namespace ConsoleApp1
{
    //SESSION 2

    //class Square : Shape
    //{
    //    float side;

    //    public Square()
    //    {

    //    }

    //    public Square(string name)
    //    {
    //        base.SetName(name);
    //    }
    //    public Square(float side)
    //    {
    //        this.side = side;
    //        float area = side * side;
    //        base.SetArea(area);
    //        float perimeter = side * 4;
    //        base.SetPerimeter(perimeter);
    //    }

    //    public Square(string name, float side)
    //    {
    //        base.SetName(name);
    //        this.side = side;
    //        float area = side * side;
    //        base.SetArea(area);
    //        float perimeter = side * 4;
    //        base.SetPerimeter(perimeter);
    //    }
    //}

    class Square : Shape
    {
        float side;

        public Square()
        {

        }

        public Square(string name)
        {
            this.name = name;
        }
        public Square(float side)
        {
            this.side = side;
        }

        public Square(string name, float side)
        {
            this.name = name;
            this.side = side;
        }

        public override float CalculateArea()
        {
            //throw new NotImplementedException();
            this.area = side * side;
            return area;
        }

        public override float CalculatePerimeter()
        {
            //throw new NotImplementedException();

            this.perimeter = perimeter * 4;
            return perimeter;
        }

        public override string SayHello()
        {
            //throw new NotImplementedException();

            return "Hola soy el cuadrado: " + name;
        }

        public string SayHello(float side)
        {
            //throw new NotImplementedException();

            return "Hola soy el cuadrado: " + name + " y el valor del lado es: " + side;
        }
    }
}