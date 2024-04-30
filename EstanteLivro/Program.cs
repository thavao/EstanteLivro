using EstanteLivro;

//Livro l = new("Senhor dos Anéis", "J. R. R. Tolkien", DateOnly.Parse("03/11/2001"), "Saraiva", 1, "1234567", 500);

Livro[] estante = new Livro[10];
int indice = 0, op = 0;

int Menu()
{
    Console.WriteLine("1 - Cadastrar Livro");
    Console.WriteLine("2 - Imprimir Estante");
    Console.WriteLine("3 - Imprimir Livro Especifico");
    Console.WriteLine("4 - Sair");
    Console.WriteLine("Escolha sua opção: ");
    return int.Parse(Console.ReadLine());
}


Livro CadastrarLivro()
{
    string titulo, autor, editora, isbn;
    int edicao, paginas;
    DateOnly lancamento;

    Console.WriteLine("Informe o titulo do livro: ");
    titulo = Console.ReadLine();
    Console.WriteLine("Informe o autor do livro: ");
    autor = Console.ReadLine();
    Console.WriteLine("Informe a data de lançamento: ");
    lancamento = DateOnly.Parse(Console.ReadLine());
    Console.WriteLine("Informe a editora: ");
    editora = Console.ReadLine();
    Console.WriteLine("Informe a edição: ");
    edicao = int.Parse(Console.ReadLine());
    Console.WriteLine("Informe o ISBN: ");
    isbn = Console.ReadLine();
    Console.WriteLine("Informe a quantidade de páginas: ");
    paginas = int.Parse(Console.ReadLine());

    return new(titulo, autor, lancamento, editora, edicao, isbn, paginas);

}
void AdicionarLivroNaEstante()
{
    if (indice < 10)
        do
        {
            Livro l = CadastrarLivro();
            estante[indice] = l;
            indice++;
            Console.WriteLine("Deseja cadastrar um novo livro?");
            op = int.Parse(Console.ReadLine());
        } while (op != 0 && indice < 10);
    else
        Console.WriteLine("Sua estante está cheia. Não é possível adicionar mais livros.");
}
void ImprimirEstante()
{
    if (indice > 0)
        for (int i = 0; i < indice; i++)
            estante[i].ImprimirLivro();
    else
        Console.WriteLine("Estante vazia...");
}

void BuscarLivro(int i)
{
    if (i > 0 && i < indice)
        estante[i].ImprimirLivro();
    else
        Console.WriteLine("O indice informado não é válido.");
}

do
{
    switch (Menu())
    {
        case 1:
            AdicionarLivroNaEstante();
            break;
        case 2:
            ImprimirEstante();
            break;
        case 3:
            Console.Write("Informe o indice do livro: ");
            BuscarLivro(int.Parse(Console.ReadLine()));
            break;
        case 4:
            Console.WriteLine("Hasta la vista, baby!");
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Opção Inválida!");
            break;
    }
    Console.WriteLine("Pressione Enter para continuar...");
    Console.ReadLine();
} while (true);

