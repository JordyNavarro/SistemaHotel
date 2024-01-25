using SistemaHotel.Server.Models;
using SistemaHotel.Server.Repositorio.Implementacion;

namespace SistemaHotel.Server.Test.Repositorio
{
    [TestClass]
    public class CategoriaRepositorioTest
    {
        private DbhotelBlazorContext _dbhotelBlazorContext;
        private CategoriaRepositorio _categoriaRepositorio;

        [TestInitialize] 
        public void Init() 
        {
            _dbhotelBlazorContext = new DbhotelBlazorContext();
            _categoriaRepositorio = new CategoriaRepositorio(_dbhotelBlazorContext);
        }

        [TestMethod]
        public async Task Consultar()
        {
            var result = await _categoriaRepositorio.Consultar();
            Assert.IsNotNull(result);
        }
    }
}
