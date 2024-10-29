class Moto : IVeiculo
{    
    public string modelo { get; set;}
    public void Dirigir()
    {
        Console.WriteLine($"Pilotando a moto {modelo}");
    }
}