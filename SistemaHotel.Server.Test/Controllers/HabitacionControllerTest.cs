using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaHotel.Server.Controllers;
using SistemaHotel.Server.Repositorio.Contratos;
using SistemaHotel.Server.Repositorio.Implementacion;
using SistemaHotel.Server.Utilidades;

namespace SistemaHotel.Server.Test.Controllers
{
    [TestClass]
    public class HabitacionControllerTest
    {
        private IMapper _mapper;
        private IHabitacionRepositorio _habitacionRepositorio;
        private static HabitacionController _controller;
        [TestInitialize]
        public void Init()
        {
            _mapper = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new AutoMapperProfile());
            }).CreateMapper();
            _habitacionRepositorio = new HabitacionRepositorio(new Models.DbhotelBlazorContext());
            _controller = new HabitacionController(_habitacionRepositorio, _mapper);
        }
        [TestMethod]
        public async Task Obtener()
        {
            ObjectResult result = (ObjectResult)await _controller.Obtener(2);
            Assert.AreEqual(result.StatusCode, StatusCodes.Status200OK);
        }

        [TestMethod]
        public async Task Lista()
        {
            ObjectResult result = (ObjectResult)await _controller.Lista();
            Assert.AreEqual(result.StatusCode, StatusCodes.Status200OK);
        }

        [TestMethod]
        public async Task Guardar()
        {
            ObjectResult result = (ObjectResult)await _controller.Guardar(new Shared.HabitacionDTO());
            Assert.AreEqual(result.StatusCode, StatusCodes.Status200OK);
        }

        [TestMethod]
        public async Task Editar()
        {
            ObjectResult result = (ObjectResult)await _controller.Editar(new Shared.HabitacionDTO());
            Assert.AreEqual(result.StatusCode, StatusCodes.Status200OK);
        }

        [TestMethod]
        public async Task Eliminar()
        {
            ObjectResult result = (ObjectResult)await _controller.Eliminar(3);
            Assert.AreEqual(result.StatusCode, StatusCodes.Status200OK);
        }
    }
}
