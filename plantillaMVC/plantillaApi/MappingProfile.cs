using AutoMapper;
using plantillaApi.Data.Models;
using plantillaApi.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace plantillaApi
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Usuario, UsuarioViewModel>();
            CreateMap<Perfil, PerfilViewModel>();
        }
    }
}
