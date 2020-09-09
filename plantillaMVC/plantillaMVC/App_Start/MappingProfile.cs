using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using plantillaMVC.Models;
using plantillaMVC.ViewModel;


namespace plantillaMVC.App_Start
{
    public class MappingProfile : AutoMapper.Profile
    {
        public MappingProfile()
        {
            CreateMap<Usuario, UsuarioViewModel>();
            CreateMap<UsuarioViewModel, Usuario>();
            CreateMap<Perfil, PerfilViewModel>();
            CreateMap<PerfilViewModel, Perfil>();
        }
    }
}