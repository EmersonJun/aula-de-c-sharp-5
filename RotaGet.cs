using ApiLivros.Models;

namespace ApiLivros.Routes;
public static class RotaGet{
    public static void MapGetRoutes(this WebApplication app){
        List<Livro> livros = new List<Livro>
        {
            new Livro { Id = "Harry1", Titulo = "Harry Potter e a Pedra Filosofal", Autor = "J.K. Rowling", AnoLivro = 1997, AnoFilme = 2001 },
            new Livro { Id = "Harry2", Titulo = "Harry Potter e a Câmara Secreta", Autor = "J.K. Rowling", AnoLivro = 1998, AnoFilme = 2002 },
            new Livro { Id = "Harry3", Titulo = "Harry Potter e o Prisioneiro de Azkaban", Autor = "J.K. Rowling", AnoLivro = 1999, AnoFilme = 2004 },
            new Livro { Id = "Harry4", Titulo = "Harry Potter e o Cálice de Fogo", Autor = "J.K. Rowling", AnoLivro = 2000, AnoFilme = 2005 },
            new Livro { Id = "Harry5", Titulo = "Harry Potter e a Ordem da Fênix", Autor = "J.K. Rowling", AnoLivro = 2003, AnoFilme = 2007 },
            new Livro { Id = "Harry6", Titulo = "Harry Potter e o Enigma do Príncipe", Autor = "J.K. Rowling", AnoLivro = 2005, AnoFilme = 2009 },
            new Livro { Id = "Harry7", Titulo = "Harry Potter e as Relíquias da Morte - Parte 1", Autor = "J.K. Rowling", AnoLivro = 2007, AnoFilme = 2010 },
            new Livro { Id = "Harry8", Titulo = "Harry Potter e as Relíquias da Morte - Parte 2", Autor = "J.K. Rowling", AnoLivro = 2007, AnoFilme = 2011 }
        };
    //ROTA GET RAIZ
        app.MapGet("/", () => "api de livros esta em funcionamento");

    //ROTA GET - LISTAR TODOS OS LIVROS
        app.MapGet("/api/livros", ()=> livros);

    //ROTA GET - BUSCAR LIVROS POR ID
        app.MapGet("/api/livros/id", (string id) =>
{
    var livro = livros.FirstOrDefault(l => l.Id == id);
    return livro != null ? Results.Ok(livro) : Results.NotFound("Livro não encontrado");
});

    }
}