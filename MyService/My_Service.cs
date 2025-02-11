using System;

namespace WCFMyServiceLibrary
{
    public class MyService : IMyService
    {
        public double GetSum(double i, double j)
        {
            return i + j;
        }

        public double GetMult(double i, double j)
        {
            return i * j;
        }

        public string SayHi()
        {
            return "Helloooo";
        }
    }
}