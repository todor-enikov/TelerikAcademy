using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.PrintFirst50Members
{
    public class Startup
    {
        public static void Main()
        {
            Console.Write("Enter a number: ");
            var input = int.Parse(Console.ReadLine());
            Startup.TaskWithQueue(input);
            Startup.TaskWithStack(input);
        }

        public static void TaskWithQueue(int input)
        {
            var step = 1;
            var counterForQueue = 0;
            var queue = new Queue<int>();
            queue.Enqueue(input);
            do
            {
                var nextElement = queue.ElementAt(counterForQueue);
                var nextfirstCalculation = nextElement + 1;
                queue.Enqueue(nextfirstCalculation);
                var nextSecondCalculation = 2 * nextElement + 1;
                queue.Enqueue(nextSecondCalculation);
                var nextThirdCalculation = nextElement + 2;
                queue.Enqueue(nextThirdCalculation);
                step += 3;
                counterForQueue += 1;
            } while (queue.Count <= 50);

            Console.WriteLine("With queue!");
            Console.WriteLine(string.Join(", ", queue));
        }

        public static void TaskWithStack(int input)
        {
            var step = 1;
            var counterForQueue = 0;
            var stack = new Stack<int>();
            stack.Push(input);
            do
            {
                var nextElement = stack.ElementAt(counterForQueue);
                var nextfirstCalculation = nextElement + 1;
                stack.Push(nextfirstCalculation);
                var nextSecondCalculation = 2 * nextElement + 1;
                stack.Push(nextSecondCalculation);
                var nextThirdCalculation = nextElement + 2;
                stack.Push(nextThirdCalculation);
                step += 3;
                counterForQueue += 1;
            } while (stack.Count <= 50);
            stack.Pop();
            stack.Pop();

            Console.WriteLine("With stack!");
            Console.WriteLine(string.Join(", ", stack));
        }
    }
}
