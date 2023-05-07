using System;
//Made by Gabriel F. Dias 07/05/23
//Criação da classe cliente
public class Cliente
{
    public int codigo = 160806;
    public int rg = 123456789; 
    public string nome = "Gabriel Faria Dias";
    public string email = "faria.dias@aluno.ifsp.edu.br";

    //Criação dos metodos CRUD
    public void Create()
    {
        Console.WriteLine("Criado com sucesso");
    }

    public void Read()
    {
        Console.WriteLine("Lido com sucesso");
    }

    public void Update()
    {
        Console.WriteLine("Atualizado com sucesso");
    }

    public void Delete()
    {
        Console.WriteLine("Deletado com sucesso");
    }
}

public class Hotel
{
    public int codigoReserva = 987654321;
    public string nome = "Emperial Hotel";
    public string tipoQuarto = "Luxo";
    public int numQuarto = 16;
    public string dataEntrada = "07/05/23";
    public string dataSaida = "09/05/23";
    public Cliente cliente; //Ligação das classes 'Hotel' e 'Cliente'

    //Criação do metodo 'Reserva()'
    static public void Reserva()
    {
        Console.WriteLine("Reserva efetuada com sucesso");
    }
}

//Metodo Main para mostrar o valor dos atributos
public class Programa
{
    static void Main()
    {
        //instanciamento do Hotel e Cliente
        Hotel hotel = new Hotel(); 
        Cliente cliente = new Cliente();
        hotel.cliente = cliente;//Vinculo dos objetos 'hotel' e 'cliente'

        //função 'Console.WriteLine()' para mostrar o valor dos atributos dos objetos 'hotel' e 'cliente'
        Console.WriteLine("---DADOS CLIENTE---" + "\nCodigo: " + hotel.cliente.codigo + "\nRG: " + hotel.cliente.rg + "\nNome: " + hotel.cliente.nome + "\ne-mail: " + hotel.cliente.email);
        Console.WriteLine("\n\n---DADOS HOTEL---" + "\nCodigo: " + hotel.codigoReserva + "\nNome: " + hotel.nome + "\nTipo Quarto: " + hotel.tipoQuarto + "\nNumero Quarto: " + hotel.numQuarto + "\nData Entrada: " + hotel.dataEntrada + "\nData Saida: " + hotel.dataSaida);

    }
}