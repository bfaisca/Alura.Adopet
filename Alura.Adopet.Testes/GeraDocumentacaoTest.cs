using Alura.Adopet.Console.Comandos;
using Alura.Adopet.Console.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Alura.Adopet.Testes
{
    public class GeraDocumentacaoTest
    {

        [Fact]
        public void ExistemComandosDeveRetornarDicionario()
        {
            //arrange
            Assembly assemblyTipoDocComando = Assembly.GetAssembly(typeof(DocComando))!;

            //Act
            Dictionary<string, DocComando> dicionario = DocumentacaoSistema.ToDictionary(assemblyTipoDocComando);

            //Assert
            Assert.NotEmpty(dicionario);
            Assert.Equal(4,dicionario.Count);
        } 
    }
}
