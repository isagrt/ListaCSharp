/*using System;
using System.Globalization;

DataConfiguracao config = new DataConfiguracao();

Console.WriteLine("1 - Padrão ");
Console.WriteLine("2- Simples ");
Console.WriteLine("3- Extenso ");
Console.WriteLine("4- Personalizado ");
Console.WriteLine("5- RFC1123 ");

if(!int.TryParse(Console.ReadLine(), out int opcao) || opcao < 1 || opcao > 5) // verifica se foi selecionado de 1 a 5, se não envia mensagem de erro
{
    Console.WriteLine("Opção inválida");
    return;
}

config.DefinirFormato(opcao);


Evento eniac = new Evento //objeto evento
(     //nome
     "ENIAC",
    //data
    new DateTime(1946, 8, 15),
    //descricao
    "Os norte-americanos John Eckert e John Mauchly apresentaram o ENIAC, o primeiro equipamento eletrônico chamado de computador no mundo."

);
Evento rfc1 = new Evento
(
    "RFC1",
    new DateTime(1969, 4, 17),
    "Foi feita a publicação da RFC1, por esse motivo considera-se esse o dia da internet até hoje."
);
Evento alanTuring = new Evento
(
    "Alan Turing",
    new DateTime(1912, 6, 23),
    "Nascimento de Alan Turing, matemático e criptonalista britânico que é considerado o 'pai da informática'"
);

Console.WriteLine("Escolha uma opção: ");
Console.WriteLine("1 - ENIAC: ");
Console.WriteLine("2 - RFC1: ");
Console.WriteLine("3 - Alan Turing: ");

int eventoOpcao = int.Parse(Console.ReadLine());
Evento escolhido = null;


switch (eventoOpcao)
{
    case 1: 
        escolhido = eniac;
        break;
    case 2:
        escolhido = rfc1;
        break;
    case 3:
        escolhido = alanTuring;
        break;
    default:
        Console.WriteLine("Evento inválido!");
        return;
}


Console.WriteLine("Evento");
Console.WriteLine($"Nome: {escolhido.Nome}");
Console.WriteLine($"Data: {config.FormatarData(escolhido.Data)}");
Console.WriteLine($"Descrição: {escolhido.Descricao}");

class Evento // classe evento
{
    public string Nome { get; set;}
    public DateTime Data { get; set;}
    public string Descricao { get; set;}

    public Evento (string nome, DateTime data, string descricao)
    {
        Nome = nome;
        Data = data;
        Descricao = descricao;
    }
}

class DataConfiguracao
{
    private int formato;
    
    public void DefinirFormato(int opcao)
    {
        formato = opcao;
    }

    public string FormatarData(DateTime data)
    {
        switch (formato)
        {
            case 1: 
                return data.ToString();
            case 2: 
                return data.ToString("dd-MM-yy");
            case 3: 
                return data.ToString("dddd, d 'de' MMMM 'de' yyyy", new CultureInfo("pt-BR"));
            case 4: 
                return data.ToString("dd-MM-yyyy HH:mm:ss");
            case 5: 
                return data.ToString("R");
            default:
                return data.ToString();
        }
    }
}*/