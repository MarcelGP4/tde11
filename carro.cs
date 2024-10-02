public class Carro : Veiculo
{

    

    private int numeroDePortas();

    public Carro(int numDePortas, string modelo, string marca, int ano)
    :base(marca,modelo,ano)
    {
        numeroDePortas = numDePortas;
        

    }

    public void abrirMalas()
    {
        Consosle.WriteLine("O porta malas esta aberto")
    }

    public void exibirInformações()
    {
        Console.WriteLine($"{Marca}, {Modelo}, {Ano}, {numeroDePortas}")

    }

    



}