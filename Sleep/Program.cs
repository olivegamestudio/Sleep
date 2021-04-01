using System;
using System.Threading;

namespace Sleep
{
    class Program
    {
        static void Main(string[] args)
        {
            int timeMilliseconds = int.Parse(args[0]);
            Thread.Sleep(timeMilliseconds);
        }
    }
}
