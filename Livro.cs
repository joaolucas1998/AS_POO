public class Livro : ItemBiblioteca
{
    // Propriedade adicional
    public string Autor;

    // Construtor
    public Livro(int id, string titulo, string autor) : base(id, titulo)
    {
        Autor = autor;
    }

    // Método para exibir a DescricaoInterna
    public void ExibirDescricaoInterna()
    {
        Console.WriteLine($"Descrição Interna do Livro: {DescricaoInterna}");
    }
}