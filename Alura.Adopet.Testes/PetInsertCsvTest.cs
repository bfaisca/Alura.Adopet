﻿using Alura.Adopet.Console.Modelos;
using Alura.Adopet.Console.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.Adopet.Testes
{
    public  class PetInsertCsvTest
    {

        [Fact]
        public void StringValidaToReturnPet()
        {
            //Arrange

            string linha = "456b24f4-19e2-4423-845d-4a80e8854a41;Lima Limão;1";
            //Act

            Pet pet = linha.converterText();

            //Assert

            Assert.NotNull(pet);
        }
    }
}