using System;

namespace DataTypeApplication
{
    class Program
    {
        static void Mian(string[] args)
        {
          System.Console.WriteLine("Size of int: {0}", sizeof(int));
          Console.ReadLine();
        }
    }
}

/************************************************************************ */
 /*
 对象（Object）类型是所有数据类型的基类，Object 是 System.Object 类的别名
  */

//一个个值类型转换为对象类型时，则被称为 装箱；另一方面，当一个对象类型转换为值类型时，则被称为 拆箱。
  Object obj;
  obj = 100; //装箱

//动态（dynamic)类型，存储任何类型的值在动态数据类型变量中。这些变量的类型检查是在运行时发生的。
  dynamic <variable_name> = value;
  dynamic d = 20;


/*
 - 字符串（String）类型是 System.String 类的别名
 */
  //字符串类型
  String str = "runoob.com";
  //@引号字符串类型
  @"runoob.com";

  //字符串（String）类型是 System.String 类的别名
  //string 字符串的前面可以加 @（称作"逐字字符串"）将转义字符（\）当作普通字符对待

  string str =  @"C:\Windows";
  //等价于
  string str = "C:\\Windows";

//@ 字符串中可以任意换行，换行符及缩进空格都计算在字符串长度之内。
string str = @"<script type=""text/javascript"">
<!--
-->
</script>";

/*指针类型（Pointer types） */
//指针类型变量存储另一种类型的内存地址。C# 中的指针与 C 或 C++ 中的指针功能相同
//申明
type* identifier;

//例如：
char* cptr;
int* iptr;







//补充 string 和 String的区别
/*
string是c#中的类，String是.net Framework的类(在C# IDE中不会显示蓝色) C# string映射为.net Framework的String 如果用string,编译器会把它编译成String，所以如果直接用String就可以让编译器少做一点点工作。

　　如果使用C#，建议使用string，比较符合规范 string始终代表 System.String(1.x) 或 ::System.String(2.0) ，String只有在前面有using System;的时候并且当前命名空间中没有名为String的类型（class、struct、delegate、enum）的时候才代表System.String string是关键字，String不是，也就是说string不能作为类、结构、枚举、字段、变量、方法、属性的名称，而String可以。

　　String是CLR的类型名称（也算是关键字），而string是C#中的关键字。string在编译时候C#编译器会默认将其转换为String，在这里会多增加几行转换的代码。很多时候都是建议使用CLR的类型而不要使用C#的类型（这是专家的建议）。比如说还有：使用int的时候最好使用Int32等。很多时候都是一个习惯问题，规范问题。还有一个不同就是在VS中表现的颜色不一样：String是绿色，string是蓝色。
 */