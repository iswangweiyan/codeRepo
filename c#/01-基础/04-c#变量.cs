/*
整数： sbyte byte short ushort int uint long ulong char
浮点： double float
十进制： decimal
布尔： ture false
空类型：
 */

 //定义变量
 //<data_type><variable_list>
//data_type 必须是一个有效的 C# 数据类型，可以是 char、int、float、double 或其他用户自定义的数据类型。variable_list 可以由一个或多个用逗号分隔的标识符名称组成。

int i, j, k;
char c, ch;
float f, falary;
double d;

//定义变量初始化
int i = 100;

//实例代码
namespace VariableDefintion
{
    class Program
    {
        static void Main {string[] args}
        {
          short a;
          int b;
          double c;

          /*实际初始化 */
          a = 10;
          b = 20;
          c = a + b;
          System.Console.WriteLine("a = {0}, b = {1}, c = {2}", a, b, c);
          System.Console.ReadLine();
        }
        
    }
}
// a=10 b=20 c = 30


//System 命名空间中的 Console 类提供了一个函数 ReadLine()，用于接收来自用户的输入，并把它存储到一个变量中。
int num;
num = convert.ToInt32(Console.ReadLine())
//函数 Convert.ToInt32() 把用户输入的数据转换为 int 数据类型，因为 Console.ReadLine() 只接受字符串格式的数据。