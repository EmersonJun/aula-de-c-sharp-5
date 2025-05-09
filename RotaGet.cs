using ApiLivros.Models;

namespace ApiLivros.Routes;
public static class RotaGet{
    public static void MapGetRoutes(this WebApplication app){
        List<Livro> livros = new List<Livro>
        {
            new Livro{id = 1, titulo = "harry potter", autor = "jk rollin"}
        };
    //ROTA GET RAIZ
        app.MapGet("/", () => "api de livros esta em funcionamento");

    //ROTA GET - LISTAR TODOS OS LIVROS
        app.MapGet("/api/livros", ()= livros);

    //ROTA GET - BUSCAR LIVROS POR ID
        app.MapGet("/api/livros/id"), (int id);
        {
            var Livro = livros.FirstDefault (Livro => Livro.id);
            return Livro != null? Results.Ok(Livro) : Results.NotFound ("livro nao encontrado");
        }
    }
}