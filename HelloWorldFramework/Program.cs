namespace HelloWorldFramework
{
    using HelloWorldNuget;

    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            var vibes = GoodVibesFactory.GetAGoodVibe();
            Console.WriteLine("Vibes:", vibes);
            Console.Read();
        }
    }
}
