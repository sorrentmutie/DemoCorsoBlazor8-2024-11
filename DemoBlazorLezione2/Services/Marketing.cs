using Demo.Core.Conferenze;

namespace BlazorAppCorretta.Services;

public class Marketing : IMarketing
{
    private readonly IConfiguration configuration;

    public Marketing(IConfiguration configuration)
    {
        this.configuration = configuration;
    }

    public string EstraiTitoloConferenza()
    {

        var anno = configuration["Anno"];
        if (anno is not null)
        {
            int annoInt = int.Parse(anno);
            return $"Conferenza: {anno}";
        }
        return "";

    }
}
