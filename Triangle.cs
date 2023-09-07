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

      public double Circumferance()
      {
            double c = height + width + Math.Sqrt(height*width + height*width);
            return c;
      }
    }
}