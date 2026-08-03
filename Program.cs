// Essa linha cria um objeto responsavel por configurar toda a aplicação antes dela 
// começar a funcionar, como um "engenheiro que prepara o terreno"
var builder = WebApplication.CreateBuilder(args);




// Sem esta linha, seus controllers existirão, porém nunca serão encontrados pelo aspnet
// Em outras palavars, ele registra o suporte a controllers...
// É como se estivessem dizendo: "ASP.NET, procure classes chamadas Controllers e permita que elas recebam requisições HTTP"
builder.Services.AddControllers();




var app = builder.Build();

app.MapControllers();

app.Run();