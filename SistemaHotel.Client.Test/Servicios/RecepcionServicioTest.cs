using SistemaHotel.Client.Servicios.Implementacion;

namespace SistemaHotel.Client.Test.Servicios
{
    [TestClass]
    public class RecepcionServicioTest
    {
        private HttpClient _httpClient;
        private RecepcionServicio _servicio;

        [TestInitialize] 
        public void Init()
        {
            _httpClient = new HttpClient();
            _servicio = new RecepcionServicio(_httpClient);
        }

        [TestMethod]
        public async Task Obtener()
        {
            var result = await _servicio.Obtener(2);
            Assert.IsNotNull(result);
        }
    }
}
