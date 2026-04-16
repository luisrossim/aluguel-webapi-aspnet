using Microsoft.AspNetCore.Mvc;

namespace aluguel_webapi.Controllers;

[Controller]
[Route("/aluguel")]
public class AluguelController : ControllerBase
{
    //deps

    //construtor

    [HttpGet("{id}")]
    public IActionResult GetById(string id) 
    {
        string[] alugueis = {"123", "456", "789"};

        bool aluguelExist = alugueis.Any(aluguel => aluguel == id);

        if(!aluguelExist)
        {
            return NotFound("Nao encontrado");
        }

        return Ok("Aluguel encontrado");
    }
}