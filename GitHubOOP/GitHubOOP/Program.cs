namespace HomeworkOOP05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();
            rectangle.Width = 4;
            rectangle.Height = 5;
            rectangle.DisplayInfo();

        }

    }
    class Rectangle
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public  double CalculateArea()
        {
            return Width * Height;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Area of Rectangle : {CalculateArea()}");
        }

    }
}