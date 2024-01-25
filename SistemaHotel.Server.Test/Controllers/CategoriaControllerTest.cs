﻿using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaHotel.Server.Controllers;
using SistemaHotel.Server.Repositorio.Contratos;
using SistemaHotel.Server.Repositorio.Implementacion;
using SistemaHotel.Server.Utilidades;

namespace SistemaHotel.Server.Test.Controllers
{
    [TestClass]
    public class CategoriaControllerTest
    {
        private IMapper _mapper;
        private ICategoriaRepositorio _categoriaRepositorio;
        private static CategoriaController _controller;
        [TestInitialize]
        public void Init()
        {
            _mapper = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new AutoMapperProfile());
            }).CreateMapper();
            _categoriaRepositorio = new CategoriaRepositorio(new Models.DbhotelBlazorContext());
            _controller = new CategoriaController(_categoriaRepositorio, _mapper);
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
            ObjectResult result = (ObjectResult)await _controller.Guardar(new Shared.CategoriaDTO());
            Assert.AreEqual(result.StatusCode, StatusCodes.Status200OK);
        }

        [TestMethod]
        public async Task Editar()
        {
            ObjectResult result = (ObjectResult)await _controller.Editar(new Shared.CategoriaDTO());
            Assert.AreEqual(result.StatusCode, StatusCodes.Status200OK);
        }

        [TestMethod]
        public async Task Eliminar()
        {
            ObjectResult result = (ObjectResult)await _controller.Eliminar(5);
            Assert.AreEqual(result.StatusCode, StatusCodes.Status200OK);
        }
    }
}
