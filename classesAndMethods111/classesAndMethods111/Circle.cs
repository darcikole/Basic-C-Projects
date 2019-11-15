using System;
namespace classesAndMethods111
{
    public class Circle
    {

        public double Diameter(double data)
        {
            data = data * 2;
            return data;
        }

        public double Circumference(double data)
        {
            data = (2 * Math.PI) * data;
            return data;
        }

        public double Area(double data)
        {
            data = Math.PI * (data * data);
            return data;
        }
    }
}
