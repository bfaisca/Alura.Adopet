using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Alura.Adopet.Console.Util;

namespace Alura.Adopet.Console.Comandos
{
    [DocComando(instrucao: "show",
    documentacao: " adopet show   <arquivo> comando que exibe no terminal o conteúdo do arquivo importado.")]
    internal class Show : IComando
    {
        public Task ExecutarAsync(string[] args)
        {
            this.MostrarInformacoesArquivo(caminhoArquivoImportacao: args[1]);
            return Task.CompletedTask;
        }

        private void MostrarInformacoesArquivo(string caminhoArquivoImportacao)
        {
            LeitorArquivo leitor = new LeitorArquivo();
            var listaPets = leitor.RealizaLeitura(caminhoArquivoImportacao);

            foreach (var pet in listaPets)
            {
                System.Console.WriteLine(pet);
            }
        }
    }
}
