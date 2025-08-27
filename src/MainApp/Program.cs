using Host.Abstractions;
using B;

sealed class TestService : ITestService
{
    public int Test(int x, int y) => x + y;
}

internal class Program
{
    private static void Main(string[] args)
    {
        var plugin = new Plugin(new TestService());
        Console.WriteLine(plugin.DoWork(5));
    }
}
