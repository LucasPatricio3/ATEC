package MyExercises;

public class Livro {
    public String Nome;
    public String Autor;
    public int Ano;
    public boolean Disponivel;

    public Livro(String nome, String autor, int ano, boolean disponivel) {
        Nome = nome;
        Autor = autor;
        Ano = ano;
        Disponivel = disponivel;
    }

    public void exibirDetalhes()
    {
        var disp = Disponivel == true ? "Sim" : "Não";
        System.out.println(String.format("Nome: %s, Autor: %s, Ano de Lançamento: %d, Dísponivel: %s", Nome, Autor, Ano, disp));
    }

    public void emprestar()
    {
        Disponivel = false;
    }

    public void devolver()
    {
        Disponivel = true;
    }
}
