namespace EstoqueApi.Models;

/*
Model:
    É uma classe C# comum.
    Isso é importante.
    Um Model não sabe que existe HTTP.
    Ele apenas representa um objeto do sistema.
*/
public class Produto
{
    public int Id { get; set; }
    public string Nome { get; set; } = string.Empty;
    //public int Quantidade { get; set; }
    public decimal Preco { get; set; }

}
