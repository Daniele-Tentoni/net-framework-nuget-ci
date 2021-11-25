namespace HelloWorldCore
{
    using HelloWorldNuget;

    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            var vibe = GoodVibesFactory.GetAGoodVibe();
            Console.WriteLine("Hello World {0}!", vibe);
            Console.Read();
        }
    }
}
