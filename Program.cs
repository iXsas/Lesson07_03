using System;
using System.ComponentModel.DataAnnotations;

namespace Lesson07_03
{
    struct Staciakampis
    {
        public int ilgis;
        public int plotis;
        public int plotasSkaiciuoti()
        {
            return (ilgis * plotis);
        }
        public Staciakampis(int x, int y)
        { 
            this.ilgis = x;
            this.plotis = y;
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Staciakampis staciakampis1 = new Staciakampis(2,3);
            Staciakampis staciakampis2 = new Staciakampis(4,5);
            Staciakampis staciakampis3 = new Staciakampis(2,8);
            //isvedame plota su console writeline
            Console.WriteLine(staciakampis1.plotasSkaiciuoti());
            Console.WriteLine(staciakampis2.plotasSkaiciuoti());
            Console.WriteLine(staciakampis3.plotasSkaiciuoti());
        }
    }

    

}
