using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using WebService.Models;

namespace WebService.DataAccess
{
    public class DataAccessProvider : IDataAccessProvider
    {
        private readonly PostgreSqlContext _context;

        public DataAccessProvider(PostgreSqlContext context)
        {
            _context = context;
        }
        public List<catalumno> GetAlumnos()
        {
            return _context.catalumno.ToList();
        }

        public catalumno GetID(int id)
        {
            return _context.catalumno.Where(al => al.id == id).FirstOrDefault();
        }

        public void PostAlumno(catalumno catalumnoN)
        {
            var catalumnoL = new catalumno
            {
                id = catalumnoN.id,
                nombre = catalumnoN.nombre
            };
            _context.catalumno.Add(catalumnoL);
            _context.SaveChangesAsync();

        }
    }
}
