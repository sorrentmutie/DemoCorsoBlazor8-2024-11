namespace DemoBlazorLezione2.Core.ReqRes;

public interface IReqResData
{
    Task<ReqResResponse?> GetPeopleAsync();
    void CancelRequest();
}
