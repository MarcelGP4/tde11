public class Moto : Veiculo
{
    private bool TemBagageiro;

    public void darGrau()
    {
        Console.WriteLine("Randandandan");

    }

    public void exibirInformações()
    {
        Console.WriteLine($"Marca: {Marca}, Modelo:{Modelo}, Ano:{Ano},Tem Bagageiro{TemBagageiro}");
    }
    :base(marca,modelo,ano,TemBagageiro)
    public Moto(string marca, string modelo, int ano, bool TemBagageiro)
    {
      this.TemBagageiro = TemBagageiro;  


    }

}












