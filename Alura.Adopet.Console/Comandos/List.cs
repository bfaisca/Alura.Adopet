using Alura.Adopet.Console.Servicos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace Alura.Adopet.Console.Comandos
{
    [DocComando(instrucao: "list",
documentacao: " adopet list comando que exibe no terminal o conteúdo já importado.")]
    internal class List: IComando
    {
        public async Task ExecutarAsync(string[] args)
        {
            await this.ListarDadosBanco();
        }

        private async Task ListarDadosBanco()
        {
            var httpListPet = new HttpClientPet();
            var pets = await httpListPet.ListPetsAsync();
            System.Console.WriteLine("------- Lista de Pets Importados no sistema ------");
            foreach (var pet in pets)
            {
                System.Console.WriteLine(pet);
            }
        }



    }
}
