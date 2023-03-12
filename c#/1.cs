using System;

namespace NurbaiITc-20/29.10.21
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int a = 10, b = 3, c = a + b, d = a + b * c;
            Console.WriteLine("the sum of a and b = " + c);
            Console.WriteLine("a + b * c = " + d);
            Console.ReadKey(); 
            */
            /*for (int i = -5; i <= 5; i++)
            {
                Console.WriteLine(2 * (i*i)- 5 );
            }
            Console.ReadKey();
            */
            /*double value;
            Console.WriteLine("Enter any number =" );
            value = Convert.ToDouble(Console.ReadLine());
            if (value > 10)
            {
                Console.WriteLine("you entered a number greater than 10") ;
            }
            else if(value < 10 )
            {
                Console.WriteLine("you entered a number less than 10");
            }
            Console.ReadKey();
            */
            /*string name;
            Console.WriteLine("Enter your name =");
            name = Convert.ToString(Console.ReadLine());
            if (name == "Nurba")
            {
                Console.WriteLine("This is correct name");
            }
            else Console.WriteLine("This one is not correct name");
            Console.ReadKey();
            */
            {
                while (true)
                {
                    int[] students;
                    students = new int[5];
                    students[0] = 1;
                    students[1] = 2;
                    students[2] = 3;
                    students[3] = 4;
                    students[4] = 5;
                    int name;
                    Console.WriteLine("Enter student number =");
                    name = Convert.ToInt32(Console.ReadLine());
                    if (students[0] == name)
                    {
                        Console.WriteLine("Number 1 is Bektan's number");
                    }
                    else if (students[1] == name)
                    {
                        Console.WriteLine("Number 2 is Eles's number");
                    }
                    else if (students[2] == name)
                    {
                        Console.WriteLine("Number 3 is Anna's number");
                    }
                    else if (students[3] == name)
                    {
                        Console.WriteLine("Number 4 is Jeka's number");
                    }
                    else if (students[4] == name)
                    {
                        Console.WriteLine("Number 5 is Nurta's number");
                    }
                    else Console.WriteLine("No such number exists");
                    Console.ReadKey();
                        Console.Clear();
                }
                

            }
        }
    }
}
