using System;
using System.Collections.Generic;
using System.Text;

namespace Phuongtrinhbac2
{
    class Quadraticequation
    {
        private double a { set; get; }
        private double b { set; get; }
        private double c { set; get; }

        public Quadraticequation(double a,double b,double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public void getter()
        {
            Console.WriteLine("a:"+this.a + '\n'+"b:"+this.b+"\n"+"c:"+this.c);
        }
        public double GetDiscriminant()
        {
            return b * b -( 4 *a *c); 
        }
            public void SetDiscriminant()
            {
                Console.WriteLine("Delta:", +GetDiscriminant());
            }
        public double GetRoot()
        {
            return -b / (2.0 * a);
        }
        public double GetRoot1()
        {
            return (-b + Math.Sqrt(GetDiscriminant())) / (2 * a);
        }
        public double GetRoot2()
        {
            return (-b - Math.Sqrt(GetDiscriminant())) / (2 * a);
        }



    }
}
