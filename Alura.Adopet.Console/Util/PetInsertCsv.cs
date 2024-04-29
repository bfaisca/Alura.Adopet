using Alura.Adopet.Console.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.Adopet.Console.Util
{
    public static class PetInsertCsv
    {
        public static Pet converterText(this string? linha)
        {
            Pet pet;
            string[]? propriedades = linha?.Split(';') ?? throw new ArgumentNullException("Valor da linha não pode ser vazio/nulo.");

            if(string.IsNullOrEmpty(linha)) throw new ArgumentException("Valor da linha não pode ser vazio/nulo.");

            if(propriedades.Length != 3) throw new ArgumentException("Texto invalido!");

            bool sucesso = Guid.TryParse(propriedades[0], out Guid petId);

            if(!sucesso) throw new ArgumentException("Guid invalido!");

            sucesso = int.TryParse(propriedades[2], out int tipoPet);

            if (!sucesso) throw new ArgumentException("Tipo de Pet invalido!");

            if (tipoPet != 0 && tipoPet != 1) throw new ArgumentException("Tipo de Pet Invalido");

            return pet = new Pet(petId, propriedades[1],  int.Parse(propriedades[2]) == 0 ? TipoPet.Gato : TipoPet.Cachorro
            );
        }
    }
}
