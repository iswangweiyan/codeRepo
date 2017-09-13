//常量可以被当作常规的变量，只是它们的值在定义后不能被修改。


//字符串常量
//字符常量是括在双引号 "" 里，或者是括在 @"" 里。
string a = "Hello World";
string b = @"hello, world";


//定义和使用常量：

using System;

namespace DeclaringConstants  
{
    class Program
    {
      static void Main(string[] args)
      {
        //声明常量
        const double pi = 3.14159;
        double r;
        System.Console.WriteLine("Enter Radius:");

        //输出r
        r = convert.ToDouble(Console.ReadLine());
        double areaCircle = pi * r * r;
        Console.WriteLine("Radius: {0}, Area: {1}", r, areaCircle);
        Console.ReadLine();
      }
    }
}
/*
Enter Radius: 
3
Radius: 3, Area: 28.27431
 */