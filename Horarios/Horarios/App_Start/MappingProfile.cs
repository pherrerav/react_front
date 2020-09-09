using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using Horarios.Models;
using Horarios.ViewModel;

namespace Horarios.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Usuario, UsuariosViewModel>();
            CreateMap<UsuariosViewModel, Usuario>();
        }
    }
}