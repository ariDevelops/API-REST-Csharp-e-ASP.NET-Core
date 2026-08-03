// Essa linha cria um objeto responsavel por configurar toda a aplicação antes dela 
// começar a funcionar, como um "engenheiro que prepara o terreno"
var builder = WebApplication.CreateBuilder(args);




// Sem esta linha, seus controllers existirão, porém nunca serão encontrados pelo aspnet
// Em outras palavars, ele registra o suporte a controllers...
// É como se estivessem dizendo: "ASP.NET, procure classes chamadas Controllers e permita que elas recebam requisições HTTP"
builder.Services.AddControllers();







/* Agora toda a configuração é transformada em uma aplicação pronta para executar.
Até aqui nada está ouvindo a rede.
Ainda estamos apenas montando a aplicação.
*/
var app = builder.Build();




 
/*
 * Esta é uma das linhas mais importantes.
 * Ela diz: "Todas as rotas definidas dentro dos controllers deverão responder ás requisições"
 *
 * Sem ela => 404 Not Found Para qualquer endpoint
 */
app.MapControllers();



// Agora sim! A aplicação começa a ouvir requisições HTTP na porta definida no arquivo de configuração (appsettings.json)
app.Run();