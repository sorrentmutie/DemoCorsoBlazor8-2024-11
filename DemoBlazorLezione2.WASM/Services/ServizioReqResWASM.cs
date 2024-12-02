using DemoBlazorLezione2.Core.ReqRes;
using System.Net.Http.Json;

namespace DemoBlazorLezione2.WASM.Services;

public class ServizioReqResWASM : IReqResData
{
    private readonly HttpClient httpClient;
    private CancellationTokenSource? cancellationTokenSource;

    public ServizioReqResWASM(HttpClient httpClient)
    {
        this.httpClient = httpClient;
    }

    public void CancelRequest()
    {
        if(cancellationTokenSource != null)
        {
            cancellationTokenSource.Cancel();
        }
    }

    public async Task<ReqResResponse?> GetPeopleAsync()
    {
        cancellationTokenSource = new CancellationTokenSource();
        var response = await httpClient.GetAsync("https://reqres.in/api/users?page=2&delay=5",
            cancellationTokenSource.Token);

        if (response.IsSuccessStatusCode)
        {
            return await response.Content.ReadFromJsonAsync<ReqResResponse>();
        } else
        {
            return null;
        }

    }
}
