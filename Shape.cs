using System;
namespace ArvUppgift
{
    public class Shape
    {
        protected int width;
        protected int height;

        public int Width {get {return width;}}
        public int Height {get{return height;}}

        public Shape(int width,int height)
        {
            this.width = width;
            this.height = height;
        }


        virtual public int Area()
        {
            return 1;
        }

        virtual public double Circumferance()
        {
            return 2;
        }

        

        
    }
}