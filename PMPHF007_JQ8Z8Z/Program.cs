using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMPHF007_JQ8Z8Z
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToCharArray();
            string tempString = "";
            for (int i = 0; i < input.Length; i++)
            {
                tempString += input[i];
                if ((i + 1) % 2 == 0)
                {
                    double tempNumber = double.Parse(tempString) / 10;
                    if (tempNumber >= 0 && tempNumber <= 0.8) Console.Write("0");
                    if (tempNumber >= 2.7 && tempNumber <= 5) Console.Write("1");
                    if (tempNumber > 0.8 && tempNumber < 2.7) Console.Write("E");
                    tempString = "";
                    tempNumber = 0;
                }
            }
            Console.ReadLine();
        }
    }
}
