namespace HelloWorldNuget
{
    using System.Collections.Generic;

    public static class GoodVibesFactory
    {
        public static string GetAGoodVibe() => "Hello World!";
        public static IEnumerable<string> GetManyGoodVibes(int number = 1)
        {
            var list = new List<string>(number);
            for (int i = 0; i < number; i++)
                list.Add(GetAGoodVibe());
            return list;
        }
    }
}
