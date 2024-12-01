namespace Demo.Core.Conferenze;

public interface IMarketing
{
    public string EstraiTitoloConferenza();
}

public interface IUfficioCommerciale
{
    public double EstraiPrezzoConferenza(int id);
}
