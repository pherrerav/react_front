using plantillaApi.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace plantillaApi.Core.Usuarios
{
    public interface IUsuarioServicios
    {
        IEnumerable<Usuario> GetAll();
        Usuario GetById(object id);
        void Insert(Usuario obj);
        void Update(Usuario obj);
        void Delete(int id);
    }
}
