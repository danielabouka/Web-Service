using System.Collections.Generic;
using WebService.Models;

namespace WebService.DataAccess
{
    /// <summary>
    /// DABOU 06/05/2023
    /// Interface de acceso a metodos de persistencia
    /// </summary>
    public interface IDataAccessProvider
    {
        List<catalumno> GetAlumnos();
        catalumno GetID(int id);
        void PostAlumno(catalumno catalumnoN);
    }
}
