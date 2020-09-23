using AutoMapper;
using react_application.data.Models;
using react_application.data.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace react_application.core
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Usuario, UsuarioViewModel>();
            CreateMap<UsuarioViewModel, Usuario>();
            CreateMap<Perfil, PerfilViewModel>();
            CreateMap<PerfilViewModel, Perfil>();
            CreateMap<ICollection<Pagina_Perfil>, Pagina_Perfil>();
        }
    }
}   
    