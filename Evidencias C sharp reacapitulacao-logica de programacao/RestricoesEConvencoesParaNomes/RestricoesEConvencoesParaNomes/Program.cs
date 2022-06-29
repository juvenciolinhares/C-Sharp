// See https://aka.ms/new-console-template for more information
namespace Curso //C maiúsculo
{
class ContaBancaria// classe: letra maiuscula
        public string Titular { get; set; } //proriedade: letra maiuscula
    private double _saldo; //atributo interno, começa com _ 

    public void Deposito(double quantia)// pascal Case
    {
        _saldo += quantia;

    }
    public double GetSaldo()
    {
        return _saldo;
    }
}
}

