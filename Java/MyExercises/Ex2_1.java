package MyExercises;
public class Ex2_1 {
    public static void main(String[] args) {
        Livro livro = new Livro("1984", "George Orwell", 1949, true);
        livro.exibirDetalhes();
        livro.emprestar();
        livro.exibirDetalhes();
        livro.devolver();
        livro.exibirDetalhes();
    }
}