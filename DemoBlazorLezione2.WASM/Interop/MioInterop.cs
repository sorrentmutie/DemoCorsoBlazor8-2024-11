using Microsoft.JSInterop;

namespace DemoBlazorLezione2.WASM.Interop;

public class MioInterop: IDisposable
{
    private readonly IJSRuntime jSRuntime;
    private DotNetObjectReference<HelloHelper>? objectReference;

    public MioInterop(IJSRuntime jSRuntime)
    {
        this.jSRuntime = jSRuntime;
    }

    public async Task<int> Somma(int a, int b)
    {
        return await jSRuntime.InvokeAsync<int>("miaSomma", a, b);
    }

    public async Task SayHello(string name)
    {
         var helloHelper = new HelloHelper(name);
         objectReference = DotNetObjectReference.Create(helloHelper);
         await jSRuntime.InvokeVoidAsync("sayHello", objectReference);
    }

    public void Dispose()
    {
        if(objectReference != null)
        {
            objectReference.Dispose();
        }
    }

    public async Task OpenModal(string Id)
    {
        await jSRuntime.InvokeVoidAsync("showModal", Id);
    }

    public async Task CloseModal()
    {
        await jSRuntime.InvokeVoidAsync("hideModal");
    }
}
