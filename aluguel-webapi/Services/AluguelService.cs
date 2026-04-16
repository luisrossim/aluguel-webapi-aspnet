namespace aluguel_webapi.Services;

using aluguel_webapi.Data;
using aluguel_webapi.Entities;

public class AluguelService : IAluguelService
{
    private readonly AppDbContext _context;

    public AluguelService(AppDbContext context)
    {
        _context = context;
    }

    public string[] listAlugueis()
    {
        string[] alugueis = ["1", "2", "3"];   
        return alugueis;
    }

    public int createAluguel(Aluguel aluguel)
    {
        return 0;    
    }
}