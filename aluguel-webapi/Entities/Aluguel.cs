namespace aluguel_webapi.Entities;

public class Aluguel
{
    public string Name {get; set;} = string.Empty;
    public bool IsEnabled;

    Aluguel(string name, bool isEnabled)
    {
        Name = name;
        IsEnabled = isEnabled;
    }
}