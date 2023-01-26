using System;

/*
0, 1, ...
Fn = Fn-1 + Fn-2

n F
1  0 //ошибка, не правильно задал вопрос
2  1
3  1
4  2
....
*/

namespace Sequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(fn(4));
        }

        static public int fn(int n)
        {
            if (n <= 1) return 0;
            if (n == 2) return 1;

            int sum = fn(n - 1)  + fn(n - 2);

            return sum;
        }
    }
}
