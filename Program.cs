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
            Shape s = null;
            switch(val)
            {
                case 1:
                    s = new Rectangle(h,b);
                
                break;

                case 2:
                    s = new Triangle(h,b);
                    
                break;
            }

                    Console.WriteLine("Arean är:" + s.Area());
                    Console.WriteLine("Omkretsen är:" + s.Circumferance());

        }
    }
}