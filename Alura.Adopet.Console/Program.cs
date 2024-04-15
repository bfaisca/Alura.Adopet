using System.Net.Http.Headers;
using System.Net.Http.Json;
using Alura.Adopet.Console;

Console.ForegroundColor = ConsoleColor.Green;
try
{
    // args[0] é o comando a ser executado pelo programa
    switch (args[0].Trim())
    {
        case "import":
            var import = new Import();
            await import.ImportacaoArquivoPetAsync(caminhoArquivoImportacao:args[1]);
            break;
        case "help":
           var help = new Help();
            help.ExibirDocumentacao(comandoAjuda: args);
            break;
        case "show":
            // args[1] é o caminho do arquivo a ser exibido
            var show = new Show();
            show.MostrarInformacoesArquivo(caminhoArquivoImportacao: args[1]);
            break;
        case "list":
           var list = new List();
            await list.ListarDadosBanco();
            break;
        default:
            // exibe mensagem de comando inválido
            Console.WriteLine("Comando inválido!");
            break;
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