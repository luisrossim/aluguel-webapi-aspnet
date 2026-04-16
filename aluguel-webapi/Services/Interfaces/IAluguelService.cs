using aluguel_webapi.Entities;

public interface IAluguelService
{
    string[] listAlugueis();
    int createAluguel(Aluguel aluguel);
}