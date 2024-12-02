using System.Text.Json.Serialization;

namespace DemoBlazorLezione2.Core.ReqRes;

public class ReqResResponse
{
    public int page { get; set; }
    public int per_page { get; set; }
    public int total { get; set; }
    public int total_pages { get; set; }
    [JsonPropertyName("data")]
    public Person[]? People { get; set; } 
    public Support? support { get; set; }
}

public class Support
{
    public string? url { get; set; }
    public string? text { get; set; }
}

public class Person
{
    public int id { get; set; }
    public string? email { get; set; }
    public string? first_name { get; set; }
    public string? last_name { get; set; }
    public string? avatar { get; set; }
}


