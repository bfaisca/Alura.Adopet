using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Alura.Adopet.Console.Modelos;

namespace Alura.Adopet.Console.Util
{
    internal class LeitorArquivo
    {
        public List<Pet> RealizaLeitura(string caminhoArquivo)
        {
            List<Pet> ListaPet = new List<Pet>();
            using (StreamReader sr = new StreamReader(caminhoArquivo))
            {
                System.Console.WriteLine("----- Serão importados os dados abaixo -----");
                while (!sr.EndOfStream)
                {
                    // separa linha usando ponto e vírgula
                    string[] propriedades = sr.ReadLine().Split(';');
                    // cria objeto Pet a partir da separação
                    Pet pet = new Pet(Guid.Parse(propriedades[0]),
                    propriedades[1],
                    TipoPet.Cachorro
                    );
                    ListaPet.Add(pet);
                }
            }
            return ListaPet;
        }
    }
}
