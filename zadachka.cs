// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        string x = "";
         string z = "";
        Console.WriteLine("Enter number from 1 to 5");
        int number = Convert.ToInt32(Console.ReadLine());
        
        
        int a = number / 10;
        int b = number % 10;
        
    
            if(a == 1) {
                x = "Bolshoy";
            }
            else if (a == 2){
                 x = "Ukazatelny";
            }
            else if (a == 3){
                 x = "Sredniy";
            }
            else if (a == 4){
                 x = "Bezimyanny";
            }
            else if (a == 5){
                 x = "Mizinec";
            }
            else if (a > 5){
                Console.WriteLine("Nelzya tak!");
              
            }
            
            if(a > 0 && a <= 5){
                if(b == 1) {
                z = "Bolshoy";
            }
            else if (b == 2){
                 z = "Ukazatelny";
            }
            else if (b == 3){
                 z = "Sredniy";
            }
            else if (b == 4){
                 z = "Bezimyanny";
            }
            else if (b == 5){
                 z = "Mizinec";
            }
            else if (b > 5){
                Console.WriteLine("Nelzya tak!");
            }
            }
            
        
        if(a > 0 && a <= 5 && b > 0 && b <=5){
        Console.WriteLine($"{x} and {z} finger");
        }
        
        

    }
}