public abstract class ItemBiblioteca //usando abtração de classe//
{
    // Propriedades
    public int Id;
    public string Titulo;
    protected string DescricaoInterna; //propriedade protegida//

    // Construtor
    protected ItemBiblioteca(int id, string titulo) 
    {
        Id = id;
        Titulo = titulo;
        DescricaoInterna = "Viagens ao fim do mundo, criaturas fantásticas e batalhas épicas entre o bem e o mal - o que mais um leitor poderia querer de um livro?";
    }
}