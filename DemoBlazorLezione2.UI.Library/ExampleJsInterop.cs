using Microsoft.JSInterop;

namespace DemoBlazorLezione2.UI.Library
{
    // This class provides an example of how JavaScript functionality can be wrapped
    // in a .NET class for easy consumption. The associated JavaScript module is
    // loaded on demand when first needed.
    //
    // This class can be registered as scoped DI service and then injected into Blazor
    // components for use.

    public class ExampleJsInterop : IAsyncDisposable
    {
        private readonly Lazy<Task<IJSObjectReference>> moduleTask;
        private readonly Lazy<Task<IJSObjectReference>> mymoduleTask;

        public ExampleJsInterop(IJSRuntime jsRuntime)
        {
            moduleTask = new(() => jsRuntime.InvokeAsync<IJSObjectReference>(
                "import", "./_content/DemoBlazorLezione2.UI.Library/exampleJsInterop.js").AsTask());

            mymoduleTask = new(() => jsRuntime.InvokeAsync<IJSObjectReference>(
                "import", "./_content/DemoBlazorLezione2.UI.Library/MyModule.js").AsTask());
        }


        public async ValueTask<int> MiaSommaModulare(int a, int b) {
            var module = await mymoduleTask.Value;
            return await module.InvokeAsync<int>("miaSomma", a, b);
        }


        public async ValueTask<string> Prompt(string message)
        {
            var module = await moduleTask.Value;
            return await module.InvokeAsync<string>("showPrompt", message);
        }

        public async ValueTask DisposeAsync()
        {
            if (moduleTask.IsValueCreated)
            {
                var module = await moduleTask.Value;
                await module.DisposeAsync();
            }

            if(mymoduleTask.IsValueCreated)
            {
                var module = await mymoduleTask.Value;
                await module.DisposeAsync();
            }

        }
    }
}
