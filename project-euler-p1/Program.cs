using System;

namespace project_euler_p1
{
    class Program
    {
        static void Main(string[] args)
        {
            var answer = 0;
            for (var i = 0; i < 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    answer += i;
                }
            }

            Console.WriteLine($"Answer: {answer}");
        }
    }
}
