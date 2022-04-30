using System;

namespace FirstTask
{
    public class Program
    {
        /// <summary>
        /// Returns the longest string of non-repeating characters
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            string input = "";
            string res = "";
            string end = "";
            Console.WriteLine("String analysis\r");
            Console.WriteLine("---------------\n");
            Console.WriteLine("Enter the string to be examined");
            input = Console.ReadLine();
            res = input;
            end = input.Substring(0, 1);

            for (int i = 0; i < input.Length - 1; i++)
            {
                if (input[i] == input[i + 1])
                {
                    res = res.Substring(0, i + 1);
                    input = input.Substring(i + 1);

                    if (res.Length >= end.Length)
                    {
                        end = res;
                    }
                    if (end.Length > input.Length)
                    {
                        break;
                    }
                    res = input;
                    i = 0;
                }
            }

            Console.WriteLine("");
            Console.WriteLine("result is:");
            Console.WriteLine(end);
        }
    }
}

