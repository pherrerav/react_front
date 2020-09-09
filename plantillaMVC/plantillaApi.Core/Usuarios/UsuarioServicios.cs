using plantillaApi.Data.Models;
using plantillaApi.Data.Repositorio;
using System;
using System.Collections.Generic;
using System.Text;

namespace plantillaApi.Core.Usuarios
{
    public class UsuarioServicios : IUsuarioServicios
    {
        private readonly IRepositorio<Usuario> reposUsuario;
        public UsuarioServicios(IRepositorio<Usuario> reposUsuario)
        {
            this.reposUsuario = reposUsuario;
        }
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Usuario> GetAll()
        {
            var usuarios = reposUsuario.GetAll();
            return (usuarios);
        }

        public Usuario GetById(object id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Usuario obj)
        {
            throw new NotImplementedException();
        }

        public void Update(Usuario obj)
        {
            throw new NotImplementedException();
        }
    }

}
