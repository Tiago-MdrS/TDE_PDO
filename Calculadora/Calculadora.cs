namespace MeuProjeto;

public class Calculadora
{
    public int Soma(int a, int b) => a + b;

    public int Subtracao(int a, int b) => a - b;

    public int Divisao(int a, int b)
    {
        if (b == 0) throw new DivideByZeroException("Divisor não pode ser zero.");
        return a / b;
    }
}
