using System;

namespace methods
{
    class Program
    {
        static void Main(string[] args)
        {
                           static void First(int a, int b)
            {
                                //min
                Console.WriteLine("Min:" + Math.Min(a, b));
                                //max
                Console.WriteLine("Max:" + Math.Max(a, b));
                            }
            First(6, 421);

                       static void Second(int a, int b)
             { 
                                // "a" from 1 to 10 will go
                                for (a = 1; a <= 10; a++)
                                    {
                                        //a*b will repeat until 10 "a*b=c"
                    Console.Write("{0} X {1} = {2} \n", b, a, b * a);
                                    }
                            }
            Second(0, 4);

        }
    }
}
