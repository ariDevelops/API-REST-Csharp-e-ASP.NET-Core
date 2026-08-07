using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
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
    public ActionResult<Produto> AdicionarProduto([FromBody] Produto item) // [FromBody] diz: O objeto virá no corpo da requisição
    {
        produtos.Add(item);
        return Ok(item);

        /* O Metodo OK() que vem de ActionResult, diz: HTTP 200 OK, e retorna o objeto que foi adicionado.
         * Na Prática ele envia algo equivalenta a isso:
            HTTP/1.1 200 OK
            Content-Type: application/json
        */
    }


    [HttpGet("{id}")]
    public ActionResult<Produto> BuscarPorId(int id)
    {
        //FirstOrDefault lê-se assim:
        //"Percorra a lista e devolva o primeiro produto cujo Id seja igual ao id informado."
        var produto = produtos.FirstOrDefault(p => p.Id == id); // dentro dos () é uma expressão lambda

        if (produto == null)
        {
           return NotFound();
        }

        return Ok(produto);
    }


}
