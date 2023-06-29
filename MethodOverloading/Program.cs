using System.Diagnostics.CodeAnalysis;

namespace MethodOverloading
{
    public class Program
    {
        public static int add(int x, int y)
        {
            return x + y;
        }

        public static double add(double x, double y)
        {
            return x + y;
        }

        public static string add(int x, int y, bool dollar)
        {
            int sum = x + y;
            if (dollar == true)
            {
                if (sum == 1 || sum == -1)
                {
                    return $"{sum} dollar";
                }
                else
                {
                    return $"{sum} dollars";
                }
            }
            else
            {
                return $"{sum}";
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine(add(1, 2));
            Console.WriteLine(add(1.1, 2.0));
            Console.WriteLine(add(1, 0, true));
        }
    }
}
