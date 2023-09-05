// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine("hello");
        Console.WriteLine("welcome to C#");
        
        string name = "Tom";
        Console.WriteLine(name);
        
        name = "Bob";
        Console.WriteLine(name);
        
        const string Name = "Bob";
      //  Name = "Tom"; (выдаст ошибку, тк как константу нельзя изменить)
        Console.WriteLine(Name);
     
     //Числа в двоичной форме(пишется сначала 0b)     
     Console.WriteLine(0b11);   //3 
     Console.WriteLine(0b1011); //11    
     
     //Числа в шестнадцатеричной форме(пишется сначала 0x)
     Console.WriteLine(0xFF); //255
     Console.WriteLine(0xA1); //161
     
//     '\n' - перевод строки
//      '\t' - табуляция
//      '\\' - слеш

Console.WriteLine("Hello \nworld"); //world будет перенесено на другую строку

/* Типы данных

 хранят целые числа(их всего 8): byte, sbyte, short, ushort, int, uint, long, ulong

 хранят дробные числа(их всего 3): float, double, decimal 
 
 bool - хранит значения true/false
 
 char - хранит одиночный символ
 
 string - хранит набор символов Unicode
 
 object - хранит значение любого типа данных
 
 */

decimal d = 334.8M; // чтобы указать, что дробное число представляет тип float или тип decimal, необходимо к литералу добавлять суффикс: F/f - для float и M/m - для decimal.
Console.WriteLine(d);

// var - можно  использовать как переменную с неявным типом

// этот код работает
int a;
a = 20;
Console.WriteLine(a);
 
/* этот код не работает, тк мы не можем сначала объявить неявно типизируемую переменную, а затем инициализировать
var c;
c= 15; 

но, можно так:*/
var c = 15;
Console.WriteLine(c);

// и так же нельзя указать в качестве значения - null


// Вывод данных
string name1 = "Tom";
int age = 34;
double height = 1.7;
Console.WriteLine($"Name: {name1}  Age: {age}  Height: {height}m");
// или можно вывести так:
Console.WriteLine("Name: {0}  Age: {2}  Height: {1}m", name1, height, age); // нумерация начинается с 0


//Консольный ввод

/*Console.Write("Enter your name: ");
string? name2 = Console.ReadLine();
 
Console.Write("Enter your age: ");
int age2 = Convert.ToInt32(Console.ReadLine());
 
Console.Write("Enter your height: ");
double height2 = Convert.ToDouble(Console.ReadLine());
 
Console.Write("Enter your salary: ");
decimal salary2 = Convert.ToDecimal(Console.ReadLine());
 
Console.WriteLine($"Name: {name2}  Age: {age2}  Height: {height2}m  Salary: {salary2}$");*/


//Арифметические операции

//При делении стоит учитывать, что если оба операнда представляют целые числа, то результат также будет округляться до целого числа:

double z = 10 /  4; //результат равен 2
Console.WriteLine(z);

//Для выхода из этой ситуации необходимо определять литералы или переменные, участвующие в операции, именно как типы double или float:

double x = 10.0 /  4.0; //результат равен 2.5
Console.WriteLine(x);

//Операция получение остатка от целочисленного деления двух чисел:

double e = 10.0;
double f = e % 4.0; //результат равен 2
Console.WriteLine(f);


/*Операция инкремента

Инкремент бывает префиксным: ++x - сначала значение переменной x увеличивается на 1, а потом ее значение возвращается в качестве результата операции.

И также существует постфиксный инкремент: x++ - сначала значение переменной x возвращается в качестве результата операции, а затем к нему прибавляется 1.

int x1 = 5;
int z1 = ++x1; // z1=6; x1=6
Console.WriteLine($"{x1} - {z1}");
 
int x2 = 5;
int z2 = x2++; // z2=5; x2=6
Console.WriteLine($"{x2} - {z2}");
*/

/*Операция декремента или уменьшения значения на единицу. Также существует префиксная форма декремента (--x) и постфиксная (x--).

int x1 = 5;
int z1 = --x1; // z1=4; x1=4
Console.WriteLine($"{x1} - {z1}");
 
int x2 = 5;
int z2 = x2--; // z2=5; x2=4
Console.WriteLine($"{x2} - {z2}");
*/

/*При выполнении сразу нескольких арифметических операций следует учитывать порядок их выполнения. Приоритет операций от наивысшего к низшему:

Инкремент, декремент

Умножение, деление, получение остатка

Сложение, вычитание

Для изменения порядка следования операций применяются скобки.*/

// Логические операции (https://metanit.com/sharp/tutorial/2.22.php)
        // Операции присваивания (https://metanit.com/sharp/tutorial/2.23.php)
		// Преобразования типов данных (https://metanit.com/sharp/tutorial/2.2.php)
		// Условные выражения (https://metanit.com/sharp/tutorial/2.24.php)
		
    }
}