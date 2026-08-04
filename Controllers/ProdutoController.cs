using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using EstoqueApi.Models;

namespace EstoqueApi.Controllers;


[ApiController]             // Diz: Essa classe é um Controller de API
[Route("api/produtos")]     // define a rota padrao:  http://localhost:xxxx/api/produtos
public class ProdutoController : ControllerBase
{
        private static List<Produto> produtos = new()
    {
        new Produto
        {
            Id = 1,
            Nome = "Mouse Gamer",
            Preco = 149.90m
        },

        new Produto
        {
            Id = 2,
            Nome = "Teclado Mecânico",
            Preco = 289.90m
        }
    };


    [HttpGet]               // Diz: Quando Alguém executar um GET na rota padrao, execute este método
    public Produto Teste()
    {
        return new Produto
        {
            Id = 1,
            Nome = "Produto Teste",
            Preco = 99.99m
        };
    }



    [HttpGet("lista")]
    public List<Produto> GetProdutos()
    {
        return produtos;
    }



    [HttpPost]
    public string AdicionarProduto([FromBody] Produto item) // [FromBody] diz: O objeto virá no corpo da requisição
    {
        produtos.Add(item);
        return "Produto adicionado com sucesso";
    }


}
