using System.Net.Http.Headers;
using System.Reflection.Metadata.Ecma335;

namespace ArvUppgift
{
    public class Rectangle: Shape
    {
       
        public Rectangle(int width, int height): base(width,height)
        {

        }

        public int Area()
        {
            return (this.width * this.height);
        }

        public int Circumferance()
        {
            
            return (this.width *2 + this.height *2);
        }
    }
}