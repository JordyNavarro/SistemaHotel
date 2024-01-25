using SistemaHotel.Server.Models;
using SistemaHotel.Server.Repositorio.Implementacion;

namespace SistemaHotel.Server.Test.Repositorio
{
    [TestClass]
    public class ClienteRepositorioTest
    {
        private DbhotelBlazorContext _dbhotelBlazorContext;
        private ClienteRepositorio _clienteRepositorio;

        [TestInitialize] 
        public void Init() 
        {
            _dbhotelBlazorContext = new DbhotelBlazorContext();
            _clienteRepositorio = new ClienteRepositorio(_dbhotelBlazorContext);
        }

        [TestMethod]
        public async Task Consultar()
        {
            var result = await _clienteRepositorio.Consultar();
            Assert.IsNotNull(result);
        }
    }
}
