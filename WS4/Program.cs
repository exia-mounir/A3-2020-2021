using System;

namespace WS4
{
    class Program
    {
        Delegate int DELG(int a, int b);

        static void Main(string[] args)
        {

            DELG del = new DELG(travail.methode);
            Console.WriteLine(del(2, 2));

        }
    }

    class travail
        {
        
            public int methode(int v1, int v2)
                {
                    return v1 + v2;
                }
        }
}