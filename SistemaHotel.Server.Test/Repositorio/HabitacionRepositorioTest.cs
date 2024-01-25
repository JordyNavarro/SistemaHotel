using SistemaHotel.Server.Models;
using SistemaHotel.Server.Repositorio.Implementacion;

namespace SistemaHotel.Server.Test.Repositorio
{
    [TestClass]
    public class HabitacionRepositorioTest
    {
        private DbhotelBlazorContext _dbhotelBlazorContext;
        private HabitacionRepositorio _habitacionRepositorio;

        [TestInitialize]
        public void Init()
        {
            _dbhotelBlazorContext = new DbhotelBlazorContext();
            _habitacionRepositorio = new HabitacionRepositorio(_dbhotelBlazorContext);
        }

        [TestMethod]
        public async Task Consultar()
        {
            var result = await _habitacionRepositorio.Consultar();
            Assert.IsNotNull(result);
        }
    }
}