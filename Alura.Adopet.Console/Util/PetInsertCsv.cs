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
        public static Pet converterText(this string linha)
        {
            string[] propriedades = linha.Split(';');
            Pet pet = new Pet(Guid.Parse(propriedades[0]),
            propriedades[1],
            TipoPet.Cachorro
            );

            return pet;
        }
    }
}
