using Alura.Adopet.Console.Servicos;
using System.Runtime.InteropServices;
using Xunit;

namespace Alura.Adopet.Testes
{
    public class HttpClientPetTest
    {
        [Fact]
        public async Task ListaPetsNotNullAndNotEmpty()
        {
            //Arrange
            var clientPet = new HttpClientPet();
            //Act

            var listaPet = await clientPet.ListPetsAsync();
            //Assert

            Assert.NotNull(listaPet);
            Assert.NotEmpty(listaPet);
        }

        [Fact]
        public async Task TestApiOffline()
        {
            //Arrange
            var clientPet = new HttpClientPet(uri: "http://localhost:1111");

            //Act + Assert
            await Assert.ThrowsAnyAsync<Exception>(() => clientPet.ListPetsAsync());       
        }
    }
}