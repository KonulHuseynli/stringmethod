using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Konul Mirsaleh Aysun";


            char[] arr;
            arr = name.ToCharArray();


            {
                for (int i = arr.Length - 1; i >= 0; i--)
                {
                    Console.WriteLine(arr[i]); ;

                }
            }
        }
    }
}
