using System;

namespace pg6
{
    class Program
    {
        private static object end;

        public static void Main()
        {
            string str = Console.ReadLine();
            int age = Convert.ToInt32(str);
            calculate(age);           
        }
        private static int calculate(int dd)
        {
            int yy = dd / 365;
            int mm = dd / 30;
            int ww = dd / 7;
            Console.WriteLine(yy+ ":Year  "+ mm+ ":Moanth  "+ ww+ ":Week  "+ dd+ ":Day  ");
            return dd;
        }
    }
}
