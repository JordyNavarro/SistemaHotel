using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaHotel.Server.Controllers;
using SistemaHotel.Server.Repositorio.Contratos;
using SistemaHotel.Server.Repositorio.Implementacion;
using SistemaHotel.Server.Utilidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaHotel.Server.Test.Controllers
{
    [TestClass]
    public class RecepcionControllerTest
    {
        private IMapper _mapper;
        private IRecepcionRepositorio _recepcionRepositorio;
        private RecepcionController _controller;

        [TestInitialize]
        public void Init()
        {
            _mapper = new MapperConfiguration(mc=>
            {
                mc.AddProfile(new AutoMapperProfile());
            }).CreateMapper();
            _recepcionRepositorio =new RecepcionRepositorio(new Models.DbhotelBlazorContext());
            _controller = new RecepcionController(_recepcionRepositorio, _mapper);
        }

        [TestMethod]
        public async Task Obtener()
        {
            ObjectResult result = (ObjectResult)await _controller.Obtener(2);
            Assert.AreEqual(result.StatusCode, StatusCodes.Status200OK);
        }

        [TestMethod]
        public async Task Guardar()
        {
            ObjectResult result = (ObjectResult)await _controller.Guardar(new Shared.RecepcionDTO());
            Assert.AreEqual(result.StatusCode, StatusCodes.Status200OK);
        }

        [TestMethod]
        public async Task Editar()
        {
            ObjectResult result = (ObjectResult)await _controller.Editar(new Shared.RecepcionDTO());
            Assert.AreEqual(result.StatusCode, StatusCodes.Status200OK);
        }
    }   
}
