using System.Formats.Asn1;
using System.Security.Cryptography.X509Certificates;

namespace ArvUppgift
{
    public class Triangle: IShape
    {
       int b;

       int h;
  
    
      public Triangle(int B, int H)
      {
            b = B;
            h = H;
      }

      public double Area()
      {
            return b*h /2;
      }

      public double Circumferance()
      {
            return b/h * 3;
      }

    }
}