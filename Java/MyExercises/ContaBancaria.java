package MyExercises;

public class ContaBancaria {
    private int numeroConta;
    private double saldo;

    public ContaBancaria(int numeroConta, double saldo) {
        this.numeroConta = numeroConta;
        this.saldo = saldo;
    }

    public void depositar(double valor)
    {
        saldo += valor;
    }
    public void levantar(double valor)
    {
        saldo -= valor;
    }
    public int getNumeroConta()
    {
        return numeroConta;
    }
    public double getSaldo()
    {
        return saldo;
    }
    public void exibirDetalhes()
    {
        System.out.println(String.format("Conta: %d, Saldo: %lf", numeroConta));
    }
}
