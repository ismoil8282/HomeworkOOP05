﻿namespace HomeworkOOP05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();
            rectangle.Wigth = 4;
            rectangle.Height = 5;
            rectangle.DisplayInfo();

        }

    }
    class Rectangle
    {
        public double Wigth { get; set; }
        public double Height { get; set; }

        public static double CalculateArea()
        {
           return Wigth*Height;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Area of Rectangle : {CalculateArea()}");
        }

    }
}