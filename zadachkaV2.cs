
using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
 
        Console.WriteLine("Enter number from 1 to 5");
        int number = Convert.ToInt32(Console.ReadLine());


        int a = number / 10;
        int b = number % 10;


        void detectFinger(int palec)
        {
            switch (palec)
            {
                case 1:
                    Console.WriteLine("Bolshoy");
                    break;

                case 2:
                    Console.WriteLine("Ukazatelny");
                    break;

                case 3:
                    Console.WriteLine("Sredniy");
                    break;

                case 4:
                    Console.WriteLine("Bezimyanniy");
                    break;

                case 5:
                    Console.WriteLine("Mizinec");
                    break;

            }

        }


        if (a > 0 && a <= 5 && b > 0 && b <= 5)
        {
            detectFinger(a);
            detectFinger(b);
        }
        else
        {
            Console.WriteLine("Nelzya tak!");
        }

    }
}