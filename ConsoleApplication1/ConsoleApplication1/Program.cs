using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //改背景跟字的顏色
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Blue;
            //讓使用者輸入身高體重並讓電腦將輸入的數字剖析
            Console.Write("請輸入身高:");
            double high = double.Parse(Console.ReadLine());
            Console.Write("請輸入體重:");
            double weight = double.Parse(Console.ReadLine());
            //BMI計算
            double BMI = weight / ((high * 0.01)* (high * 0.01));
            //讓電腦顯示BMI
            Console.WriteLine("您的BMI值是:" + BMI);
            //條件們
            if (BMI <18.5)
            {
                Console.WriteLine("您的體重過輕");
            }
            if (18.5<=BMI && BMI<24 )
            {
                Console.WriteLine("您的體重正常");
            }
            else
            {
                Console.WriteLine("您的體重過重");
            }
            if(16.5<=BMI && BMI<=31.5)
            {
                Console.WriteLine("您的體重符合兵役標準");
            }
            else
            {
                Console.WriteLine("您的體重不符合兵役標準");
            }
            //結束
            Console.ReadLine();


        }
    }
}
