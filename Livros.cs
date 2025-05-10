namespace ApiLivros.Models;

public class Livro{
    public string Id { get; set; }
    public string Titulo { get; set; } = string.Empty;
    public string Autor { get; set; } = string.Empty;
    public int AnoLivro { get; set; }
    public int AnoFilme { get; set; }

}