class Conta
{
    public int Codigo { get; }
    public double Saldo { get; private set; }

    public Conta(int codigo)
    {
        Codigo = codigo;
        Saldo = 0.0;
    }

    public void Sacar(double valor)
    {
        if(valor > Saldo){
            throw new ArgumentException("saque invalido");
        }
        Saldo = Saldo - valor;
    }

    public void Depositar(double valor)
    {
        if(valor <= 0 ){
            throw new ArgumentException("O valor deve ser maior");
        }
        Saldo = Saldo + valor;
    }

    public void Transferir(double valor, Conta conta)
    {
        if(valor > Saldo || valor <=0) throw new ArgumentException("Digite uma valor válido de acordo com seu saldo.");
        Saldo = Saldo - valor;
        conta.Saldo = conta.Saldo + valor;
    }
}