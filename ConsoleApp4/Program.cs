namespace Lab_01
{
    public class Program
    {
        static void Main()
        {
            Console.Write("Enter the sideA of rectangle: ");
            double sideA = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the sideB of rectangle: ");
            double sideB = Convert.ToDouble(Console.ReadLine());

            Rectangle obj1 = new Rectangle(sideA, sideB);

            Console.WriteLine("The area of rectangle is {0: ##.##}, perimetr is {1}.", obj1.Area, obj1.Perimeter);
        }


    }

    class Rectangle
    {
        public double side1, side2;

        public Rectangle(double sideA, double sideB)
        {
            this.side1 = sideA;
            this.side2 = sideB;
        }

        private double CalculateArea()
        {
            return side1 * side2;
        }

        private double CalculatePerimeter()
        {
            return (side1 + side2) * 2;
        }

        public double Area
        { 
            get
            {
                return CalculateArea();
            }
        }

        public double Perimeter
        {
            get
            {
                return CalculatePerimeter();
            }
        }
    }
}