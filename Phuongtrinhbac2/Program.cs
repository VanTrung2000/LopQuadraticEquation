using System;

namespace Phuongtrinhbac2
{
    class Program
    {
        static void Main(string[] args)
        {
            Quadraticequation qu = new Quadraticequation(1, 6, 9);
            qu.getter();
           
            Console.WriteLine("Delta=" + qu.GetDiscriminant());
            if(qu.GetDiscriminant() > 0)
            {
                Console.WriteLine("Phuong trinh co 2 nghiem");
                Console.WriteLine("X1:" + qu.GetRoot1());
                Console.WriteLine("X1:" + qu.GetRoot1());

            }
            else if (qu.GetDiscriminant() == 0)
            {
                Console.WriteLine("Phuong trinh co 1 nghiem duy nhat" + qu.GetRoot());
            }
            else
            {
                Console.WriteLine("Phuong trinh vo nghiem");
            }


        }
    }
}
