using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.Adopet.Console
{
    [DocComando(instrucao: "show",
    documentacao: " adopet show   <arquivo> comando que exibe no terminal o conteúdo do arquivo importado.")]
    internal class Show
    {
        public void MostrarInformacoesArquivo(string caminhoArquivoImportacao)
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
