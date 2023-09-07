using System;
namespace ArvUppgift
{
    public class Program
    {
        static void Main()
        {
            Console.WriteLine("Skriv in en höjd");
            int h = int.Parse(Console.ReadLine());
            Console.WriteLine("Skriv in en bredd");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Välj mellan 1 eller 2; 1: Rektangel, 2: Triangel");
            int val = int.Parse(Console.ReadLine());

            switch(val)
            {
                case 1:
                    Rectangle rec = new Rectangle(h,b);
                    Console.WriteLine("Arean är:" + rec.Area());
                    Console.WriteLine("Omkretsen är:" +rec.Circumferance());
                break;

                case 2:
                    Triangle tri = new Triangle(h,b);
                    Console.WriteLine("Arean är:" + tri.Area());
                    Console.WriteLine("Omkretsen är:" + tri.Circumferance());
                break;
            }

        }
    }
}