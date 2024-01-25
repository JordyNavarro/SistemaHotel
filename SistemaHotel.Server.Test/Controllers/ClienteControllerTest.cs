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
    public class ClienteControllerTest
    {
        private IMapper _mapper;
        private IClienteRepositorio _clienteRepositorio;
        private ClienteController _Controller;

        [TestInitialize]
        public void Init()
        {
            _mapper = new MapperConfiguration(mc=>
            {
                mc.AddProfile(new AutoMapperProfile());
            }).CreateMapper();
            _clienteRepositorio = new ClienteRepositorio(new Models.DbhotelBlazorContext());
            _Controller = new ClienteController(_clienteRepositorio, _mapper);
        }

        [TestMethod]
        public async Task Lista()
        {
            ObjectResult result = (ObjectResult)await _Controller.Lista();
            Assert.AreEqual(result.StatusCode, StatusCodes.Status200OK);
        }

        [TestMethod]
        public async Task Guardar()
        {
            ObjectResult result = (ObjectResult)await _Controller.Guardar(new Shared.ClienteDTO());
            Assert.AreEqual(result.StatusCode, StatusCodes.Status200OK);
        }

        [TestMethod]
        public async Task Editar()
        {
            ObjectResult result = (ObjectResult)await _Controller.Guardar(new Shared.ClienteDTO());
            Assert.AreEqual(result.StatusCode, StatusCodes.Status200OK);
        }

        [TestMethod]
        public async Task Eliminar()
        {
            ObjectResult result = (ObjectResult)await _Controller.Guardar(new Shared.ClienteDTO());
            Assert.AreEqual(result.StatusCode, StatusCodes.Status200OK);
        }
    }
}
