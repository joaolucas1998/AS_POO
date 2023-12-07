
// instanciando as classes.
Biblioteca biblioteca = new Biblioteca();

Livro livro = new Livro(1, "As Crônicas de Nárnia", "Clive Staples Lewis");

// metodo para adicionar livro
biblioteca.AdicionarItem(livro);

// Buscando livro por título e exibindo detalhes
Livro livroEncontrado = biblioteca.BuscarItem("As Crônicas de Nárnia") as Livro;
    if (livroEncontrado != null)
    {
        Console.WriteLine($"Livro encontrado: {livroEncontrado.Titulo} - {livroEncontrado.Autor}");
        livroEncontrado.ExibirDescricaoInterna();
    }

// metodo para remover livro
biblioteca.RemoverItem(livro);