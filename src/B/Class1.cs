using Host.Abstractions;

namespace B;

public sealed class Plugin
{
    private readonly ITestService _svc;

    public Plugin(ITestService svc)
    {
        _svc = svc;
    }

    public int DoWork(int i)
    {
        return _svc.Test(i);
    }
}
