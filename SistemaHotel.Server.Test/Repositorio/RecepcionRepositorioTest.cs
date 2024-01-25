using SistemaHotel.Server.Models;
using SistemaHotel.Server.Repositorio.Implementacion;

namespace SistemaHotel.Server.Test.Repositorio
{
    [TestClass]
    public class RecepcionRepositorioTest
    {
        private DbhotelBlazorContext _dbhotelBlazorContext;
        private RecepcionRepositorio _recepcionRepositorio;

        [TestInitialize]
        public void Init()
        {
            _dbhotelBlazorContext = new DbhotelBlazorContext();
            _recepcionRepositorio = new RecepcionRepositorio(_dbhotelBlazorContext);
        }

        [TestMethod]
        public async Task Consultar()
        {
            var result = await _recepcionRepositorio.Consultar();
            Assert.IsNotNull(result);
        }
    }
}
