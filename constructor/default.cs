using System;

namespace LineApplication
{
    class Line
    {
        private double length;

        public Line()
        {
            Console.WriteLine("Object is being created");
        }

        public void setLength(double len)
        {
            length = len;
        }

        public double getLength()
        {
            return length;
        }

        static void Main(string[] args)
        {
            Line line = new Line();

            line.setLength(6.0);
            Console.WriteLine("Length of line: {0}", line.getLength());

            Console.ReadKey();
        }
    }
}

