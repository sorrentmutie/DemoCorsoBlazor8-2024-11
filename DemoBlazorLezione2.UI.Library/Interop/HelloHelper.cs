using Microsoft.JSInterop;

namespace DemoBlazorLezione2.UI.Library.Interop;

public class HelloHelper
{
    public HelloHelper(string name)
    {
        Name = name;
    }

    public string Name { get; }

    [JSInvokable]
    public string SayHello()
    {
        return $"Hello, {Name}!";
    }
}
