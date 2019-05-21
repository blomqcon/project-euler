using System;

namespace project_euler_p2
{
    class Program
    {
        static void Main(string[] args)
        {
            var f1 = 1;
            var f2 = 2;

            var answer = 2;
            while (f2 < 4_000_000)
            {
                var fNew = f1 + f2;
                if (fNew % 2 == 0)
                {
                    answer += fNew;
                }

                f1 = f2;
                f2 = fNew;
            }

            Console.WriteLine($"Answer: {answer}");
        }
    }
}
