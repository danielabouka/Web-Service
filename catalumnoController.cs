using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Collections.Generic;
using System.Net.Http;
using WebService.DataAccess;
using WebService.Models;

namespace WebService.Controllers
{
    [Route("api/[controller]")]
    public class catalumnoController : ControllerBase
    {
        private readonly IDataAccessProvider _dataAccessProvider;

        public catalumnoController(IDataAccessProvider dataAccessProvider)
        {
            _dataAccessProvider = dataAccessProvider;
        }

        [HttpGet]
        public IEnumerable<catalumno> Get()
        {
            return _dataAccessProvider.GetAlumnos();
        }


        [HttpGet("{id}")]
        public catalumno Get(int id)
        {

            return _dataAccessProvider.GetID(id);
        }

        [HttpPost]
        public async void PostAlumno(catalumno catalumnoN)
        {
            _dataAccessProvider.PostAlumno(catalumnoN);
        }

    }
}
