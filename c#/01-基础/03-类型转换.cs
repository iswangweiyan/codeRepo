/*
把数据从一种类型转换为另一种类型。在 C# 中，类型铸造有两种形式：
- 隐式类型转换 - 这些转换是 C# 默认的以安全方式进行的转换, 不会导致数据丢失。例如，从小的整数类型转换为大的整数类型，从派生类转换为基类。
- 显式类型转换 - 显式类型转换，即强制类型转换。显式转换需要强制转换运算符，而且强制转换会造成数据丢失。 
*/

namespace TypeConversionApplication
{
    class ExplicitConversion
    {
        static void Main(string[] args)
        {
          double d = 5673.74;
          int i;

          //强制转换
          i = (int)d;
          System.Console.WriteLine(i);
          System.Console.ReadKey();
        }
    }
}

/*内置转换方法
ToBoolean     转布尔类型
ToByte        转字节类型
ToChar        转单个Unicode字符类型
ToDataTime  （整数或字符串类型）转换为 日期-时间 结构
ToDecimal     浮点型或整数类型转换为十进制类型。
ToDouble      类型转换为双精度浮点型。

ToInt16
ToInt32       转换为16  32  64位整数类型。
ToInt64

ToSbyte       转换为有符号字节类型。
ToSingle      转换为小浮点数类型。
ToString      转换为字符串类型。
ToType        转换为指定类型。

ToUInt16
ToUInt32      转换为16 32 64位无符号整数类型。
ToUInt64

 */

 namespace TypeConversionApplication
 {
   class StringConversion
   {
       static void Main(string[] args)
       {
         int i = 75;
         float f = 53.005f;
         double d = 2345.7652;
         bool b = ture;

         //转换
         System.Console.WriteLine(i.ToString());
         System.Console.WriteLine(f.ToString());
         System.Console.WriteLine(d.ToString());
         System.Console.WriteLine(b.ToString());
         Console.ReadKey();
       }
   }
 }



 //类型转换 - Convert和Parse

 string locstr = 123.ToString();
 //将locstr转整形数

 //方法一： 用Convert
 int i = Convert.ToInt16(locstr);

 //方法二：用 Parse
 int ii = int.Parse(locstr);
 


 /******************************************************************************* */
/*
字符串转int类型方法        int.TryParse(string s,out int i)

该方式也是将数字内容的字符串转换为int类型，但是该方式比int.Parse(string s) 
好一些，它不会出现异常，最后一个参数result是输出值，如果转换成功则输出相应的值，转换失败则输出0。 
*/
//实例
class test 
{
    static void Main(string[] args)
    {
      string s1 = "abcd";
      string s2 = "1234";
      int a,b;
      bool bo1 = int.TryParse(s1,out a);
      System.Console.WriteLine(s1+""+bo1+""+b);
      bool bo2 = int.TryParse(s2,out b);
      System.Console.WriteLine(s2+""+bo2+""+b);
    }
}
/*结果
abcd False 0
1234 True 1234 
*/