
/*
算术运算符 

 + - * /  加减乘除

 %  取模
 ++ 自加1
 -- 自减1

 */

 using System;
 namespace OperatorsApp
 {
     class Program
     {
         static void Main(string[] args)
         {
           int a = 21;
           int b = 10;
           int c;

           c = a + b;
           Console.WriteLine("c = {0}", c);
           c = a - b;
           Console.WriteLine("c = {0}", c);
           c = a * b;
           Console.WriteLine("c = {0}", c);
           c = a / b;
           Console.WriteLine("c = {0}", c);
           c = a % b;
           Console.WriteLine("c = {0}", c);

           c = ++a;
           Console.WriteLine("c = {0}", c);

           c = --a;
           Console.WriteLine("c = {0}", c);

           Console.ReadLine();
         }
     }
 }

 //关系运算符
using System;

class Program
{
  static void Main(string[] args)
  {
      int a = 21;
      int b = 10;
      
      if (a == b)
      {
          Console.WriteLine("Line 1 - a 等于 b");
      }
      else
      {
          Console.WriteLine("Line 1 - a 不等于 b");
      }
      if (a < b)
      {
          Console.WriteLine("Line 2 - a 小于 b");
      }
      else
      {
          Console.WriteLine("Line 2 - a 不小于 b");
      }
      if (a > b)
      {
          Console.WriteLine("Line 3 - a 大于 b");
      }
      else
      {
          Console.WriteLine("Line 3 - a 不大于 b");
      }
      /* 改变 a 和 b 的值 */
      a = 5;
      b = 20;
      if (a <= b)
      {
         Console.WriteLine("Line 4 - a 小于或等于 b");
      }
      if (b >= a)
      {
         Console.WriteLine("Line 5 - b 大于或等于 a");
      }
  }
}

//逻辑运算符  && || ! 与 或 非
using System;

namespace OperatorsAppl
{
    class Program
    {
        static void Main(string[] args)
        {
            bool a = true;
            bool b = true;
           
            if (a && b)
            {
               Console.WriteLine("Line 1 - 条件为真");
            }
            if (a || b)
            {
                Console.WriteLine("Line 2 - 条件为真");
            }
            /* 改变 a 和 b 的值 */
            a = false;
            b = true;
            if (a && b)
            {
                Console.WriteLine("Line 3 - 条件为真");
            }
            else
            {
                Console.WriteLine("Line 3 - 条件不为真");
            }
            if (!(a && b))
            {
                Console.WriteLine("Line 4 - 条件为真");
            }
            Console.ReadLine();
        }
    }
}

//位运算符

//赋值运算符
/*
C = A + B 将把 A + B 的值赋给 C
C += A 相当于 C = C + A
C -= A 相当于 C = C - A
C *= A 相当于 C = C * A
C /= A 相当于 C = C / A
C %= A 相当于 C = C % A
C <<= 2 等同于 C = C << 2
C >>= 2 等同于 C = C >> 2
C &= 2 等同于 C = C & 2
C ^= 2 等同于 C = C ^ 2
C |= 2 等同于 C = C | 2
 */

 //其他运算符
using System;

namespace OperatorsAppl
{
    
   class Program
   {
      static void Main(string[] args)
      {
         
         /* sizeof 运算符的实例 */
         Console.WriteLine("int 的大小是 {0}", sizeof(int));
         Console.WriteLine("short 的大小是 {0}", sizeof(short));
         Console.WriteLine("double 的大小是 {0}", sizeof(double));
         
         /* 三元运算符符的实例 */
         int a, b;
         a = 10;
         b = (a == 1) ? 20 : 30;
         Console.WriteLine("b 的值是 {0}", b);

         b = (a == 10) ? 20 : 30;
         Console.WriteLine("b 的值是 {0}", b);
         Console.ReadLine();
      }
   }
}
/*
int 的大小是 4
short 的大小是 2
double 的大小是 8
b 的值是 30
b 的值是 20
 */