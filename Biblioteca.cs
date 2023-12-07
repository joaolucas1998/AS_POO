public class Biblioteca
{
    private List<ItemBiblioteca> colecao;

    // Construtor
    public Biblioteca()
    {
        colecao = new List<ItemBiblioteca>();
    }

    // Método para adicionar um item à coleção
    public void AdicionarItem(ItemBiblioteca item)
    {
        colecao.Add(item);
    }

    // Método para remover um item da coleção
    public void RemoverItem(ItemBiblioteca item)
    {
        colecao.Remove(item);
    }

    // Método de busca por título
    public ItemBiblioteca BuscarItem(string titulo)
    {
    return colecao.Find(item => item.Titulo == titulo);
    }

    // Sobrecarga de método para buscar por ID
    public ItemBiblioteca BuscarItem(int id)
    {
    return colecao.Find(item => item.Id == id);
    }
}