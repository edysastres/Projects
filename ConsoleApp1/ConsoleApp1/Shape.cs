using System;

namespace ConsoleApp1
{
    //SESSION 1

    //class Shape
    //{
    //    string name;
    //    float area;
    //    float perimeter;

    //    public Shape()
    //    {

    //    }

    //    public Shape(string name)
    //    {
    //        this.name = name;
    //    }

    //    public string SayHello()
    //    {

    //        return "Hi! My name is " + name;

    //    }

    //    protected void SetName(string name)
    //    {
    //        this.name = name;
    //    }

    //    protected void SetArea(float area)
    //    {
    //        this.area = area;
    //    }

    //    protected void SetPerimeter(float perimeter)
    //    {
    //        this.perimeter = perimeter;
    //    }

    //    public float GetArea()
    //    {
    //        return area;
    //    }
    //}

    abstract class Shape
    {
        protected string name;
        protected float area;
        protected float perimeter;

        public abstract float CalculateArea();
        public abstract float CalculatePerimeter();

        public virtual string SayHello()
        {
            return "Hola";
        }
    }

    public interface Motion
    {
        void Roll(int times);

    }
}