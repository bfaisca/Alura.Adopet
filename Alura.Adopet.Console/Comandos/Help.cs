using Alura.Adopet.Console.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Alura.Adopet.Console.Comandos
{
    [DocComando(instrucao: "help",
    documentacao: " adopet help <parametro> ous simplemente adopet help comando que exibe informações de ajuda dos comandos.")]
    internal class Help : IComando
    {
        private Dictionary<string, DocComando> docs;
        public Help()
        {
            docs = DocumentacaoSistema.ToDictionary(Assembly.GetExecutingAssembly());
        }

        public Task ExecutarAsync(string[] args)
        {
            this.ExibirDocumentacao(args);
            return Task.CompletedTask;
        }

        private void ExibirDocumentacao(string[] comandoAjuda)
        {
            System.Console.WriteLine("Lista de comandos.");
            // se não passou mais nenhum argumento mostra help de todos os comandos
            if (comandoAjuda.Length == 1)
            {
                System.Console.WriteLine("adopet help <parametro> ous simplemente adopet help  " +
                     "comando que exibe informações de ajuda dos comandos.");
                System.Console.WriteLine("Adopet (1.0) - Aplicativo de linha de comando (CLI).");
                System.Console.WriteLine("Realiza a importação em lote de um arquivos de pets.");
                System.Console.WriteLine("Comando possíveis: ");

                foreach (var doc in docs.Values)
                {
                    System.Console.WriteLine(doc.Documentacao);
                }
            }
            // exibe o help daquele comando específico
            else if (comandoAjuda.Length == 2)
            {
                string comandoASerExibido = comandoAjuda[1];
                if (docs.ContainsKey(comandoASerExibido))
                {
                    var comando = docs[comandoASerExibido];
                    System.Console.WriteLine(comando.Documentacao);
                }
            }
        }
    }
}
