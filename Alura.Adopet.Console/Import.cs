using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace Alura.Adopet.Console
{
    [DocComando(instrucao:"import",
        documentacao: " adopet import <arquivo> comando que realiza a importação do arquivo de pets.")]
    internal class Import
    {
        public async Task ImportacaoArquivoPetAsync(string caminhoArquivoImportacao)
        {
            var httpPet = new HttpClientPet();
            LeitorArquivo leitor = new LeitorArquivo();
            List<Pet> listaDePet = leitor.RealizaLeitura(caminhoArquivoImportacao);

            foreach (var pet in listaDePet)
            {
                System.Console.WriteLine(pet);
                try
                {
                    var resposta = await httpPet.CreatePetAsync(pet);
                }
                catch (Exception ex)
                {
                    System.Console.WriteLine(ex.Message);
                }
            }
            System.Console.WriteLine("Importação concluída!");
        }
    }
    
}
