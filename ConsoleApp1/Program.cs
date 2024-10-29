class Program()
{
    static void Main(string[] args)
    {
        List<IVeiculo> listaDeVeiculos = new List<IVeiculo>();

        listaDeVeiculos.Add(new Carro { modelo = "BMW" });
        listaDeVeiculos.Add(new Moto{modelo = "PCX" });
        listaDeVeiculos.Add(new Caminhao{ modelo = "Volvo FH16"});

        foreach(var tipo in listaDeVeiculos)
        {
            tipo.Dirigir();
        } 
    }
}