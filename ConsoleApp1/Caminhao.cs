class Caminhao : IVeiculo
{
    public string modelo { get; set;}
    public void Dirigir()
    {
        Console.WriteLine($"Conduzindo o caminhão {modelo}");
    }
}