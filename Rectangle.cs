using System.Net.Http.Headers;
using System.Reflection.Metadata.Ecma335;

namespace ArvUppgift
{
    public class Rectangle: IShape
    {
       int b;

       int h;
        public Rectangle(int B, int H)
        {
            b = B;
            h = H;
        }

        public double Area()
        {
            return b*h;
        }

        public double Circumferance()
        {
            
            return b*2 + h*2;
        }
    }
}