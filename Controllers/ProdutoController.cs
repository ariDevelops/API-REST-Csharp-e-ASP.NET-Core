using Microsoft.AspNetCore.Mvc;

namespace EstoqueApi.Controllers;


[ApiController]             // Diz: Essa classe é um Controller de API
[Route("api/produtos")]     // define a rota padrao:  http://localhost:xxxx/api/produtos
public class ProdutoController : ControllerBase
{


    [HttpGet]               // Diz: Quando Alguém executar um GET na rota padrao, execute este método
    public string Teste()
    {
        return "Minha primeira API REST EM ASP.NET!";
    }

    [HttpGet("ping")]      // Adiciona um novo caminho a rota padrão: http://localhost:xxxx/api/produtos/ping
    public string Ping()
    {
        return "pong";
    }

}
