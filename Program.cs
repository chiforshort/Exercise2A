using System;

namespace Exercise2A
{
    class Program
    {
        public static int Sum(int num1, int num2)
        {
            int total;
            total = num1 + num2;
            return total;
        }

        public static void Main()
        {
            Console.WriteLine("Addition In Console App");
            Console.Write("Number 1: ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Number 2: ");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Sum(n1, n2));

            Console.WriteLine("GPA with Test Score");

            int test1, test2, test3, test4, test5, test6, test7, test8, test9, test10;
            double Average = 0;

            Console.WriteLine("Test Score #1: ");
            test1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Test Score #2: ");
            test2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Test Score #3: ");
            test3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Test Score #4: ");
            test4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Test Score #5: ");
            test5 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Test Score #6: ");
            test6 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Test Score #7: ");
            test7 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Test Score #8: ");
            test8 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Test Score #9: ");
            test9 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Test Score #10: ");
            test10 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("GPA: {0}", Convert.ToInt32(test1 + test2 + test3 + test4 + test5 + test6 + test7 + test8 + test9 + test10) / 10.0);
            Console.WriteLine("What is your Average: ");
            Console.ReadLine();

            if (Average >= 90.00)
            {
                Console.WriteLine('A');
            }
            else if (GPA >= 80.00)
            {
                Console.WriteLine('B');
            }
            else if (GPA >= 70.00)
            {
                Console.WriteLine('C');
            }
            else if (GPA >= 60.00)
            {
                Console.WriteLine('D');
            }
            else
            {
                Console.WriteLine('F');
            }

                



        }
    }

}


