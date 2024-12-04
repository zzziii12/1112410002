using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1112410002
{
    internal class Program
    {
        //1112410002馮子玹
        public static double CountPi(int n)
        {
            // 驗證範圍並回傳錯誤值
            if (n < 4 || n > 15) return -1;

            double pi = 0.0;
            // 使用萊布尼茲公式計算 π
            for (int i = 0; i < n; i++)
            {
                pi += (i % 2 == 0 ? 1 : -1) * 1.0 / (2 * i + 1);
            }
            return pi * 4.0;
        }

        public static double CalculateCircumference(double radius)
            => 2 * CountPi(15) * radius;

        public static double CalculateArea(double radius)
            => CountPi(15) * radius * radius;

        static void Main()
        {
            Console.WriteLine("請選擇功能：");
            Console.WriteLine("1. 計算圓周率");
            Console.WriteLine("2. 計算圓周長");
            Console.WriteLine("3. 計算圓面積");
            Console.Write("請輸入選項 (1-3): ");

            if (!int.TryParse(Console.ReadLine(), out int option))
            {
                Console.WriteLine("輸入無效！");
                return;
            }

            switch (option)
            {
                case 1:
                    HandlePiCalculation();
                    break;
                case 2:
                    HandleCircumferenceCalculation();
                    break;
                case 3:
                    HandleAreaCalculation();
                    break;
                default:
                    Console.WriteLine("無效的選項！");
                    break;
            }
        }

        private static void HandlePiCalculation()
        {
            Console.Write("請輸入計算 pi 的項數 (4 到 15): ");
            if (int.TryParse(Console.ReadLine(), out int n))
            {
                double piApprox = CountPi(n);
                if (piApprox == -1)
                    Console.WriteLine("輸入項數超出範圍！請輸入 4 到 15 之間的值。");
                else
                    Console.WriteLine($"使用 {n} 項近似的 Pi 值為: {piApprox:F15}");
            }
            else
            {
                Console.WriteLine("輸入無效！");
            }
        }

        private static void HandleCircumferenceCalculation()
        {
            Console.Write("請輸入圓的半徑: ");
            if (double.TryParse(Console.ReadLine(), out double radius))
            {
                Console.WriteLine($"圓的周長為: {CalculateCircumference(radius):F15}");
            }
            else
            {
                Console.WriteLine("輸入無效！");
            }
        }

        private static void HandleAreaCalculation()
        {
            Console.Write("請輸入圓的半徑: ");
            if (double.TryParse(Console.ReadLine(), out double radius))
            {
                Console.WriteLine($"圓的面積為: {CalculateArea(radius):F15}");
            }
            else
            {
                Console.WriteLine("輸入無效！");
            }
        }
    }
}
