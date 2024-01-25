using SistemaHotel.Client.Servicios.Implementacion;

namespace SistemaHotel.Client.Test.Servicios
{
    [TestClass]
    public class CategoriaServicioTest
    {
        private HttpClient _httpClient;
        private CategoriaServicio _categoriaServicio;

        [TestInitialize]
        public void Init()
        {
            _httpClient = new HttpClient();
            _categoriaServicio = new CategoriaServicio(_httpClient);
        }

        [TestMethod]
        public async Task Lista()
        {
            var result = await _categoriaServicio.Lista();
            Assert.IsTrue(result.value.Count>0);
        }
    }
}
