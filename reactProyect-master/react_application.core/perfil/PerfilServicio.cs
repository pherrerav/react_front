using AutoMapper;
using react_application.data.Models;
using react_application.data.Repositorio.perfil;
using react_application.data.ViewModels;
using Microsoft.Extensions.Logging;
using System;
using System.Collections;

namespace react_application.core.perfil
{
    public class PerfilServicio : IPerfilServicio
    {
        private readonly IPerfilRepositorio repoPerfil;
        private readonly ILogger<PerfilServicio> _logger;
        private readonly IMapper _mapper;

        public PerfilServicio(IMapper mapper, IPerfilRepositorio repoPerfil, ILogger<PerfilServicio> logger)
        {
            _mapper = mapper;
            _logger = logger;
            this.repoPerfil = repoPerfil;
        }

        public int AgregarPerfil(PerfilViewModel perfilObj)
        {
            var resultado = 1;
            try
            {
                repoPerfil.GuardarPerfil(_mapper.Map<PerfilViewModel, Perfil>(perfilObj));
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                resultado = -1;
            }
            return resultado;
        }
        public int ModificarPerfil(PerfilViewModel perfilObj)
        {
            int resultado = 1;
            try
            {
                resultado = repoPerfil.ModificarPerfil(_mapper.Map<PerfilViewModel, Perfil>(perfilObj));
                if (resultado == 1)
                {
                    int perfilId = perfilObj.Id;
                    resultado = repoPerfil.EliminarPaginaPerfil(perfilId);
                }
                if (resultado == 1)
                    resultado = repoPerfil.AgregarPaginaPerfil(_mapper.Map<PerfilViewModel, Perfil>(perfilObj));
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                resultado = -1;
            }
            return resultado;
        }
        public ICollection BuscarPaginaPerfil(int id)
        {
            var paginas = repoPerfil.BuscarPaginaPerfil(id);
            return (paginas);
        }

        public IEnumerable GetPerfiles()
        {
            return repoPerfil.GetPerfiles();
        }
    }
}
