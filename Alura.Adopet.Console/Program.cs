using System.Net.Http.Headers;
using System.Net.Http.Json;
using Alura.Adopet.Console;
using Alura.Adopet.Console.Comandos;

Console.ForegroundColor = ConsoleColor.Green;
Dictionary<string, IComando> comandosDoSistema = new()
{
    { "import",new Import()},
    { "help",new Help()},
    { "show",new Show()},
    { "list",new List()}
};
try
{
    string comandoEscolhido = args[0].Trim();
    if (comandosDoSistema.ContainsKey(comandoEscolhido))
    {
        IComando? cmd = comandosDoSistema[comandoEscolhido];
        await cmd.ExecutarAsync(args);
    }
}
catch (Exception ex)
{
    // mostra a exceção em vermelho
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"Aconteceu um exceção: {ex.Message}");
}
finally
{
    Console.ForegroundColor = ConsoleColor.White;
}