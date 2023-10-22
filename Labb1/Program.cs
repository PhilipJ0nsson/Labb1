namespace Labb1
{
    internal class Program
    {


        static void Main(string[] args)
        {
            Circle circleOne = new Circle(5, 3.141f);
            Console.WriteLine("En cirkel med radien 5 har: ");
            Console.Write("Arean: ");
            circleOne.getArea();
            Console.Write("Omkrets: ");
            circleOne.getCircumference();
            Console.Write("Volym: ");
            circleOne.getVolume();

            Console.WriteLine();

            Circle circleTwo = new Circle(6, 3.141f);
            Console.WriteLine("En cirkel med radien 6 har: ");
            Console.Write("Arean: ");
            circleTwo.getArea();
            Console.Write("Omkrets: ");
            circleTwo.getCircumference();
            Console.Write("Volym: ");
            circleTwo.getVolume();


        }
    }

    public class Circle
    {
        public int _radius;
        public float _pi;


        public Circle(int radius, float pi)
        {
            _radius = radius;
            _pi = pi;
        }


        public void getArea()
        {
            float area = _radius * _radius * _pi;
            Console.WriteLine(area);
        }

        public void getCircumference()
        {
            float circumference = 2 * _pi * _radius;
            Console.WriteLine(circumference);
        }

        public void getVolume()
        {
            float volume = 4 * _pi * _radius * _radius * _radius / 3;
            Console.WriteLine(volume);
        }
    }
}