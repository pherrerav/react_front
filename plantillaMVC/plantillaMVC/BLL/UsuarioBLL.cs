using plantillaMVC.DAL.Repositorio;
using plantillaMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace plantillaMVC.BLL
{
    public class UsuarioBLL
    {
        private IRepositorio<Usuario> repository = null;

        public UsuarioBLL()
        {
            this.repository = new Repositorio<Usuario>();
        }

        public IEnumerable<Usuario> GetAll()
        {
            return repository.GetAll();
        }
        public Usuario GetById(object id)
        {
            return repository.GetById(id);
        }
        public int Insert(Usuario usuarioVm)
        {
            var result = 1;
            try
            {
                Usuario usuario = usuarioVm;
                repository.Insert(usuario);
                repository.Save();
            }
            catch
            {
                result = -1;
            }

            return result;
        }
        public int Update(Usuario usuarioVm)
        {
            var result = 1;
            try
            {
                Usuario usuario = usuarioVm;
                repository.Update(usuario);
                repository.Save();
            }
            catch
            {
                result = -1;
            }

            return result;
        }
    }
}