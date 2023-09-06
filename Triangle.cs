using System.Security.Cryptography.X509Certificates;

namespace ArvUppgift
{
    public class Triangle: Shape
    {

        public Triangle(int width, int height): base(width,height)
        {

        }

      public int Area()
      {
            int a = height * width /2;
            return a;
      }

      public int circumferance()
      {
            int c = height + width + 5;
            return c;
      }
    }
}